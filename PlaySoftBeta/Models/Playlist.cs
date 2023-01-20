using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Models
{
    class Playlist
    {
        public int playlistID { get; set; }
        public string playListName { get; set; }
        public List<Song>? allSongs { get; }
        public Boolean privacity { get; set; }
    }
}