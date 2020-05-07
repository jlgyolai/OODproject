using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Design_Project
{
    public partial class TicTacToe : Form
    {
        #region fields
        //when true: it's my turn, false: other's turn
        bool myTurn = true;
        //win counts for each player
        int p1wins = 0;
        int p2wins = 0;
        #endregion

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void gameLogic()
        {
            //check to see if game is over
            bool gameOver = false;

            //HORIZONTAL CASES
            //consideration added to each if statement for blank rows/columns creating a false positive from blank buttons
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != ""))
                gameOver = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
                gameOver = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != ""))
                gameOver = true;

            //VERTICAL CASES
            //consideration added to each if statement for blank rows/columns creating a false positive from blank buttons
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != ""))
                gameOver = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Text != ""))
                gameOver = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Text != ""))
                gameOver = true;

            //DIAGONAL CASES
            //consideration added to each if statement for blank rows/columns creating a false positive from blank buttons
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Text != ""))
               gameOver = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Text != ""))
               gameOver = true;
            
            if(gameOver)
            {
                //game is over, disable all tictactoe buttons
                //not the exit or menu strip buttons
                disableAllButtons();
                //check who won by determining who's turn it was
                if (myTurn)
                {
                    //if myTurn = true; player 1 wins, increase player 1 win total
                    MessageBox.Show("Player 1 Wins!");
                    p1wins++;
                }
                else
                {
                    //if myTurn = false; player 2 wins, increase player 2 win total
                    MessageBox.Show("Player 2 Wins!");
                    p2wins++;

                }
                //update the scoreboard with a win tally
                p1w.Text = "Player 1 Wins: " + p1wins.ToString();
                p2w.Text = "Player 2 Wins: " + p2wins.ToString();
            }
            
        }

        //method to exit game and return to main menu
        private void TTTExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainMenu();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        //wallpapers for tictactoe game
        #region Wallpapers
        Image valley = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\valley.jpg");
        Image city = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\city.jpg");
        Image lake = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\lake.jpg");
        Image dirtRoad = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\dirtRoad.jpg");
        Image park = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\park.jpg");
        

        private void lakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = lake;
        }

        private void valleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = valley;
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = city;
        }

        private void dirtRoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = dirtRoad;
        }

        private void parkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = park;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }
        #endregion 
        
        //highlight effect when mouse enters button area of operation
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button mouseEnter = sender as Button;
            mouseEnter.BackColor = Color.SandyBrown;
        }
        //highlight effect when mouse leaves button area of operation
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button mouseLeave = sender as Button;
            mouseLeave.BackColor = Color.NavajoWhite;
        }

        //button press determines who's turn and which char to display, then changes turn
        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if(myTurn)
            {
                //if it's my turn, then X is displayed
                btn.Text = "X";
            }
            else
            {
                //if it's not my turn, O is displayed
                btn.Text = "O";
            }
            //disable the button to prevent changing the char
            btn.Enabled = false;
            gameLogic();
            //change the myTurn bool after game logic to prevent the wrong player winning
            myTurn = !myTurn;
            
        }

        //method to disable all buttons
        private void disableAllButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        //method to enable all buttons
        private void enableAllButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        //method to set up a new game
        private void newGame()
        {
            clearBoard();
            enableAllButtons();
            myTurn = true;
        }

        //clears the board from the previous game; creates a fresh board
        private void clearBoard()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        //method to start a new game from the menu strip
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}
