using System;
using System.ComponentModel;
using Prism.Navigation;
using Prism.Mvvm;
using Refit;
using SMAP.Models;
using SMAP.Services;
using System.Diagnostics;
using System.Windows.Input;
using Prism.Commands;

namespace SMAP.ViewModels
{
    public class EventsDetailPageViewModel : BindableBase, INavigatedAware
    {
        INavigationService _navigationService;

        public ICommand CloseWindowCommand { get; set; }

        private Event _event;
        public Event _Event
        {
            get { return _event; }
            set
            {
                SetProperty(ref _event, value);
            }
        }

        private string _street;
        public string _Street
        {
            get { return _street; }
            set
            {
                SetProperty(ref _street, value);
            }
        }


        public void OnNavigatedTo(NavigationParameters parameters)
        {
            var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");
            Event event1 = smapAPI.GetEventById((int)parameters["id"]).GetAwaiter().GetResult();
            this._Event = event1;
            this._Street = (string)event1.location["street"];
            this._Street = this._Street.ToUpper();
        }



        public EventsDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseWindowCommand = new DelegateCommand(OnCloseWindow);

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        private async void OnCloseWindow()
        {
            await _navigationService.GoBackAsync();
        }


    }
}
