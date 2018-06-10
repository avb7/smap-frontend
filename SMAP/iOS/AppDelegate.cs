using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using SMAP.Helpers;
using Prism;
using Prism.Ioc;



namespace SMAP.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsGoogleMaps.Init("AIzaSyBcWRuiHKkwpSErX9YQBkYBcEEQE6Yyjc0");


            //Xam Auth 
            global::Xamarin.Auth.Presenters.XamarinIOS.AuthenticationConfiguration.Init();

            //Image circle
            ImageCircle.Forms.Plugin.iOS.ImageCircleRenderer.Init();



            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }

        public class iOSInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry containerRegistry)
            {
                
            }
        }

        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
        {
            // Convert NSUrl to Uri
            var uri = new Uri(url.AbsoluteString);

            // Load redirectUrl page
            AuthenticationState.Authenticator.OnPageLoading(uri);

            return true;
        }


    }
}
