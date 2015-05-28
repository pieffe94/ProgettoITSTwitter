using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamScoutAPI.Models
{
    public class TweetModels
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Id_user { get; set; }
        public string Arguments { get; set; }
    }
}