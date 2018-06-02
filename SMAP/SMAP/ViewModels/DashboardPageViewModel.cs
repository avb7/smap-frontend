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
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

		public async void OpenEventsDetail(){
			await _navigationService.NavigateAsync("EventsDetailPage");
		}


    }
}
