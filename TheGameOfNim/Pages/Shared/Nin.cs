using System.Globalization;

namespace TheGameOfNim.Pages.Shared{

    public class Nin{

        string[] row1 = makeRow(1);
        string[] row2 = makeRow(3);
        string[] row3 = makeRow(5);
        string[] row4 = makeRow(7);

        static public string[] makeRow(int rowSize){

            string[] row = new string[rowSize];
        
            return row;//makes rows

        }

        public string[] removeFromRow(string[] row){

            for (int i = row.Length -1; i > 0; i--){

                if (row[i] != null) row[i] = null; break;
            
            }

            return row;//removes the last non null value from row
        
        } 

        public bool isRowEmpty(string[] row){

            for(int i = 0; i < row.Length; i++){

                if (row[i] != null) return false;
                        
            }

            return true;//checks if empty, can be used to disable buttons
        
        }

    }

}
