using System.ComponentModel.DataAnnotations;

namespace AMS.web.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? RoleName { get; set; }


    }
}
