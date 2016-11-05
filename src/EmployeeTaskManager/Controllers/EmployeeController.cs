using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeTaskManager.Models;

namespace EmployeeTaskManager.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {            
            ViewData["Message"] = "Empleados";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        
        /// <summary>
        /// Recibe el empleado y lo almacena en la base de datos
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateEmployee(/** Employee  employee*/)
        {

            // Guarda los cambios en la base de datos
            _context.SaveChanges();
            return Json("");
        }

        [HttpGet]
        public IActionResult LoadTable()
        {
            Dictionary<string, List<object>> response = new Dictionary<string, List<object>>();
            List<Object> list = new List<object>();
            list.Add(new { name="Lopez Helver", position = "Desarrollador"});
            list.Add(new { name = "Ortiz Omar", position = "Analista" });
            list.Add(new { name = "Rodriguez Jeferson", position = "QA" });
            response.Add("data", list);
            return Json(response);
        }
    }
}
