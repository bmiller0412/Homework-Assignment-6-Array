using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerAssignment7
{
    class TempBusiness
    {
        private Temperature currentTemp;
        private int testTemp;

        public void SetupTemps(string temp1, string temp2, string temp3, string temp4, string temp5, string temp6, string temp7, string tempBelow)
        {
            currentTemp = new Temperature(int.Parse(temp1), int.Parse(temp2), int.Parse(temp3), int.Parse(temp4), int.Parse(temp5), int.Parse(temp6), int.Parse(temp7));
            if (!string.IsNullOrEmpty(tempBelow))
            {
                testTemp = int.Parse(tempBelow);
            }
            testTemp = int.Parse(tempBelow);
        }

        // average temperature to string
        public string GetTempAverage()
        {
            return currentTemp.GetTempAverage().ToString();
        }

        // highest temperature value to string
        public string GetHighestTemp()
        {
            return currentTemp.GetHighestTempValue().ToString();
        }

        // lowest temperature value to string 
        public string GetLowestTemp()
        {
            return currentTemp.GetLowestTempValue().ToString();
        }

        // determine days below set value
        public string GetDaysBelow()
        {
            return currentTemp.DaysBelow(testTemp).ToString();

        }
    }
}
