using AMS.web.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AMS.Models
{
    public class SamparkKaryakar
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("KaryakarId")]
        public int KaryakarId { get; set; }
        public Karyakar? Karyakar { get; set; }

        [ForeignKey("SanchalakId")]
        public int SanchalakId { get; set; }
        public  Sanchalak? Sanchalak { get; set; }

        public int YuvakCount { get; set; }
    }
}
