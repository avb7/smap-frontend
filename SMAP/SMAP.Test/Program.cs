using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;


namespace SMAP.Test
{
    class MainClass
    {

        public class Event
        {
            int Id { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            string type { get; set; }

            string host { get; set; }
            string description { get; set; }

            //yyyy-mm-dd
            string event_date { get; set; }
            //hh:mm:ss
            string start_date { get; set; }
            //hh:mm:ss
            string end_time { get; set; }


            bool is_public { get; set; }
            bool is_free { get; set; }
            int points { get; set; }


            public Event()
            {
            }
        }

        HttpClient client = new HttpClient();

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }

       }

    }

}

