using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SMAP.Helpers;

namespace SMAP.Views
{
    public partial class MenuPage : ContentPage
    {



        public MenuPage()
        {
            InitializeComponent();

            ShowUserInfo();
        }


        //Show user picture 
        public void ShowUserInfo()
        {
            if(Settings.IsLoggedIn){
                if (Settings.UserImageUrl != null)
                {
                    CirclePic.Source = Settings.UserImageUrl;
                }
                if(Settings.UserFullName != null){
                    DisplayName.Text = Settings.UserFullName;
                }

                //Display options & log out, and hide sign in
                Options.IsVisible = true;
                LogOutButton.IsVisible = true;
                SignInButton.IsVisible = false;
            }

            else
            {
                CirclePic.Source = "DummyDP.png";
                DisplayName.Text = "Guest";


                //Hide options and &log out, and display sign in
                Options.IsVisible = false;
                LogOutButton.IsVisible = false;
                SignInButton.IsVisible = true;
            }

        }

        //Logout/Login button

    }
}
