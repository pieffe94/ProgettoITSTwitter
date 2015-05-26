using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamScoutAPI.Data.ObjectModel
{
    class User
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public int Follower { get; set; }
    }
}
