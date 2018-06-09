using System;
using System.Collections.Generic;
using SMAP.ViewModels;
using Xamarin.Forms;

namespace SMAP.Views
{
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        public void login(){
            var vm = BindingContext as LoginPageViewModel;
            vm.Login();
        }
    }
}
