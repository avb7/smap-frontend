using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace SMAP.Views
{
    public partial class CreateEventPage : ContentPage
    {
        void SubmitForm(object sender, System.EventArgs e)
        {

            /*ENFORCE VALIDATION HERE*/

            if(EventTitle.Text.Length == 0 ||EventDescription.Text.Length == 0 
               || EventStreet.Text.Length == 0 || EventZip.Text.Length == 0
               || EventDatePicker.Date < DateTime.UtcNow){

                if(EventTitle.Text.Length == 0){
                    
                }
                if(EventDescription.Text.Length == 0){
                    
                }
                if(EventStreet.Text.Length == 0){
                    
                }
                if(EventZip.Text.Length == 0){
                    
                }

                if (EventDatePicker.Date < DateTime.UtcNow) { 
                
                }
            }

            /* Get location data */
            //street, city, state, zip (to int), country, latitude, longitude
            //City, State, Zip, Country

            string address = EventStreet.Text;
            HttpClient client = new HttpClient();

            //get longitude and latitude 
            string json = client.GetStringAsync("http://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&sensor=true").GetAwaiter().GetResult();

            dynamic data = JObject.Parse(json);
            /*
            try{
               // Console.WriteLine(data.results[0].geometry.location.lat + ", " + data.results[0].geometry.location.lng);
            }
            catch(Exception e){
               // Console.WriteLine("Invalid Address");
            } 
            */
            Dictionary<string, dynamic> _location;

            /*CALL APIS*/



            /*VM NAVIGATION*/

        }

        public CreateEventPage()
        {
            InitializeComponent();
        }
    }
}
