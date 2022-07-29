using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class MyController : Controller
    {
        private static List<MyViewModel> lss = new List<MyViewModel>();
        public IActionResult hello()
        {
            //MyViewModel obj1 = new MyViewModel();
            //obj1.Name = "CK";
            //obj1.Age = 10;

            return View(lss);
        }
        public IActionResult world()
        {
            return View();
        }
        public IActionResult create()
        {
            var obj_data = new MyViewModel();
            return View(obj_data);

        }
        public IActionResult submithandle(MyViewModel abcd)
        {
            lss.Add(abcd);
            //return View("hello");
            return RedirectToAction(nameof(hello));
        }
        
        
    }
}
