using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDinhMinh_Bigschool.Models;

namespace NguyenDinhMinh_Bigschool.Controllers
{
    public class CourseViewModel : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseViewModel()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel();
            return View(viewModel);
        }
    }
}