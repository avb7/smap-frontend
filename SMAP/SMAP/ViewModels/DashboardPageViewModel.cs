using System;
using Xamarin.Forms.GoogleMaps;
using Prism.Navigation;
using System.Windows.Input;
using Prism.Commands;
using System.Diagnostics;
using SMAP.Services;
using SMAP.Models;
using Refit;
using System.Collections.Generic;

namespace SMAP.ViewModels
{
    public class DashboardPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

        public ICommand MenuCommand { get; set; }
        public ICommand SearchCommand { get; set; }


        public DashboardPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            MenuCommand = new DelegateCommand(OpenMenuPage);
            SearchCommand = new DelegateCommand(OnSearch);


        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }



        private async void OnSearch()
        {

        }


        private async void OpenMenuPage()
        {

            Debug.WriteLine("Clicked");
            await _navigationService.NavigateAsync("MenuPage");
        }

        public async void OpenEventsDetail(NavigationParameters parameters)
        {
            await _navigationService.NavigateAsync("EventsDetailPage", parameters);
        }

        public async void OpenLogin()
        {
            await _navigationService.NavigateAsync("LoginPage");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        //fill map
        //Open event info 
        //Open profile page 
        //Open 


        /*

        1. Constructor loads all the events on the map (fill map)
        2. Write two helper methods "open profile" and "open event info" on prism mvvm stack 
        3. ICommands to call these methods 
        
        */


    }
}
