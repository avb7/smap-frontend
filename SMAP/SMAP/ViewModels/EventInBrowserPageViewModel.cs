using System;
using Prism.Navigation;

namespace SMAP.ViewModels
{
    public class EventInBrowserPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

        public EventInBrowserPageViewModel(INavigationService navigationService)
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
