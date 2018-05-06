using Xamarin.Forms;

namespace SMAP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SMAPPage();
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
