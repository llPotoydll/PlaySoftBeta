using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlaySoftBeta.Models
{
    public class PlaylistLines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UKID { get; set; }
        public int playlistID { get; set; }
        public int songID { get; set; }
    }
}
