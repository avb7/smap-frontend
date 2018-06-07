using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

using System.Net.Http;
using System.Collections.Generic;

using System.Text;
using System.Net;
using System.IO;

using Refit;

namespace SMAP.ServicesAccess
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestService service = new TestService();

            var gitHubApi = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");

            User octocat = gitHubApi.GetUser("test1").GetAwaiter().GetResult();
            Console.WriteLine(octocat.last_name);
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

        public IDictionary<string, string> location { get; set; }
        public User()
        {
        }
    }

    public interface ISmapAPI
    {
        [Get("/users?email={email_id}")]
        Task<User> GetUser(string email_id);
    }

    class TestService
    {










        /*
        public void GetUser(string emailAdd)
        {

            var client = new RestClient("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");

            var request = new RestRequest("/users", Method.GET);

            request.AddParameter("email", "test1");
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);

            //String filters for C#
            var resp = response.Content.ToString().Replace("False", "false");
            resp = resp.Replace("True", "true");
            resp = resp.Replace("None", "null");
            //String filters for C#

            Console.WriteLine(resp);
            var _user =  JsonConvert.DeserializeObject<User>(resp);

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

            Console.WriteLine(_user.last_name);

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



            */

    }


}
