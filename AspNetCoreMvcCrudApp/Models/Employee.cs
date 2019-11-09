using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcCrudApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        [Display(Name="Full Name")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        [Display(Name="Employee Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name="Office Location")]
        public string OfficeLocation { get; set; }
    }
}
