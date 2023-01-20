using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Models
{
    class User
    {
        public int userID { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public List<Playlist>? allPlayLists { get; set; }
        public string password { get; set; }
    }
}
