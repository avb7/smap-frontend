using System;
using System.Collections.Generic;
using SMAP.Models;

namespace SMAP.Services
{
    public class UserService
    {

        /*
            getById
            getByEmail 
            getAll

            getFriends(int UserId)
            Create
            
        */

        public UserService()
        {
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
        public User getById(int id){

            User user = null;
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
