using System;
using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Employee
    {
        public string Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Login { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}