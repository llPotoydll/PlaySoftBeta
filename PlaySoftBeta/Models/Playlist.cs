namespace PlaySoftBeta.Models
{
    public class Playlist
    {
        public int playlistID { get; set; }
        public string playListName { get; set; }
        public List<Song>? allSongs { get; set;}
        public Boolean privacity { get; set; }
    }
}