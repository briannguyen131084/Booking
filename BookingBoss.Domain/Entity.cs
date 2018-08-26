using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingBoss.Domain
{
    public abstract class BaseEntity
    {
    }

    public abstract class Entity : BaseEntity, IEntity
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
    }
}
