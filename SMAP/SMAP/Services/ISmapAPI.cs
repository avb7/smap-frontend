using System;
using SMAP.Models;
using Refit;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SMAP.Services
{
    public interface ISmapAPI
    {
        [Get("/users?email={email_id}")]
        Task<User> GetUser(string email_id);

        [Post("/users")]
        Task<string> CreateUser([Body] User user);

        [Post("/friends")]
        Task AddFriend([Body] User user1, User user2);

        //statusType is friends, requests, or responses 
        [Get("/friends?user={email_id}&status={statusType}")]
        Task<User> GetFriends(string email_id, string statusType);

        [Post("/events")]
        Task CreateEvent([Body] Event _event);

        [Get("/events?city={_city}")]
        Task<List<Event>> GetEventsByCity(string _city);

        [Get("/events?event_id={_id}")]
        Task<Event> GetEventById(int _id);

        [Get("/events")]
        Task<List<Event>> GetAllEvents();

        [Get("/events")]
        Task<IEnumerable<Event>> GetAllEventsForSearch();

    }
}
