using AMS.web.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AMS.Models
{
    public class Sanchalak
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("KaryakarId")]
        public int KaryakarId { get; set; }
        public Karyakar? Karyakar{ get; set; }

        [ForeignKey("MandalId")]
        public int MandalId { get; set; }
        public Mandal? Mandal { get; set; }

    }
}
