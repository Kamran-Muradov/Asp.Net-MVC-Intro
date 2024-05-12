
using AspNet_MVC.Models;
using AspNet_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC.Controllers
{
    public class HomeController : Controller
    {
        //public string GetName(string name)
        //{
        //    return name;
        //}

        //public string Index()
        //{
        //    return "salam";
        //}

        //public int Index(int id)
        //{
        //    return id;
        //}

        //public string Index(string name, string surname)
        //{
        //    return name + " " + surname;
        //}

        public IActionResult Index()
        {
            string text = "Welcome";
            int ageOfAykhan = 24;
            List<string> students = new() { "Emirastan", "Fexriyye", "Elmir", "Ilqar", "Nurlan" };
            HomeVM model = new()
            {
                Text = text,
                Students = students,
                AgeOfAykhan = ageOfAykhan,
                Users = GetAllUsers(),
                StudentList = GetAllStudents(),
                Products = GetAllProducts()
            };

            return View(model);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Age = 100
                },
                new User
                {
                    Id = 2,
                    Age = 50
                }
            };
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new()
                {
                    Id = 1,
                    Name = "Kamran",
                    Surname = "Muradov",
                    Age = 24,
                    Email = "kamran@gmail.com",
                    Phone = "+9942343432"
                },
                new()
                {
                    Id = 2,
                    Name = "Ismayil",
                    Surname = "Ceferli",
                    Age = 22,
                    Email = "ismayil@gmail.com",
                    Phone = "+9943123123"
                },
                new()
                {
                    Id = 3,
                    Name = "Reshad",
                    Surname = "Aghayev",
                    Age = 21,
                    Email = "reshad@gmail.com",
                    Phone = "+99432423423"
                },
                new()
                {
                    Id = 4,
                    Name = "Behruz",
                    Surname = "Eliyev",
                    Age = 28,
                    Email = "behruz@gmail.com",
                    Phone = "+994232432432"
                },
            };
        }

        private List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new()
                {
                    Id = 1,
                    Name = "Iphone 15",
                    Price = 2500,
                    Color = "Black"
                },
                new()
                {
                    Id = 2,
                    Name = "Xiaomi RedMi",
                    Price = 900,
                    Color = "White"

                },
                new()
                {
                    Id = 3,
                    Name = "Galaxy S21",
                    Price = 2200,
                    Color = "Violet"
                   
                },
                new()
                {
                    Id = 4,
                    Name = "Honor",
                    Price = 1300,
                    Color = "Brown"
                },
            };
        }
    }
}
