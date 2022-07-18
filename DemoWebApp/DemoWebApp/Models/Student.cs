using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWebApp.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } 
        public string Name { get; set; }    
        public int RollNumber { get; set; }
        public int Standard { get; set; }
        public string Email { get; set; }

        public string Section { get; set; }

        public string year_of_enrollment { get; set; }
    }
}
