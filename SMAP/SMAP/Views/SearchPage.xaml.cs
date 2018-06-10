using System;
using System.Collections.Generic;
using System.Diagnostics;
using SMAP.Models;
using Xamarin.Forms;
using SMAP.ViewModels;
using Prism.Navigation;

namespace SMAP.Views
{
    public partial class SearchPage : ContentPage
    {
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Event dataItem = e.Item as Event;
            Debug.WriteLine(dataItem.event_id);

            // Get the viewmodel from the DataContext
            var vm = BindingContext as SearchPageViewModel;

            //await DisplayAlert("Pin Clicked", $"{e.Pin.Label} Clicked.", "Close");

            var parameters = new NavigationParameters();
            parameters.Add("id", dataItem.event_id);

            vm.OpenEventsDetail(parameters);


        }

        public SearchPage()
        {
            InitializeComponent();
        }
    }
}
