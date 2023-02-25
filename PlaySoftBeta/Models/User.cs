using System.ComponentModel.DataAnnotations;

namespace PlaySoftBeta.Models
{
    public class User
    {
        [Key]
        public string email { get; set; }
        public int UKID { get; set; }
        public string username { get; set; }

        public string password { get; set; }
    }
}
