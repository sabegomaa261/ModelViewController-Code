﻿using MVCDayOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDayOne.Controllers
{
    public class homeController : Controller
    {
        // Get verb
        public ViewResult index()
        {
            return View();
        }

        #region MyRegion
        //post verb
        [HttpPost] // when form method is post 
        public ViewResult index(int id, string name, int age)
        {
            return View();
        }

        #endregion

        #region MyRegion
        //public ViewResult add(int id, string name, int age)
        //{
        //    // Dictionary

        //    ViewData["id"] = id;
        //    ViewData["name"] = name;
        //    ViewData["age"] = age;

        //    return View();
        //} 
        #endregion

        //public ViewResult add(studentdata s)

        //{
        //    var q = new homestudents() { fullname = s.name, age = s.age , location = s.Address };
        //    return View(q);
        //}

        public ViewResult add()
        {
            ITIContext context = new ITIContext();

            List<Student> students = context.Students.ToList();
            List<Department> departments = context.Departments.ToList();

            studentdept sd = new studentdept() { students= students , departments = departments };

            return View(sd);  
        }

        public ActionResult test(int id)
        {

            ITIContext context = new ITIContext();

            List<Student> students = context.Students.ToList();
            List<Department> departments = context.Departments.ToList();

            studentdept sd = new studentdept() { students = students, departments = departments };


            //List<studentdata> students = new List<studentdata>()
            //{
            //    new studentdata{name = "saber" , age = 22 , Address = "egy"},
            //    new studentdata{name = "maher" , age = 22 , Address = "egy"},
            //    new studentdata{name = "eman" , age = 22 , Address = "egy"},
            //};

            if (id == 1)
                return Content("saber");
            else if (id == 2)
                return new EmptyResult();
            else if (id == 3)
                return Json(students, JsonRequestBehavior.AllowGet);
            else if (id == 4)
                return File("/attachments/DbTs2.txt", "text/plain");//mime types
            else if (id == 5)
                return File("/attachments/AI_L2.pdf", "application/pdf");//mime types
            else if (id == 6)
                return Redirect("http://www.google.com");
            else if (id == 7)
                return View("index");
            else if (id == 8)
                return View("add", sd);
            else if (id == 9)
                return RedirectToAction("add");
            else if (id == 10)
                return RedirectToAction("contacts", new { name = "saber", address = "EGY" });

            else
                return View();
        }

        public ActionResult contacts(string name ,string address)
        {
            return View();
        }

    }
}