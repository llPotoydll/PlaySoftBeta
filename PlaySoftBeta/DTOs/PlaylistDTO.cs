namespace PlaySoftBeta.DTOs
{
    public class PlaylistDTO
    {
        public int playlistID { get; set; }
        public string playListName { get; set; }
        public string playlistUKID { get; set; }
        public string? playlistDescription { get; set; }
        public Boolean privacity { get; set; }
    }
}