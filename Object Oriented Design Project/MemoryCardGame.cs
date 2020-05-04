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
       
        Image valley = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\valley.jpg");
        Image city = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\city.jpg");
        Image lake = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\lake.jpg");
        Image dirtRoad = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\dirtRoad.jpg");
        Image park = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\park.jpg");
        Image unflipped = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\back.png");
        Image oneCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\ace_of_clubs.png");
        Image twoCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\2_of_clubs.png");
        Image threeCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\3_of_clubs.png");
        Image fourCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\4_of_clubs.png");
        Image fiveCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\5_of_clubs.png");
        Image sixCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\6_of_clubs.png");
        Image sevenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\7_of_clubs.png");
        Image eightCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\8_of_clubs.png");
        Image nineCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\9_of_clubs.png");
        Image tenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\10_of_clubs.png");



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
            clearCards();
            var timer = new Timer();
            timer.Interval = 60;
            timer.Start();
            Timer.Text = timer.ToString();
        }

        void timerTick(object sender, EventArgs e)
        {

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
    }
}
