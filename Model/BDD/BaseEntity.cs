using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio
{
    public class BaseEntity
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }
    }
}