using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        [Required]
        public Guid EmpID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z .]*$")]
        [MaxLength(40)]
        public string EmpName { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        [Range(0, 10000)]
        public decimal? CTCPerHour { get; set; }

        public DateTime DateOfJoining { get; set; }
    }
}

