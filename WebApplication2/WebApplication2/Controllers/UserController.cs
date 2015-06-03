using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamScoutAPI.Data;
using TeamScoutAPI.Data.ObjectModel;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<User> users = DataAccess.GetUsers();
            List<UserModel> result = new List<UserModel>();
            foreach (User u in users)
            {
                UserModel user = new UserModel()
                {
                    Id = u.Id,
                    Location = u.Location,
                    Followers = u.Follower
                };
            }
            return View(result);
        }
        // GET: User/SearchByLocation
        public ActionResult SearchByLocation(string location)
        {
            List<User> users = DataAccess.GetUsersByLocation(location);
            List<UserModel> result = new List<UserModel>();
            foreach (User u in users)
            {
                UserModel user = new UserModel()
                {
                    Id = u.Id,
                    Location = u.Location,
                    Followers = u.Follower
                };
                result.Add(user);
            }
            return View(result);
        }
    }
}