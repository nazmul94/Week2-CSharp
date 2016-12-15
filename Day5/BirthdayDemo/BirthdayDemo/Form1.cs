using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayDemo
{
    public partial class Form1 : Form
    {
        string name =  "";
        public Form1()
        {
            InitializeComponent();
        }

        public object DateTimePickerBirthdate { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void birthdayMessageButton_Click(object sender, EventArgs e)
        {
            //get name entered
            name = textBox1.Text;
            //get date and calculate age
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePickerBirthdate.Value;
            int years = (int)ageDays.TotalDays / 365;
            int day = dateTimePickerBirthdate.Value.Day;
            string month = dateTimePickerBirthdate.Value.ToString("MMMM");

            //create Message
            labelMessage.Text = "Hello" + name + "! You will be " + (years + 1) + " years old on " + day + " " + month + ".";
        }

        private void dateTimePickerBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
