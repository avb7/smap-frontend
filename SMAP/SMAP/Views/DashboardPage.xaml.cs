using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms;
using SMAP.ViewModels;
using System.Diagnostics;
using SMAP.Helpers;
using Refit;
using SMAP.Services;
using SMAP.Models;
using Prism.Navigation;

namespace SMAP.Views
{
    public partial class DashboardPage : ContentPage
    {

     
        public void ShowUserPicture(){
            if(Settings.UserImageUrl != null){
                CirclePic.Source = Settings.UserImageUrl;
            }
            else{
                CirclePic.Source = "DummyDP.png";
            }
        }

        public DashboardPage()
        {
            InitializeComponent();


            ShowUserPicture();

            //Set map style 
            map.MapStyle = MapStyle.FromJson(getMapStyleJson());

            //TODO Better way to handle icon ref
            _pinTokyo.Icon = _pinTokyo.Icon = BitmapDescriptorFactory.FromBundle("RedPin.png");

            //TODO Better way to handle event clicks, create methods 
			map.PinClicked += Map_PinClicked;
            map.Pins.Add(_pinTokyo);



        }

        protected override async void OnAppearing() { 
            var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");
            List<Event> allEvents = await smapAPI.GetAllEvents();

            List<Pin> pins = new List<Pin>();

            foreach (Event _event in allEvents)
            {
                Pin _pin = new Pin()
                {
                    Type = PinType.Place,
                    Label = _event.name,
                    Address = _event.location["street"],
                    Position = new Position(_event.location["latitude"], _event.location["longitude"]),
                    Icon = BitmapDescriptorFactory.DefaultMarker(Color.LightBlue),
                    Tag = _event.event_id
                };
                _pin.Icon = BitmapDescriptorFactory.FromBundle("GoldPin.png");
                pins.Add(_pin);

            }
            foreach(Pin _pin in pins){
                map.Pins.Add(_pin);
            }

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
            Icon = BitmapDescriptorFactory.DefaultMarker(Color.LightBlue)

        };


		async void Map_PinClicked(object sender, PinClickedEventArgs e)
        {
			// Get the viewmodel from the DataContext
            var vm = BindingContext as DashboardPageViewModel;

            //await DisplayAlert("Pin Clicked", $"{e.Pin.Label} Clicked.", "Close");

            var parameters = new NavigationParameters();
            parameters.Add("id", e.Pin.Tag);

            vm.OpenEventsDetail(parameters);

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
