using System;
using Newtonsoft.Json;
using SMAP.Services;
using SMAP.Models;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using System.Collections.Generic;
using RestSharp.Deserializers;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;

namespace SMAP.Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestService service = new TestService();
            service.PostUser("sevagtester@test.com");

            //foreach (User item in x){
            //    Console.WriteLine(item.email);
            //}
        }

    }

    class TestService{
        
        public void PostUser(string emailAdd)
        {

            var client = new RestClient("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");

            var request = new RestRequest("/users", Method.POST);

            string body = "{\"email\": \"test1\", \"display_name\":\"Sevag\",\"first_name\":\"sevag\",\"last_name\":\"tester\"}";
            Console.WriteLine(body);

            request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            Console.WriteLine(response.StatusCode);

            /*
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1" + "/users");
            client.BaseAddress = uri;

            var parameters = new Dictionary<string, string>();
            parameters["email"] = "test1";

            //var x = JsonConvert.SerializeObject(jsonObj);
            //Console.WriteLine(x);


            HttpResponseMessage response = await client.SendAsync(requestMessage);

            User user = new User();
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<User>(content);
            }

            return user;*/



        }

    }


}
