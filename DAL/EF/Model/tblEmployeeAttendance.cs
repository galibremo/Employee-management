using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class tblEmployeeAttendance
    {
        [Key]
        public string EmployeeId { get; set; }
        [Required]
        public DateTime AttendanceDate { get; set; }
        [Required]
        public int IsPresent { get; set; }
        [Required]
        public int IsAbsent { get; set; }
        [Required]
        public int IsOffday { get; set; }

    }
}
