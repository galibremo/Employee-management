using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static bool Create(tblEmployeeDTO n)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployeeDTO, tblEmployee>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<tblEmployee>(n);
            return DAF.AccessEmployee().create(converted);
        }
        public static List<tblEmployeeDTO> Get()
        {
            var data = DAF.AccessEmployee().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployee, tblEmployeeDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<tblEmployeeDTO>>(data);
            return cnvrt;
        }
        public static tblEmployeeDTO GetThirdHeighestSalary()
        {
            var data = (from i in DAF.AccessEmployee().viewAll()
                              orderby i.EmployeeSalary descending
                              select i).Skip(2).Take(1).SingleOrDefault();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployee, tblEmployeeDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<tblEmployeeDTO>(data);
            return cnvrt;
        }
        public static tblEmployeeDTO Get(int id)
        {
            var data = DAF.AccessEmployee().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployee, tblEmployeeDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<tblEmployeeDTO>(data);
            return cnvrt;
        }
        public static bool Update(tblEmployeeDTO s)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployeeDTO, tblEmployee>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<tblEmployee>(s);
            var res = DAF.AccessEmployee().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessEmployee().delete(id);
            return res;
        }
    }
}
