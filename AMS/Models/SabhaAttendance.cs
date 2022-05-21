using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.Models
{
    public class SabhaAttendance
    {

        [Key]
        public int Id { get; set; } 

        [ForeignKey("YuvakId")]
        public int YuvakId { get; set; }
        public Yuvak? Yuvak { get; set; }


        [ForeignKey("SabhaId")]
        public int SabhaId { get; set; }
        public Sabha? Sabha { get; set; }

        [StringLength(12)]
        public DateTime Date { get; set; }
    }
}
