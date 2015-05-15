using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteProgetto.Models;

namespace WebSiteProgetto.Controllers
{
    public class TweetController : Controller
    {
        // GET: Tweet
        public ActionResult Index()
        {
            ImportFileManager manager = new ImportFileManager();
            List<TweetModel> tweets = new List<TweetModel>();
            tweets = manager.ImportFile();
            return View(tweets);
        }
    }
}