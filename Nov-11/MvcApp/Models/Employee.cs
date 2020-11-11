using System;
using System.Collections.Generic;using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcApp.Validations;

namespace MvcApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        public Guid EmpID { get; set; }


        [Required(ErrorMessage = "Employee Name can't be blank")]
        [RegularExpression(@"^[A-Za-z .]*$", ErrorMessage = "Employee Name should contain alphabets, spaces and dot (.) only")]
        [MaxLength(40, ErrorMessage = "Employee Name can contain maximum 40 characters")]
        [Display(Name = "Employee Name")]
        public string EmpName { get; set; }


        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        [Range(0, 10000, ErrorMessage = "CTC should be a number between 0 and 10000")]
        [Display(Name = "CTC per hour")]
        public decimal? CTCPerHour { get; set; }


        [Display(Name = "Date of Joining")]
        [DataType(DataType.Date)]
        [DateValidation]
        public DateTime? DateOfJoining { get; set; }
    }
}

