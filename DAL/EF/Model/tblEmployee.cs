
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class tblEmployee
    {
        [Key]
        public string EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        [Index(nameof(EmployeeCode), IsUnique = true)]
        [StringLength(10)]
        public string EmployeeCode { get; set; }
        [Required]
        public int EmployeeSalary { get; set; }
        [Required]
        public int SupervisorId { get; set; }

    }
}
