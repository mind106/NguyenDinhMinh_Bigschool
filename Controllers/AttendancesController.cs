using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using NguyenDinhMinh_Bigschool.DTOs;
using NguyenDinhMinh_Bigschool.Models;

namespace NguyenDinhMinh_Bigschool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDTO attendanceDto)
        {
            var UserId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == UserId && a.CourseId == attendanceDto.CourseId))
                //async => async.AttendeeId == UserId && async.CourseId == attendanceDto.CourseId)
                return BadRequest("The Attendance already exitsts!!!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = UserId
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}