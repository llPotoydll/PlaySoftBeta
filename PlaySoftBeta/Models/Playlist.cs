using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaySoftBeta.Models
{
    public class Playlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int playlistID { get; set; }
        public string playListName { get; set; }
        public string playlistDescription { get; set; }
        public Boolean privacity { get; set; }
        public int UserID { get; set; }
        public double playListDuration {get; set;}
    }
}