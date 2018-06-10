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
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace SMAP.ViewModels
{
    public class SearchPageViewModel : BindableBase, INavigatedAware
    {

        public ICommand CloseWindowCommand { get; set; }

        public Command SearchCommand
        {
            get
            {
                return new Command(() =>
                {

                        string keyword = _searchText;
                        IEnumerable<Event> searchresult = allEvents.Where(x => x.name.Contains(keyword));

                        Events = searchresult; 

                }
               );


            }
        }

        INavigationService _navigationService;

        private string _searchText;
        public string searchText
        {
            get { return _searchText; }
            set
            {
                SetProperty(ref _searchText, value);
            }
        }


        private IEnumerable<Event> _events;
        public IEnumerable<Event> Events
        {
            get { return _events; }
            set
            {
                SetProperty(ref _events, value);
            }
        }

        private IEnumerable<Event> _allEvents;
        public IEnumerable<Event> allEvents
        {
            get { return _allEvents; }
            set
            {
                SetProperty(ref _allEvents, value);
            }
        }

        private bool _isEmpty;
        public bool isEmpty
        {
            get { return _isEmpty; }
            set
            {
                SetProperty(ref _isEmpty, value);
            }
        }

        private bool _isBusy;
        public bool isBusy
        {
            get { return _isBusy; }
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }

        public SearchPageViewModel(INavigationService navigationService)
        {
            isBusy = false;
            CloseWindowCommand = new DelegateCommand(OnCloseWindow);
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           // throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
            var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");
            IEnumerable<Event> events = smapAPI.GetAllEventsForSearch().GetAwaiter().GetResult();
            allEvents = events;
            Events = events;
            isBusy = true;
        }

        private async void OnCloseWindow()
        {
            await _navigationService.GoBackAsync();
        }

        public async void OpenEventsDetail(NavigationParameters parameters)
        {
            await _navigationService.NavigateAsync("EventsDetailPage", parameters);
        }
    }
}
