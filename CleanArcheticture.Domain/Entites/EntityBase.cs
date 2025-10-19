using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArcheticture.Domain.Entites
{
    public class EntityBase
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public EntityBase()
        {
            CreatedDate = DateTime.Now;
            CreatedBy = 1; // default system user, can change later
        }
    }
}
