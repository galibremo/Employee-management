﻿using DAL.EF.Model;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAF
    {
        public static IRepo<tblEmployee, bool, int> AccessEmployee()
        {
            return new EmployeeRepo();
        }
        public static IRepo<tblEmployeeAttendance, bool, int> AccessEmployeeAttendance()
        {
            return new EmployeeAttendanceRepo();
        }
    }
}
