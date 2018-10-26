using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbleSortMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int[] BubSort = new int[10];
            Random rnd = new Random();
            for(int counter=0; counter <10; counter++)
            {
                BubSort[counter] = rnd.Next(1, 100);
            }
            bool swapped;
            do
            {
                swapped = false;
                for (int count = 0; count < BubSort.Length - 1; count++)
                {
                    if (BubSort[count] > BubSort[count + 1])
                    {

                        int temp = BubSort[count + 1];
                        BubSort[count + 1] = BubSort[count];
                        BubSort[count] = temp;
                        swapped = true;
                    }
                }

            } while (swapped == true);
            ViewBag.bubsort = BubSort;
            return View();
        }
    }
}