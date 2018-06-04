using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using SMAP.ViewModels;

namespace SMAP.Views
{
    public partial class DashboardPage : ContentPage
    {

     

        public DashboardPage()
        {
            InitializeComponent();

            //Set map style 
            map.MapStyle = MapStyle.FromJson(getMapStyleJson());

            //TODO Better way to handle icon ref
            _pinTokyo.Icon = _pinTokyo.Icon = BitmapDescriptorFactory.FromBundle("RedPin.png");

            //TODO Better way to handle event clicks, create methods 
			map.PinClicked += Map_PinClicked;
            map.Pins.Add(_pinTokyo);
            

        }

        public string getMapStyleJson(){
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(DashboardPage)).Assembly;
            System.IO.Stream stream = assembly.GetManifestResourceStream("SMAP.Helpers.GoogleMapsStyle.json");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        // TODO , make methods The pin
        readonly Pin _pinTokyo = new Pin()
        {
            Type = PinType.Place,
            Label = "A$AP Mob",
            Address = "San Diego, California",
            Position = new Position(32.727387, -117.162186),
            Icon = BitmapDescriptorFactory.DefaultMarker(Color.LightBlue),
           
           
        };


		async void Map_PinClicked(object sender, PinClickedEventArgs e)
        {
			// Get the viewmodel from the DataContext
            var vm = BindingContext as DashboardPageViewModel;
            
			await DisplayAlert("Pin Clicked", $"{e.Pin.Label} Clicked.", "Close");

            vm.OpenLogin();

            // If you set e.Handled = true,
            // then Pin selection doesn't work automatically.
            // All pin selection operations are delegated to you.
            // Sample codes are below.
            //if (switchHandlePinClicked.IsToggled)
            //{
            //    map.SelectedPin = e.Pin;
            //    map.MoveToRegion(MapSpan.FromCenterAndRadius(e.Pin.Position, Distance.FromMeters(500)), true);
            //}
        }


    }
}
