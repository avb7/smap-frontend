using System;
using Prism.Navigation;

namespace SMAP.ViewModels
{
	public class EventsDetailPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

		public EventsDetailPageViewModel(INavigationService navigationService)
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


    }
}
