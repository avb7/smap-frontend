using System;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Xamarin.Forms;
using SMAP.Views;
using SMAP.ViewModels;
using Prism.Navigation;

namespace SMAP
{
    public partial class App : PrismApplication
    {
        
        public App(){
            
        }

        public App(IPlatformInitializer initializer = null) : base(initializer) 
        {
            InitializeComponent();
            //START PAGE (Add login checks?)
            NavigationService.NavigateAsync("/DashboardPage");
      
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
			containerRegistry.RegisterForNavigation<EventsDetailPage, EventsDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();
            containerRegistry.RegisterForNavigation<EventInBrowserPage, EventInBrowserPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<AddFriendPage, AddFriendPageViewModel>();
            containerRegistry.RegisterForNavigation<SearchPage, SearchPageViewModel>();
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



        //AUTH STUFF BELOW 
        public void NavigateToDashboard(){
            NavigationService.GoBackAsync();
        }

        public static bool IsLoggedIn
        {
            get { return !string.IsNullOrWhiteSpace(_Token); }
        }

        static string _Token;
        public static string Token
        {
            get { return _Token; }
        }

        public static void SaveToken(string token)
        {
            _Token = token;
        }

       public static Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() => {
                   
                });
            }
        }

    }
}
