using System;
using Xamarin.Forms.GoogleMaps;
using Prism.Navigation;
using System.Windows.Input;
using Prism.Commands;
using System.Diagnostics;

namespace SMAP.ViewModels
{
    public class DashboardPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

        public ICommand MenuCommand { get; set; }

        public DashboardPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            MenuCommand = new DelegateCommand(OpenMenuPage);

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public async void OpenMenuPage(){
            Debug.WriteLine("Clicked");
            await _navigationService.NavigateAsync("MenuPage");
        }

		public async void OpenEventsDetail(){
			await _navigationService.NavigateAsync("EventsDetailPage");
		}

        public async void OpenLogin()
        {
            await _navigationService.NavigateAsync("LoginPage");
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
