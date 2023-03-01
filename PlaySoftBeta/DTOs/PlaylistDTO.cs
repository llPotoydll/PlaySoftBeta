namespace PlaySoftBeta.DTOs
{
    public class PlaylistDTO
    {
        public string playListName { get; set; }
        public string playlistUserEmail { get; set; }
        public string? playlistDescription { get; set; }
        public Boolean privacity { get; set; }
        public double playListDuration { get; set; }

    }
}