using System;
using SMAP.Helpers;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Prism.Navigation;
using Xamarin.Auth;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Windows.Input;
using Prism.Commands;
using System.Diagnostics;
using Refit;
using SMAP.Services;
using SMAP.Models;


namespace SMAP.ViewModels
{
    public class LoginPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

		public ICommand OnLogin {get; set;}


        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnLogin = new DelegateCommand(Login);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //garathrow new NotImplementedException();
        }



        public void OnLoginClicked()
        {
            _navigationService.NavigateAsync("DashboardPage");
            Debug.WriteLine("EMAIL IS: " + Settings.UserEmail);

        }

        public async void Login(){

            if(Settings.IsLoggedIn){
                //Open API
                var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");

                //Check user exists 
                User _user = await smapAPI.GetUser(Settings.UserEmail);

            

                //Exists
                if (_user != null){
                    
                }
                //Doesn't exist, register
                else{
                    Debug.WriteLine("User was null");

                    var names = Settings.UserFullName.Split(' ');
                    string firstName = names[0];
                    string lastName = names[1];

                    User newUser = new User()
                    {
                        display_name = Settings.UserFullName,
                        email = Settings.UserEmail,
                        first_name = firstName,
                        last_name = lastName
                    };
                   string response = await smapAPI.CreateUser(newUser);
                   Debug.WriteLine("API RESPOSE = " + response);
                }

                await _navigationService.NavigateAsync("/DashboardPage");

            }

        }



    }
}
