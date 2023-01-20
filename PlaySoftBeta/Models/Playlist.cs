namespace PlaySoftBeta.Models
{
    class Playlist
    {
        public string playListName { get; set; }
        public List<Song>? allSongs { get; }
        public Boolean privacity { get; set; }
    }
}