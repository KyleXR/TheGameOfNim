using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TheGameOfNim.Pages
{
    public class NimController : Controller
    {

        public int selectedRow { get; set; }
        public int removeNum { get; set; }

        public int[] rows = { 1, 3, 5, 7 };



        //This should be a check to make sure that the input from the player is valid
        private bool canTake(int numToSubtract, int rowSelected)
        {
            if (rows[rowSelected - numToSubtract] < 0) return false;

            else return true;

        }


        // This should take the designated "Matches" from the designated row
        public IActionResult takeFromRows()
        {
            int numToSubtract = removeNum;
            int rowSelected = selectedRow;
            if (canTake(numToSubtract, rowSelected) == true)
            {
                rows[rowSelected] -= numToSubtract;
            }

            return View();

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
