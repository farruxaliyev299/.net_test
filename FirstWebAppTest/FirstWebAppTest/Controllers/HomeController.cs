using Microsoft.AspNetCore.Mvc;
using FirstWebAppTest.Models;
using System.Collections.Generic;

namespace FirstWebAppTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return View(GetStudent(id));
        }

        public Student GetStudent(int? id)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id=1,FullName="Ferrux Eliyev"},
                new Student(){Id=2,FullName="Samir Eliyev"},
                new Student(){Id=3,FullName="Emil Haciyev"}
            };

            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public string Name()
        {
            return "Ferrux";
        }
    }
}
