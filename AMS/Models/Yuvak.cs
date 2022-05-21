using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.Models
{
    public class Yuvak
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }
        public DateTime DoB { get; set; }
        public string? Address { get; set; }

        [StringLength(15)]
        public string? Mobile { get; set; }

        [StringLength(30)]
        public string? Education { get; set; }

        [StringLength(30)]
        public string? Email { get; set; }

        [ForeignKey("MandalId")]
        public int MandalId { get; set; }
        public Mandal? Mandal { get; set; }

        [ForeignKey("SamparkId")]
        public int SamparkId { get; set; }
        public SamparkKaryakar? SamparkKaryakar { get; set; }
    }
}
