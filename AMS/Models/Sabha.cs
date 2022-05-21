using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AMS.Models
{
    public class Sabha
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MandalId")]
        public int MandalId { get; set; }
        public Mandal? Mandal { get; set; }

        [StringLength(12)]
        public DateTime Date { get; set; }
    }
}
