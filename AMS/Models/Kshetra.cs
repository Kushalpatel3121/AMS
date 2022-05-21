using System.ComponentModel.DataAnnotations;

namespace AMS.web.Models
{
    public class Kshetra
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        public int NirdeshakId { get; set; }
        public Karyakar? Karyakar { get; set; }
    }
}