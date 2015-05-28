using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeamScoutAPI.Data;
using TeamScoutAPI.Models;

namespace TeamScoutAPI.Controllers
{
    public class TweetController : ApiController
    {
        // GET: api/Tweet
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tweet/5
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/Tweet/5
        public IHttpActionResult Get(string arg)
        {
            int e = DataAccess.GetNumberOfTweets(arg);
            if (e == null)
                return NotFound();
            else
            {
                TweetModels tweet = new TweetModels();
                tweet.Id=

                
                return Ok(tweet);
            }
        }

        // POST: api/Tweet
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tweet/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tweet/5
        public void Delete(int id)
        {
        }
    }
}
