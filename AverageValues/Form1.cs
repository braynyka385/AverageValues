using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {
        int amountOfNums;
        double sumOfNums;
        int number;
        double answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numberBox.Text);
            if (number == 0)
            {
                answer = sumOfNums / amountOfNums;
                outputLabel.Text = Convert.ToString(answer);
            }
            else
            {
                amountOfNums++;
                sumOfNums += number;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            amountOfNums = 0;
            sumOfNums = 0;
            number = 0;
            answer = 0;

            numberBox.Text = "";
            outputLabel.Text = "";
        }
    }
}
