using Finalproejt1.Models;
using Finalproejt1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Finalproejt1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _obj;
        public StudentController(IStudentService studentService)
        {
            _obj = studentService;
        }

        public IActionResult Index()
        {
            var obj=_obj.Getall();
            return View(obj);
        }
        public IActionResult Insert() {
            return View();
        
        }
        [HttpPost]
        public IActionResult Insert(Student obj) { 
        _obj.Insert(obj);
        return RedirectToAction("Index");
        }
       public IActionResult Delete(int id)
        {
            if(_obj.Delete(id))
            {
                TempData["Succes"] = "Delete Successfully";
            }
            else
            {
                TempData["Succes"] = "Can not Delete you becouase your age under 20";
            }
            return RedirectToAction("Index");            
        }
        public IActionResult Details(int id)
        {
            var obj=_obj.GetStudent(id);
            return View(obj);


        }
    }
}
