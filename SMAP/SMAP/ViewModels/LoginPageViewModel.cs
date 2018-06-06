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

namespace SMAP.ViewModels
{
    public class LoginPageViewModel : INavigatedAware
    {
        INavigationService _navigationService;

		public ICommand OnLogin {get; set;}


        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnLogin = new DelegateCommand(OnLoginClicked);
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
            Debug.WriteLine("CALLED");
            string clientId = null;
            string redirectUri = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    clientId = Constants.iOSClientId;
                    redirectUri = Constants.iOSRedirectUrl;
                    break;

                case Device.Android:
                    clientId = Constants.AndroidClientId;
                    redirectUri = Constants.AndroidRedirectUrl;
                    break;
            }



            var authenticator = new OAuth2Authenticator(
                clientId,
                null,
                Constants.Scope,
                new Uri(Constants.AuthorizeUrl),
                new Uri("http://www.facebook.com/connect/login_success.html"),
                new Uri(Constants.AuthorizeUrl), null, true)
            { AllowCancel = true
            };

            authenticator.Completed += OnAuthCompleted;
            authenticator.Error += OnAuthError;

            AuthenticationState.Authenticator = authenticator;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(authenticator);


        }

        private void OnAuthCompleted(object sender,
             AuthenticatorCompletedEventArgs e)
        {
            if (e.IsAuthenticated)
            {
                var token = new FacebookOAuthToken
                {
                    AccessToken =
                       e.Account.Properties["access_token"]
                };
                // Do something

            }
            else
            {
                // The user is not authenticated
            }
        }


        void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            //Error, do something
            //Debug.WriteLine("Authentication error: " + e.Message);

        }


        /*****************/

        /*
         * Continue 
         * - uses FB SDK and gets email 
         */

         /*
          * - bool CheckUserExists  
          * - Use email to check user exists in the app
          */

         /*
          * - POST new user by email 
          */
          
         /*
          * Update Login Settings
          * 
          */


        public void Login(){


            //Call FB SDK

            //Check exists 

            //Update settings 

            string email = null;
            UpdateLoginSettings(false, email);
        }

        public void Logout(){
         //update login settings to logout 
         UpdateLoginSettings(true, null);

            //navigate to login page
            //todo move it to profile page 
        }

        bool checkLoggedIn(){
            return Settings.IsLoggedIn;
        }


        void UpdateLoginSettings(bool LogOut, string email){
            if(LogOut){
                Settings.IsLoggedIn = false;
                Settings.UserEmail = null;
            }
            else{
                Settings.IsLoggedIn = true;
                Settings.UserEmail = email;
            }
        }


    }
}
