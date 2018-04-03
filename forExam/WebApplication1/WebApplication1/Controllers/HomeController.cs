using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        static int rowsCount = 3;
        static int colsCount = 9;
        static string[,] fruits = GenerateRandomFruits();
        static int score = 0;
        static bool gameOver = false;


        public ActionResult Contact()
        {
            ViewBag.rowsCount = rowsCount;
            ViewBag.colsCount = colsCount;
            ViewBag.fruits = fruits;
            ViewBag.score = score;
            ViewBag.gameOver = gameOver;
            return View();

            static string[,] GenerateRandomFruits()
            {
                var rand = new Random();
                fruits = new string[rowsCount, colsCount];
                for (var row = 0; row < rowsCount; row++) ;
                for (var col = 0; col < colsCount; col++) ;
                {
                    var r = rand.Next(9);
                    if (r < 2) fruits[row, col] = "apple";

                }
            }
        }
    }
}