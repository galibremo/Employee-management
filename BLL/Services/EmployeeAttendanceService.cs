using AutoMapper;
using BLL.DTOs;
using DAL.EF.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeAttendanceService
    {
        public static bool Create(tblEmployeeAttendanceDTO n)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployeeAttendanceDTO, tblEmployeeAttendance>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<tblEmployeeAttendance>(n);
            return DAF.AccessEmployeeAttendance().create(converted);
        }
        public static List<tblEmployeeAttendanceDTO> Get()
        {
            var data = DAF.AccessEmployeeAttendance().viewAll();
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployeeAttendance, tblEmployeeAttendanceDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<List<tblEmployeeAttendanceDTO>>(data);
            return cnvrt;
        }
        public static tblEmployeeAttendanceDTO Get(int id)
        {
            var data = DAF.AccessEmployeeAttendance().view(id);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployeeAttendance, tblEmployeeAttendanceDTO>(); });
            var mapper = new Mapper(config);
            var cnvrt = mapper.Map<tblEmployeeAttendanceDTO>(data);
            return cnvrt;
        }
        public static bool Update(tblEmployeeAttendanceDTO s)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<tblEmployeeAttendanceDTO, tblEmployeeAttendance>(); });
            var mapper = new Mapper(config);
            var converted = mapper.Map<tblEmployeeAttendance>(s);
            var res = DAF.AccessEmployeeAttendance().update(converted);
            return res;
        }
        public static bool Delete(int id)
        {
            var res = DAF.AccessEmployeeAttendance().delete(id);
            return res;
        }
    }
}
