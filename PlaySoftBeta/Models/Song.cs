using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Models
{
    class Song
    {
        public string songName { get; set; }
        public decimal duration { get; set; }
        public DateTime publicationDate { get; }
        public int songID { get; }

    }
}