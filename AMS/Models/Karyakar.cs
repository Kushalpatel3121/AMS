using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMS.web.Models
{
    public class Karyakar
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(20)]
        public DateTime DOB { get; set; }
        public string? Address { get; set; }

        [StringLength(15)]
        public string? MobileNo { get; set; }
        public string? Education { get; set; }

        [ForeignKey("RoleId")]
        public int RoleId { get; set; } 
        public Role? Role { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
