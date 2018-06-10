using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using GoogleMaps.LocationServices;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace SMAP.ServiceTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SMAP Location test");

            /*
            var address = "9175 Judicial Drive";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);


            string latitude = point.Latitude.ToString();
            string longitude = point.Longitude.ToString();

            Console.WriteLine(latitude + longitude);

      

            Dictionary<string, dynamic> _location = new Dictionary<string, dynamic>();
            _location["street"] = "9175 judicial drive";
            _location["city"] = "San diego";
            _location["state"] = "CA";
            _location["zip"] = 92122;
            _location["country"] = "USA";
            _location["latitude"] = 58.9699756;
            _location["longitude"] = 52.292920;


            //location, 
            Event _event = new Event()
            {
                name = "Dummy",
                type="",
                event_date = "2018-01-10",
                start_time = "08:08:09",
                end_time = "08:08:09",
                is_public = true,
                is_free = true,
                points = 100,
                location = _location

            };

            string json = JsonConvert.SerializeObject(_event);
            Console.WriteLine(json);

            var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");


            try{
                smapAPI.CreateEvent(_event).GetAwaiter().GetResult();
            }
            catch(Exception e){
                throw e;
            }
             


            //Console.WriteLine(user_1.last_name);


            //POST USER TEST */

            string address = "9115 Judicial Drive";
            var json = new WebClient().DownloadString("http://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&sensor=true");

            dynamic data = JObject.Parse(json);

            try{
                Console.WriteLine(data.results[0].geometry.location.lat + ", " + data.results[0].geometry.location.lng);
            }
            catch(Exception e){
                Console.WriteLine("Invalid Address");
            } 



        }

       
    }

}
