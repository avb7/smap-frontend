using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace SMAP.ServiceTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SMAP API Tests!!");

            var smapAPI = RestService.For<ISmapAPI>("https://ss6aagzajf.execute-api.us-east-2.amazonaws.com/stage_1");


            //GET USER TEST 
            User user_1 = smapAPI.GetUser("test1").GetAwaiter().GetResult();

            Console.WriteLine(user_1.last_name);


            //POST USER TEST 
        }

    }

    public class Event
    {
        int Id { get; set; }
        string name { get; set; }
        string image { get; set; }
        string type { get; set; }

        string host { get; set; }
        string description { get; set; }
        public IDictionary<string, string> location { get; set; }

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

        [Post("/users")]
        Task CreateUser([Body] User user);

        [Post("/friends")]
        Task AddFriend([Body] User user1, User user2);

        //statusType is friends, requests, or responses 
        [Get("/friends?user={email_id}&status={statusType}")]
        Task<User> GetUser(string email_id, string statusType);

        [Post("/events")]
        Task CreateEvent([Body] Event _event);

    }

}
