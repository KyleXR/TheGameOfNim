using System.Globalization;

namespace TheGameOfNim.Pages.Shared{

    public class Nin{

        public int[] rows = { 1, 3, 5, 7 };

        private bool canTake(int numToSubtract, int rowSelected){

            if (rows[rowSelected] == 0) return false;

            if (rows[rowSelected - numToSubtract] >= 0) return true;

            return false;

        }

        public void takeFromRows(int rowSelected, int numToSubtract){ 
        
            if(canTake(numToSubtract, rowSelected) == true){

                rows[rowSelected] -= numToSubtract;
                           
            }
        
        }

    } 
}
