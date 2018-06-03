using System;
using System.Net.Http;
using SMAP.Models;


namespace SMAP.Services
{
    public class EventService
    {
        HttpClient client;
        /*
            - get all
            - get by Id 
            - Create 
            
        */
        public EventService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }


    }
}
