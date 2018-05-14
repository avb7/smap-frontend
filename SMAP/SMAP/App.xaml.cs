using System;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Xamarin.Forms;
using SMAP.Views;
using SMAP.ViewModels;

namespace SMAP
{
    public partial class App : PrismApplication
    {
        
        public App(IPlatformInitializer initializer = null) : base(initializer) 
        {
            InitializeComponent();
            NavigationService.NavigateAsync("DashboardPage");
        }

		protected override void OnInitialized()
		{
			//throw new NotImplementedException();
		}

        /* 
         * Method - RegisterTypes
         * Purpose - To add the pages to the navigation registry 
         *
        */
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
            //throw new NotImplementedException();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
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
