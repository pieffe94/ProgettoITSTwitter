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
    public class TweetController : Controller
    {
        
        // GET: Tweet
        public ActionResult Index()
        {
            List<Tweet> tweets = DataAccess.GetTweets();

            List<TweetModel> result = new List<TweetModel>();

            foreach (Tweet t in tweets)
            {
                TweetModel tweet = new TweetModel();
                tweet.UserId = t.UserId;
                tweet.Argument = t.Arguments;
                tweet.Date = t.Date;
                result.Add(tweet);
            }

            return View(result);
        }

        //GET: Tweet/SearchByArgument
        public ActionResult SearchByArgument(string arg)
        {
            List<Tweet> tweets = DataAccess.GetByArg(arg);

            List<TweetModel> result = new List<TweetModel>();

            foreach (Tweet t in tweets)
            {
                TweetModel tweet = new TweetModel();
                tweet.UserId = t.UserId;
                tweet.Argument = t.Arguments;
                tweet.Date = t.Date;
                result.Add(tweet);
            }

            return View(result);
        }
    }

}