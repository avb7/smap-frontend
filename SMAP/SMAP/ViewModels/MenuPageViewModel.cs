using System;
using Prism.Navigation;

namespace SMAP.ViewModels
{
    public class MenuPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

        public MenuPageViewModel(INavigationService navigationService)
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
