using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetalsAroundTheRose
{
    /// <summary>
    /// Class:      frmPetals : Form
    /// Developer:  Chase Dickerson
    /// Date:       8/28/2017
    /// Purpose:    Performs an old game using Windows form
    /// </summary>
    public partial class frmPetals : Form
    {
        // Declaring Variables
        int currentScore = 0;
        int highScore = 0;
        int correct = 0;
        int incorrect = 0;
        int roseCnt = 0;
        public frmPetals()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Message Box giving an introduction
            MessageBox.Show("Welcome to Petals Around The Rose Game!\n" +
                     "The name of the game is Petals Around the Rose.The name of the game is important. " +
                     "The computer will roll six dice and ask you to guess the score for the roll. " +
                     "The score will always be zero or an even number. Your mission is to work out how the " + 
                     "computer calculates the score and become a Potentate of the Rose.");

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtBxGuess.Text = "";

            roseCnt = 0;

            // Random class used to generate random dice
            Random num = new Random();
            int rand = new int();

            // 1st dice
            // The random number generated will choose which picture to display
            rand = num.Next(0, 6);

            if (rand == 0)
            {
                pbShow1.Image = pb1.Image;
            }
            else if (rand == 1)
            {
                pbShow1.Image = pb2.Image;
            }
            else if (rand == 2)
            {
                roseCnt = roseCnt + 2;
                pbShow1.Image = pb3.Image;
            }
            else if (rand == 3)
            {
                pbShow1.Image = pb4.Image;
            }
            else if (rand == 4)
            {
                roseCnt = roseCnt + 4;
                pbShow1.Image = pb5.Image;
            }
            else if (rand == 5)
            {
                pbShow1.Image = pb6.Image;
            }

            // 2nd dice
            rand = num.Next(0, 6);

            if (rand == 0)
            {
                pbShow2.Image = pb1.Image;
            }
            else if (rand == 1)
            {
                pbShow2.Image = pb2.Image;
            }
            else if (rand == 2)
            {
                roseCnt = roseCnt + 2;
                pbShow2.Image = pb3.Image;
            }
            else if (rand == 3)
            {
                pbShow2.Image = pb4.Image;
            }
            else if (rand == 4)
            {
                roseCnt = roseCnt + 4;
                pbShow2.Image = pb5.Image;
            }
            else if (rand == 5)
            {
                pbShow2.Image = pb6.Image;
            }

            // 3rd dice
            rand = num.Next(0, 6);

            if (rand == 0)
            {
                pbShow3.Image = pb1.Image;
            }
            else if (rand == 1)
            {
                pbShow3.Image = pb2.Image;
            }
            else if (rand == 2)
            {
                roseCnt = roseCnt + 2;
                pbShow3.Image = pb3.Image;
            }
            else if (rand == 3)
            {
                pbShow3.Image = pb4.Image;
            }
            else if (rand == 4)
            {
                roseCnt = roseCnt + 4;
                pbShow3.Image = pb5.Image;
            }
            else if (rand == 5)
            {
                pbShow3.Image = pb6.Image;
            }

            // 4th Dice
            rand = num.Next(0, 6);

            if (rand == 0)
            {
                pbShow4.Image = pb1.Image;
            }
            else if (rand == 1)
            {
                pbShow4.Image = pb2.Image;
            }
            else if (rand == 2)
            {
                roseCnt = roseCnt + 2;
                pbShow4.Image = pb3.Image;
            }
            else if (rand == 3)
            {
                pbShow4.Image = pb4.Image;
            }
            else if (rand == 4)
            {
                roseCnt = roseCnt + 4;
                pbShow4.Image = pb5.Image;
            }
            else if (rand == 5)
            {
                pbShow4.Image = pb6.Image;
            }

            // 5th Dice
            rand = num.Next(0, 6);

            if (rand == 0)
            {
                pbShow5.Image = pb1.Image;
            }
            else if (rand == 1)
            {
                pbShow5.Image = pb2.Image;
            }
            else if (rand == 2)
            {
                roseCnt = roseCnt + 2;
                pbShow5.Image = pb3.Image;
            }
            else if (rand == 3)
            {
                pbShow5.Image = pb4.Image;
            }
            else if (rand == 4)
            {
                roseCnt = roseCnt + 4;
                pbShow5.Image = pb5.Image;
            }
            else if (rand == 5)
            {
                pbShow5.Image = pb6.Image;
            }

            // 6th Dice
            rand = num.Next(0, 6);

            if (rand == 0)
            {
                pbShow6.Image = pb1.Image;
            }
            else if (rand == 1)
            {
                pbShow6.Image = pb2.Image;
            }
            else if (rand == 2)
            {
                roseCnt = roseCnt + 2;
                pbShow6.Image = pb3.Image;
            }
            else if (rand == 3)
            {
                pbShow6.Image = pb4.Image;
            }
            else if (rand == 4)
            {
                roseCnt = roseCnt + 4;
                pbShow6.Image = pb5.Image;
            }
            else if (rand == 5)
            {
                pbShow6.Image = pb6.Image;
            }

            btnGuess.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Prevents user from making more than one guess on a single turn
            btnGuess.Enabled = false;

            // Making input guess a number
            string guess = txtBxGuess.Text;
            double numVal = double.Parse(guess);

            // Checking to see if the guess is correct
            if (numVal == roseCnt)
            {
                lblResult.Text = "***YES***";
                correct = correct + 1;
                lblCorrect.Text = " " + correct;
                currentScore = currentScore + 1;

                // Used to check Best Run
                if (currentScore > highScore)
                {
                    lblBestRun.Text = " " + currentScore;
                    highScore = currentScore;
                }
            }

            // Used if guess is incorrect
            else
            {
                lblResult.Text = "No the correct answer was: " + roseCnt;
                incorrect = incorrect + 1;
                lblWrong.Text = " " + incorrect;
                currentScore = 0;
            }

            // Checking for odd numbers to let the user know the answer won't ever be odd
            if (numVal % 2 != 0)
            {
                lblResult.Text = "No the correct answer was: " + roseCnt + "\n (Must be an even number or zero.)" ;
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instructions
            MessageBox.Show("How to play: " +
                     "The name of the game is Petals Around the Rose.The name of the game is important. " +
                     "The computer will roll six dice and ask you to guess the score for the roll. " +
                     "The score will always be zero or an even number.Your mission is to work out how the " +
                     "computer calculates the score and become a Potentate of the Rose.\n\n" +
                     "Click on Roll to start the game. Type in your guess and click on Accept Guess to get the result. " +
                     "Then either click on Roll for another turn, or exit the program to stop playing. Good luck! ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
