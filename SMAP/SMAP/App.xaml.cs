using System;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Xamarin.Forms;

namespace SMAP
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) 
        {
            InitializeComponent();

            MainPage = new SMAPPage();
        }

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			//throw new NotImplementedException();
		}

		protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
