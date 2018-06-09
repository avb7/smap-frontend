using System;
using Xamarin.Forms.Platform.iOS;
using SMAP.Views;
using Xamarin.Forms;
using Xamarin.Auth;
using SMAP.Helpers;
using SMAP.iOS;
using SMAP.Views;
using SMAP.ViewModels;
using SMAP.Helpers;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Net;

[assembly: ExportRenderer (typeof (LoginPage), typeof (LoginPageRenderer))]

namespace SMAP.iOS
{
    public class FacebookUserModel{
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }

    public class LoginPageRenderer : PageRenderer
    {

        private LoginPage loginPageBase = null;
        public bool loginState = false;

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

			loginPageBase = (LoginPage)this.Element;

            var auth = new OAuth2Authenticator(
                clientId: Constants.iOSClientId, // your OAuth2 client id
                scope: Constants.Scope, // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri(Constants.AuthorizeUrl), // the auth URL for the service
                redirectUrl: new Uri(Constants.iOSRedirectUrl)); // the redirect URL for the service


            auth.Completed += (sender, eventArgs) => {
                // We presented the UI, so it's up to us to dimiss it on iOS.

                

                if (eventArgs.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things
                    App.SaveToken(eventArgs.Account.Properties["access_token"]);
      
                    var json = new WebClient().DownloadString("https://graph.facebook.com/me?fields=id,name,email&access_token="+eventArgs.Account.Properties["access_token"]);
                    Debug.WriteLine("ACCESS TOKEN = " + eventArgs.Account.Properties["access_token"]);

                    FacebookUserModel _user = JsonConvert.DeserializeObject<FacebookUserModel>(json);
                    Debug.WriteLine("PROFILE PIC is: "+ "http://graph.facebook.com/"+_user.id+"/picture?type=large");
                    Debug.WriteLine(_user.name);
                    Debug.WriteLine(_user.email);

                    Settings.IsLoggedIn = true;
                    Settings.UserEmail = _user.email;
                    Settings.UserFullName = _user.name;
                    Settings.UserImageUrl = "http://graph.facebook.com/" + _user.id + "/picture?type=large";

					DismissViewController(true, null);

                    loginState = true;
                }
                else
                {
                    // The user cancelled
                    DismissViewController(true, null);
                    loginState = true;
                }
            };

            if(!loginState){
                PresentViewController(auth.GetUI(), true, null);
            }

        }
    }
}

