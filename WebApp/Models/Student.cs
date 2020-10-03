using System.ComponentModel.DataAnnotations;

namespace WebApp.Models 
{
    public class Student 
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        [Range(1920,2020)]
        public long YearOfBirth { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public string Specialization { get; set; }
    }
}