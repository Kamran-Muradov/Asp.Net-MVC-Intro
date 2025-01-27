﻿using AspNet_MVC.Models;

namespace AspNet_MVC.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }
        public int AgeOfAykhan { get; set; }
        public List<User> Users { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Product> Products { get; set; }
    }
}
