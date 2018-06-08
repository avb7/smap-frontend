using System;
using SMAP.Models;
using Refit;
using System.Threading.Tasks;

namespace SMAP.Services
{
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
        Task<User> GetFriends(string email_id, string statusType);

        [Post("/events")]
        Task CreateEvent([Body] Event _event);

        [Get("/users?event_id={_id}&city={_city}")]
        Task<User> GetEvents(string _id, string _city);

    }
}
