﻿using MoviesMVC.Controllers;
using MoviesMVC.Models;
using MoviesMVC.Views;

namespace MoviesMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Model, View, and Controller
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(model, view);

            // Start the program
            controller.Run();
        }
    }
}