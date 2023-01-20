namespace PlaySoftBeta.Models
{
    class Playlist
    {
        public int playlistID { get; set; }
        public string playListName { get; set; }
        public List<Song>? allSongs { get; }
        public Boolean privacity { get; set; }
    }
}