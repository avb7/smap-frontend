using System;
using System.Collections.Generic;
using System.Net.Http;
using SMAP.Models;
using SMAP.Helpers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;


namespace SMAP.Services
{
    public class EventService
    {
        private const string Scheme = "x-api-key";
        HttpClient client;
        /* god bless almighty chris uncle kingslayer 
            - get all events with get command
            - get by Id with get command
            - Create 
            
        */
        IDictionary<string,string> header = new Dictionary<string, string>()
                                                                            {
                                                                                {Scheme, Constants.APIKey}
                                                                            };
        
        public EventService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }


        public async Task SaveEventAsync(Event item, bool isNewItem = false){
            var postURL = Constants.BaseURL + "/POST";
            var uri = new Uri (string.Format(postURL,string.Empty));
            client.BaseAddress = uri;
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Scheme, Constants.APIKey);
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(postURL, content);
        }



    }
}
