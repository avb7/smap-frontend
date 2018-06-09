using System;
using Newtonsoft.Json;
using SMAP.Services;
using SMAP.Models;
using System.Threading.Tasks;

using System.Net.Http;
using System.Collections.Generic;

using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using Refit;

namespace SMAP.Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SMAP API Tests!!");

            var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");

            User user_1 = smapAPI.GetUser("test1").GetAwaiter().GetResult();

            Console.WriteLine(user_1.last_name);
        }

    }

    public class User
    {

        public int UserId { get; set; }
        public string display_name { get; set; }
        public string profile_pic { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        //default false 
        public bool mission_curator { get; set; }

        //string yyyy-mm-dd
        public string birthday { get; set; }

        public IDictionary<int, Location> location { get; set; }
        public User()
        {
        }
    }

    public interface ISmapAPI
    {
        [Get("/users?email={email_id}")]
        Task<User> GetUser(string email_id);
    }

   /* class TestService{


        public void GetUser(string emailAdd)
        {

            var client = new RestClient("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");

            var request = new RestRequest("/users", Method.GET);

            request.AddParameter("email", "test1");
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

            return user;



        }


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

            return user;



        }

    }*/


