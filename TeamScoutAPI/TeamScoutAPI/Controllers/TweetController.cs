using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamScoutAPI.Models;

namespace TeamScoutAPI.Controllers
{
    public class TweetController : Controller
    {
        // GET: Tweet
        public ActionResult Index()
        {
            ImportFileManager manager = new ImportFileManager();
            List<TweetModels> tweets = new List<TweetModels>();
            tweets = manager.ImportFile();
            return View(tweets);
        }
    }
}