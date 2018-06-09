using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;
using SMAP.Helpers;

namespace SMAP.ViewModels
{
    public class MenuPageViewModel : INavigatedAware
    {
        public ICommand CloseWindowCommand { get; set; }
        public ICommand OnLogoutCommand { get; set; }
        public ICommand OnLoginCommand { get; set; }

        INavigationService _navigationService;

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseWindowCommand = new DelegateCommand(OnCloseWindow);
            OnLoginCommand = new DelegateCommand(OnLogin);
            OnLogoutCommand = new DelegateCommand(OnLogout);
        }


        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        private async void OnCloseWindow(){
            await _navigationService.GoBackAsync();
        }

        private async void OnLogin(){
            await _navigationService.NavigateAsync("LoginPage");

        }
        private async void OnLogout(){
            Settings.IsLoggedIn = false;
            Settings.UserEmail = null;
            Settings.UserFullName = null;
            Settings.UserImageUrl = "DummyDP.png";

            await _navigationService.NavigateAsync("DashboardPage");
        }

    }
}
