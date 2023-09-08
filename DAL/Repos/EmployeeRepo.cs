using DAL.EF.Model;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : Repo, IRepo<tblEmployee, bool, int>
    {
        public bool create(tblEmployee obj)
        {
            db.TblEmployees.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool delete(int id)
        {
            var exp = db.TblEmployees.Find(id);
            db.TblEmployees.Remove(exp);
            return db.SaveChanges() > 0;
        }

        public bool update(tblEmployee obj)
        {
            var exp = db.TblEmployees.Find(obj.EmployeeId);
            exp.EmployeeName = obj.EmployeeName;
            exp.EmployeeCode = obj.EmployeeCode;
            return db.SaveChanges() > 0;
        }

        public tblEmployee view(int id)
        {
            return db.TblEmployees.Find(id);
        }

        public List<tblEmployee> viewAll()
        {
            return db.TblEmployees.ToList();
        }
    }
}
