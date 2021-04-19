using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Whatsapp.Models
{
    public class UserProfile
    {
        [Key]
        public int UserID { get; set; }
        public User User { get; set; }
        [Required]
        public string LastSeenState { get; set; }
        [Required]
        public string AboutState { get; set; }
        [Required]
        public string ProfilePictureState { get; set; }
        [Required]
        public string GroupState { get; set; }
        [Required]
        public string StatusState { get; set; }
        [Required]
        public DateTime RegisteredAt { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
