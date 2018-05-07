using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

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

            //Image circle
            ImageCircle.Forms.Plugin.iOS.ImageCircleRenderer.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG

            Xamarin.Calabash.Start();
#endif



            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }

        public class iOSInitializer : IPlatformInitializer
        {
            public void RegisterTypes(IContainerRegistry containerRegistry)
            {
                
            }
        }


    }
}
