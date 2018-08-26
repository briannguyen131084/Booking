using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingBoss.Domain
{
    [Table("User")]
    public class UserEntity : Entity
    {
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(25, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
