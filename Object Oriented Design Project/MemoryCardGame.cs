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
    public partial class MemoryCardGame : Form
    {
        bool gameOn = false;
        int timeLeft = 0;

       //wallpapers for memory game

        Image valley = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\valley.jpg");
        Image city = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\city.jpg");
        Image lake = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\lake.jpg");
        Image dirtRoad = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\dirtRoad.jpg");
        Image park = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\park.jpg");

        //cards for the memory game

        Image unflipped = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\back.png");

        Image jackCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image queenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image kingCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image twoCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\2_of_clubs.png");
        Image threeCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\3_of_clubs.png");
        Image fourCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\4_of_clubs.png");
        Image fiveCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\5_of_clubs.png");
        Image sixCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\6_of_clubs.png");
        Image sevenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\7_of_clubs.png");
        Image eightCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\8_of_clubs.png");
        Image nineCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\9_of_clubs.png");
        Image tenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\10_of_clubs.png");

        Image jackCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image queenCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image kingCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image twoCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\2_of_clubs.png");
        Image threeCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\3_of_clubs.png");
        Image fourCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\4_of_clubs.png");
        Image fiveCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\5_of_clubs.png");
        Image sixCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\6_of_clubs.png");
        Image sevenCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\7_of_clubs.png");
        Image eightCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\8_of_clubs.png");
        Image nineCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\9_of_clubs.png");
        Image tenCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\10_of_clubs.png");



        public MemoryCardGame()
        {
            InitializeComponent();
        }

        public void clearCards()
        {
            card1.BackgroundImage = unflipped;
            card2.BackgroundImage = unflipped;
            card3.BackgroundImage = unflipped;
            card4.BackgroundImage = unflipped;
            card5.BackgroundImage = unflipped;
            card6.BackgroundImage = unflipped;
            card7.BackgroundImage = unflipped;
            card8.BackgroundImage = unflipped;
            card9.BackgroundImage = unflipped;
            card10.BackgroundImage = unflipped;
            card11.BackgroundImage = unflipped;
            card12.BackgroundImage = unflipped;
            card13.BackgroundImage = unflipped;
            card14.BackgroundImage = unflipped;
            card15.BackgroundImage = unflipped;
            card16.BackgroundImage = unflipped;
            card17.BackgroundImage = unflipped;
            card18.BackgroundImage = unflipped;
            card19.BackgroundImage = unflipped;
            card20.BackgroundImage = unflipped;
            card21.BackgroundImage = unflipped;
            card22.BackgroundImage = unflipped;
            card23.BackgroundImage = unflipped;
            card24.BackgroundImage = unflipped;
        }
        private void MCGExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainMenu();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        private void valleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = valley;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when clicking new game from the drop down menu
            //clear the cards/flip them over to only show back
            clearCards();
            //randomize cards

            //set up the timer

            var memorygametimer = new Timer();
            memorygametimer.Interval = 60;

            timeLeft = 60;
            Timer.Text = "60 seconds";
            timer1.Start();

            //set the game to ready
            gameOn = true;
            //start the game
            playGame();
        }

        private void playGame()
        {
            //game code

            if(gameOn==false)
            {
                MessageBox.Show("Please start a new game from the menu.");
            }
            else
            {
                //
            }
        }

        void timerTick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Timer.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                Timer.Text = "0";
                gameOn = false;

            }
        }

        private void dirtRoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = dirtRoad;
        }

        private void cityscapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = city;
        }

        private void lakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = lake;
        }

        private void parkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = park;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        private void MemoryCardGame_Load(object sender, EventArgs e)
        {

        }
    }
}
