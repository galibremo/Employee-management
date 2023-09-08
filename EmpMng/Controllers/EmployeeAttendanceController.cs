using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpMng.Controllers
{
    public class EmployeeAttendanceController : ApiController
    {
        [HttpGet]
        [Route("api/EmployeeAttendance/all")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = EmployeeAttendanceService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/EmployeeAttendance/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = EmployeeAttendanceService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/EmployeeAttendance/Insert")]
        public HttpResponseMessage Create(tblEmployeeAttendanceDTO s)
        {
            try
            {
                var data = EmployeeAttendanceService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/EmployeeAttendance/Update")]
        public HttpResponseMessage Update(tblEmployeeAttendanceDTO s)
        {
            try
            {
                var data = EmployeeAttendanceService.Update(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/EmployeeAttendance/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = EmployeeAttendanceService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
