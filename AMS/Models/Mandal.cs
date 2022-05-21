using AMS.web.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.Models
{
    public class Mandal
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        public string? Address{ get; set; }  

        [StringLength(40)]
        public string? Area { get; set; }

        [ForeignKey("NirikshakId")]
        public int NirikshakId { get; set; }
        public Karyakar? Karyakar { get; set; }

        [ForeignKey("KshetraId")]
        public int KshetraId { get; set; }
        public Kshetra? Kshetra { get; set; }

        [StringLength(10)]
        public string? Day { get; set; }

    }
}
