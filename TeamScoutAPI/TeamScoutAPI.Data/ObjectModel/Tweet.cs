using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamScoutAPI.Data.ObjectModel
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Id_user { get; set; }
        public string Arguments { get; set; }
    }
}
