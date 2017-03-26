using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillerAssignment7
{
    public partial class TempValueTally : Form
    {
        TempBusiness tempBus = new TempBusiness();
        public TempValueTally()
        {
            InitializeComponent();
        }

        // loads the values of all 7 temperature text boxes that the user inputs 
        private void LoadTempsButton_Click(object sender, EventArgs e)
        {
            tempBus.SetupTemps(TempValue1Text.Text, TempValue2Text.Text, TempValue3Text.Text, TempValue4Text.Text,
                TempValue5Text.Text, TempValue6Text.Text, TempValue7Text.Text, CheckTempText.Text);
        }

        // takes the average/highest/lowest temperature values and assigns them to the correct labels to display to the user
        private void CalculateTemperatureButton_Click(object sender, EventArgs e)
        {
            AverageAnswerLbl.Text = $"The average temperature is {tempBus.GetTempAverage()}";
            LowestTempLbl.Text = $"The lowest temperature is {tempBus.GetLowestTemp()}";
            HighestTempLbl.Text = $"The highest temperature is {tempBus.GetHighestTemp()}";
        }

        // makes the output label.text values blank when the form loads
        private void TempValueTally_Load(object sender, EventArgs e)
        {
            AverageAnswerLbl.Text = "";
            HighestTempLbl.Text = "";
            LowestTempLbl.Text = "";
        }

        private void CalculateDaysBelowButton_Click(object sender, EventArgs e)
        {
            BelowValueLbl.Text = $"The number of days below this temperature is {tempBus.GetDaysBelow()}";
        }
    }
}
