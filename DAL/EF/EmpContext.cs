using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EmpContext : DbContext
    {
        public virtual DbSet<tblEmployee> TblEmployees { get; set; }
        public virtual DbSet<tblEmployeeAttendance> TblEmployeeAttenbances { get; set; }
    }
}
