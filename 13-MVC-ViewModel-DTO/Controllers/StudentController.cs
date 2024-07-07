using _13_MVC_ViewModel_DTO.Models;
using _13_MVC_ViewModel_DTO.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _13_MVC_ViewModel_DTO.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student() {Id = 1, FirstName = "Enver", LastName = "Kayrıl", Age = 32},
            new Student() {Id = 2, FirstName = "Fatih", LastName = "Alkan", Age = 33},
            new Student() {Id = 3, FirstName = "Yasin", LastName = "Aydoğdu", Age = 34}
        };

        List<Course> courses = new List<Course>()
        {
            new Course() {Id = 101, Name= "Yazılım"},
            new Course() {Id = 102, Name= "Sistem"},
            new Course() {Id = 103, Name= "Grafik"}
        };

        public IActionResult Index()
        {
            InfoStudentCourseVM infoVMs = new InfoStudentCourseVM()
            {
                Name = "BilgeAdam Akademi",
                Students = students,
                Courses = courses
            };
            return View(infoVMs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudentVM model)
        {
            Student student = new Student() { FirstName = model.FirstName, LastName = model.LastName, Age = model.Age, Status = 1, CreatedDate = DateTime.Now };
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                return Content("Kayıt işlemi gerçekleştirildi.");
            }
            return View(registerVM);
        }
    }
}
