using System;
using System.Collections.Generic;
using System.Net.Http;
using SMAP.Models;
using System.Threading.Tasks;
using SMAP.Helpers;
using Newtonsoft.Json;
using System.Diagnostics; 

namespace SMAP.Services
{
	public class UserService 
    {

        HttpClient client;

        /*
        - getById
        - getByEmail 
        - getAll

        - getFriends(int UserId)
        - Create

        */

        public UserService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        /*
         * Method - getById
         * Parameters - int id
         * Purpose - Fetches the User specified by Id from the API
         * Return type - User 
         * 
         * Notes - Use the API to GET a user by ID 
         * 
         */
        public async Task<User> getById(string emailAdd){
            
            Uri uri = new Uri(Constants.BaseURL + "/users");
            client.BaseAddress = uri;
            User user = new User()
            {
                email = emailAdd
            };

            var x = JsonConvert.SerializeObject(user);
             
            HttpResponseMessage response = await client.GetAsync(x);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<User>(content);
            }

            Debug.WriteLine(user.email);
            return user;
        }


        /*
         * Method - getAll
         * Purpose - Fetches all the Users from the API
         * Return type - List<User>
         * 
         * Notes - Use the API to GET all users
         * 
         */
        public List<User> getAll()
        {
            List<User> userList = null;
            return userList;
        }

       /*
         * Method - getFriends
         * Purpose - Fetches all friends of a user
         * Return type - List<User>
         * 
         * Notes - Use the API to GET friends of a user (id)
         * 
         */
        public List<User> getFriends()
        {
            List<User> friendList = null;
            return friendList;
        }

    }
}
