using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        Random nrRand = new Random();
        int nr;
        int time = 0;
        public Form1()
        {
            InitializeComponent();
            gameTimer.Enabled=true;
            nr = nrRand.Next(1, 100);

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            time++;
            timerLbl.Text = Convert.ToString(time);
            

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            
            int guess = Convert.ToInt32(textBox1.Text);

            if (guess > nr)
            {
                textBox2.Text = "mai mic";
            }
            if (guess < nr)
            {
                textBox2.Text = "mai mare";
            }

            if (guess == nr)
            {
                gameTimer.Stop();
                MessageBox.Show("Ai ghicit in " + time.ToString() + " secunde");

                timerLbl.Text = Convert.ToString(time);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
