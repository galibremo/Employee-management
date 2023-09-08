using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeAttendanceRepo : Repo, IRepo<tblEmployeeAttendance, bool, int>
    {
        public bool create(tblEmployeeAttendance obj)
        {
            db.TblEmployeeAttenbances.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.TblEmployeeAttenbances.Find(id);
            db.TblEmployeeAttenbances.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public bool update(tblEmployeeAttendance obj)
        {
            var exp = db.TblEmployeeAttenbances.Find(obj.EmployeeId);
            exp.AttendanceDate = obj.AttendanceDate;
            exp.IsPresent = obj.IsPresent;
            exp.IsAbsent = obj.IsAbsent;
            exp.IsOffday = obj.IsOffday;
            return db.SaveChanges() > 0;
        }

        public tblEmployeeAttendance view(int id)
        {
            return db.TblEmployeeAttenbances.Find(id);
        }

        public List<tblEmployeeAttendance> viewAll()
        {
            return db.TblEmployeeAttenbances.ToList();
        }
    }
}
