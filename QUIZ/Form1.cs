using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class QUIZ : Form
    {
        int add1, add2, timeLeft, result = 0;
        Random rand = new Random();
        public QUIZ()
        {
            InitializeComponent();
            check.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            TimeLabel.Text = timeLeft + " sekund";
            if (timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Twoj wynik to " + result + " poprawnych odpowiedzi");
                check.Enabled = false;
                startQuiz.Enabled = true;
            }
        }
        private void startQuiz_Click(object sender, EventArgs e)
        {
            TimeLabel.Text = "30";
            timeLeft = 30;
            timer1.Start();
            start();
        }
        private void check_Click(object sender, EventArgs e)
        {
            
            if (checkAnswer() == true)
            {
                check.Enabled = false;
                MessageBox.Show("RACJA");
                //startQuiz.Enabled = true;
                start();
                result++;

            }

            else MessageBox.Show("Próbuj dalej!!!");
        }
        private void start()
        {
            check.Enabled = true;
            startQuiz.Enabled = false;
            add1 = rand.Next(21);
            add2 = rand.Next(21);
            while(add2>add1)
            {
                add2 = rand.Next(21);
            }
            changeFlag();
            leftPlus.Text = add1.ToString();
            rightPlus.Text = add2.ToString();
        }
        private void changeFlag()
        {
            flaga++;
            if(flaga==1)
            {
                sign.Text = "+";
            }
            else if(flaga==2)
            {
                sign.Text = "-";
                
            }
            else if (flaga == 3)
            {
                sign.Text = "*";
                
            }
            else if (flaga == 4)
            {
                sign.Text = "/";
                flaga = 0;
            }
        }

        private void plusResult_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        int flaga = 0;
        private bool checkAnswer()
        {
            if (add1 + add2 == plusResult.Value && flaga == 1) return true;
            else if (add1 - add2 == plusResult.Value && flaga == 2) return true;
            else if (add1 * add2 == plusResult.Value && flaga == 3) return true;
            else if (add1 / add2 == plusResult.Value && flaga == 0) return true;
            else return false;
        }
    }
}
