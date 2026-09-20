using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            //creating variables
            string dayOfWeek, nameOfMonth;
            string numericDayOfMonth, year;

            string fullInfo;

            dayOfWeek = dayOfWeekTextBox.Text;
            nameOfMonth = monthTextBox.Text;
            numericDayOfMonth = dayOfMonthTextBox.Text;
            year = yearTextBox.Text;

            fullInfo = dayOfWeek + ", " + nameOfMonth + " " + numericDayOfMonth + ", " + year;

            dataOutputLabel.Text = fullInfo;


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dataOutputLabel.Text = " ";

        }
    }
}
