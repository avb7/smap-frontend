using System;
using Prism.Navigation;

namespace SMAP.ViewModels
{
    public class DashboardPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

        public DashboardPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
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
