using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MillerAssignment7
{
    class Temperature
    {
        private int[] tempValues;

        // default constructor 
        public Temperature()
        {

        }

        // constructor that accepts 7 temperature values
        public Temperature(int temp1, int temp2, int temp3, int temp4, int temp5, int temp6, int temp7)
        {
            tempValues = new int[] {temp1, temp2, temp3, temp4, temp5, temp6, temp7};
            Array.Sort(tempValues);
        }

        public int[] TempValues => tempValues;

        // method to get the average of all temp values in the TempValues array
        public decimal GetTempAverage()
        {
            int totaler = 0;
            foreach (int temp in TempValues)
            {
                totaler += temp;
            }
            return totaler / TempValues.Length;
        }

        // gets the lowest temperature value
        public int GetLowestTempValue()
        {
            return tempValues[0];
        }

        // gets the highest temperature value
        public int GetHighestTempValue()
        {
            return tempValues[6];
        }
    }
}
