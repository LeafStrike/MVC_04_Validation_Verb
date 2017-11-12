using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_project.Models;

namespace MVC_project.Controllers
{
    public class StudentController : Controller
    {
        List<Student> Students;

        // CREATE
        [HttpPost]
        public ViewResult CreateStudent(int id, string name, string surname)
        {
            var student = new Student { Id = id, Name = name, Surname = surname };
            Students.Add(student);
            return View(student);
        }

        // READ
        [HttpGet]
        public Student GetStudentById(int id)
        {
            foreach (Student st in Students)
            {
                if (st.Id == id)
                {
                    return st;
                }
            }
            throw new Exception("No student found for id " + id.ToString() + ".");
        }

        // UPDATE
        [HttpPut]
        public ViewResult SetStudentName(int id, string name)
        {
            foreach (Student st in Students)
            {
                if (st.Id == id)
                {
                    st.Name = name;
                    return View(st);
                }
            }
            throw new Exception("No student found for id " + id.ToString() + ".");
        }

        [HttpPut]
        public ViewResult SetStudentSurname(int id, string surname)
        {
            foreach (Student st in Students)
            {
                if (st.Id == id)
                {
                    st.Surname = surname;
                    return View(st);
                }
            }
            throw new Exception("No student found for id " + id.ToString() + ".");
        }

        [HttpPut]
        public ViewResult SetStudentGroup(int id, int groupId)
        {
            foreach (Student st in Students)
            {
                if (st.Id == id)
                {
                    st.GroupId = groupId;
                    return View(st);
                }
            }
            throw new Exception("No student found for id " + id.ToString() + ".");
        }

        [HttpPut]
        public ViewResult SetStudentStatus(int id, string status)
        {
            foreach (Student st in Students)
            {
                if (st.Id == id)
                {
                    st.Status = status;
                    return View(st);
                }
            }
            throw new Exception("No student found for id " + id.ToString() + ".");
        }

        // DELETE
        [HttpDelete]
        public ViewResult DeleteStudentById(int id)
        {
            foreach (Student st in Students)
            {
                if (st.Id == id)
                {
                    Students.Remove(st);
                    return View(st);
                }
            }
            throw new Exception("No student found for id " + id.ToString() + ".");
        }
    }
}
