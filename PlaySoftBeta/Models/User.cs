namespace PlaySoftBeta.Models

{
    public class User
    {
        public int userID { get; set; }
        public string name { get; set; }
        public List<Playlist>? allPlayLists { get; set; }
        public string password { get; set; }
    }
}
