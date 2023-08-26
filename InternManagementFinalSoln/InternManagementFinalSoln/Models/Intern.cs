using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InternManagementFinalSoln.Models
{
    public class Intern
    {
        [Key]
        [ForeignKey("InternId")]
        public int InternId { get; set; }


        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(25)]
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        [Required(ErrorMessage = "Gender cannot be empty")]
        public string? Gender { get; set; }

        [StringLength(10)]
        public string? Phone { get; set; }

        public string? Email { get; set; }
        public User? User { get; set; }
    }
}
