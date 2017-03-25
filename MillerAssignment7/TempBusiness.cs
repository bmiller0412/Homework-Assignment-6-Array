using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerAssignment7
{
    class TempBusiness
    {
        private Temperature currentTemp;

        public void SetupTemps(string temp1, string temp2, string temp3, string temp4, string temp5, string temp6,
            string temp7)
        {
            currentTemp = new Temperature(int.Parse(temp1), int.Parse(temp2), int.Parse(temp3), int.Parse(temp4), int.Parse(temp5), int.Parse(temp6), int.Parse(temp7));
        }

        public void SetupTemps(int temp1, int temp2, int temp3, int temp4, int temp5, int temp6, int temp7)
        {
            currentTemp = new Temperature(temp1, temp2, temp3, temp4, temp5, temp6, temp7);
        }

        public string GetTempAverage()
        {
            return currentTemp.GetTempAverage().ToString();
        }

        public string GetHighestTemp()
        {
            return currentTemp.GetHighestTempValue().ToString();
        }

        // lowest temperature value to string
        public string GetLowestTemp()
        {
            return currentTemp.GetLowestTempValue().ToString();
        }
    }
}
