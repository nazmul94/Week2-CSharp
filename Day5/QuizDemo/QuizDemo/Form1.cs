using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDemo
{
    public partial class Form1 : Form
    {
        int timeLeft = 10;
        bool q1Correct = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ1A1.Checked)
            {
                labelAnswer1.ForeColor = Color.Red;
                labelAnswer1.Text = "\u00fb"; //cross
                q1Correct = false;
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelAnswer1.ForeColor = Color.Green;
                labelAnswer1.Text = "\u00fc"; //tick
                q1Correct = true;
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelAnswer1.ForeColor = Color.Red;
                labelAnswer1.Text = "\u00fb"; //cross
                q1Correct = false;
            }
        }

        private void labelAnswer1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelAnswer1.ForeColor = Color.Red;
                labelAnswer1.Text = "\u00fb"; //cross
                q1Correct = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(q1Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got it all the quesions right.", "Well done!");
            }
            else if(timeLeft > 0)
            {
                timeLeft--;
                labelTimeLeft.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                labelTimeLeft.Text = "Time's up!";
                MessageBox.Show("You ran out of time", "Sorry");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
            {
                labelAnswer1.ForeColor = Color.Red;
                labelAnswer1.Text = "\u00fb"; //cross
                q1Correct = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelAnswer1.ForeColor = Color.Green;
                labelAnswer1.Text = "\u00fc"; //tick
                q1Correct = true;
            }
        }
    }
}
