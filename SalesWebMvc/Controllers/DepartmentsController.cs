using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;


namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            //Instancia uma lista do tipo Department 
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            //E a retorna como parâmtro no método View
            return View(list);
        }
    }
}