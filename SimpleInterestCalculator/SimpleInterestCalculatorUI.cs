using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculator
{
    public partial class SimpleInterestCalculatorUI : Form
    {
        public SimpleInterestCalculatorUI()
        {
            InitializeComponent();
        }

        public double principalAmount;
        public double annualInterest;
        public double timePeriod;
        public double totalAmount;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            principalAmount = Convert.ToDouble(pricipalAmountTextBox.Text);
            annualInterest = Convert.ToDouble(annualInterestRateTextBox.Text);
            timePeriod = Convert.ToDouble(timePeriodTextBox.Text);

            totalAmount = principalAmount*Math.Pow(1 + annualInterest/100, timePeriod);
            totalAmountTextBox.Text = totalAmount.ToString();

        }
    }
}