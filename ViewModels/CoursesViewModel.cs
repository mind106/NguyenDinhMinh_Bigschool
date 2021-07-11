using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NguyenDinhMinh_Bigschool.Models;

namespace NguyenDinhMinh_Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourse { get; set; }
        public  bool ShowAction { get; set; }
    }
}