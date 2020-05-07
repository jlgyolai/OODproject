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
        #region fields
        //fields
        int timeLeft = 0;
        PictureBox[] cardGrid = new PictureBox[24];
        Image unflipped = Properties.Resources.back;
        //first and second chosen cards
        PictureBox firstImage; 
        PictureBox secondImage;

        #endregion


        //wallpapers for memory game
        #region Wallpapers
        Image valley = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\valley.jpg");
        Image city = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\city.jpg");
        Image lake = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\lake.jpg");
        Image dirtRoad = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\dirtRoad.jpg");
        Image park = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\park.jpg");
        #endregion


        public MemoryCardGame()
        {
            InitializeComponent();

        }


        //method to clear the cards and show the unflipped image
        #region clearCards
        public void clearCards()
        {
            card1.Image = unflipped;
            card2.Image = unflipped;
            card3.Image = unflipped;
            card4.Image = unflipped;
            card5.Image = unflipped;
            card6.Image = unflipped;
            card7.Image = unflipped;
            card8.Image = unflipped;
            card9.Image = unflipped;
            card10.Image = unflipped;
            card11.Image = unflipped;
            card12.Image = unflipped;
            card13.Image = unflipped;
            card14.Image = unflipped;
            card15.Image = unflipped;
            card16.Image = unflipped;
            card17.Image = unflipped;
            card18.Image = unflipped;
            card19.Image = unflipped;
            card20.Image = unflipped;
            card21.Image = unflipped;
            card22.Image = unflipped;
            card23.Image = unflipped;
            card24.Image = unflipped;
        }
        #endregion

        //method to close the game
        #region closing
        private void MCGExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainMenu();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }
        #endregion

        //method to get card image
        public Image cardImage(int cardNo)
        {

            switch (cardNo)
            {
                case 2:
                    return Properties.Resources._2_of_clubs;
                case 3:
                    return Properties.Resources._3_of_clubs;
                case 4:
                    return Properties.Resources._4_of_clubs;
                case 5:
                    return Properties.Resources._5_of_clubs;
                case 6:
                    return Properties.Resources._6_of_clubs;
                case 7:
                    return Properties.Resources._7_of_clubs;
                case 8:
                    return Properties.Resources._8_of_clubs;
                case 9:
                    return Properties.Resources._9_of_clubs;
                case 10:
                    return Properties.Resources._10_of_clubs;
                case 11:
                    return Properties.Resources.jack_of_clubs;
                case 12:
                    return Properties.Resources.queen_of_clubs;
                case 13:
                    return Properties.Resources.king_of_clubs;
                default:
                    return unflipped;
            }       
        }

        //method for new game
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when clicking new game from the drop down menu
            //clear the cards/flip them over to only show back
            clearCards();
            var memorygametimer = new Timer();
            memorygametimer.Interval = 60;

            timeLeft = 60;
            Timer.Text = "Time: 60 seconds";
            timer1.Start();

            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Enabled = true;
            }

        }

        //timer method
        #region timerTick
        void timerTick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Timer.Text = "Time: " + timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                Timer.Text = "Time: 0 seconds";
                MessageBox.Show("Time is up! Game over!");
                for(int i = 0; i < 24; i++)
                {
                    cardGrid[i].Enabled = false;
                }

            }
        }
        #endregion

        //setting wallpaper methods
        #region wallpapers
        private void valleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = valley;
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

        #endregion

        private void MemoryCardGame_Load(object sender, EventArgs e)
        {
            //assign card pictureboxes to a control
            #region card assignment
            cardGrid[0] = card1;
            cardGrid[1] = card2;
            cardGrid[2] = card3;
            cardGrid[3] = card4;
            cardGrid[4] = card5;
            cardGrid[5] = card6;
            cardGrid[6] = card7;
            cardGrid[7] = card8;
            cardGrid[8] = card9;
            cardGrid[9] = card10;
            cardGrid[10] = card11;
            cardGrid[11] = card12;
            cardGrid[12] = card13;
            cardGrid[13] = card14;
            cardGrid[14] = card15;
            cardGrid[15] = card16;
            cardGrid[16] = card17;
            cardGrid[17] = card18;
            cardGrid[18] = card19;
            cardGrid[19] = card20;
            cardGrid[20] = card21;
            cardGrid[21] = card22;
            cardGrid[22] = card23;
            cardGrid[23] = card24;
            #endregion

            //make the picture boxes visible and set the default card theme
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImage();
            }
            var memorygametimer = new Timer();
            memorygametimer.Interval = 60;

            timeLeft = 60;
            Timer.Text = "60 seconds";
            timer1.Start();
        }

        //methods to change the deck themes
        #region Card Themes
        private void eyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImageEyes();
                unflipped = Card.getCardBackImageEyes();
            }
        }

        private void goldenFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           for(int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImageGoldenFlower();
                unflipped = Card.getCardBackImageGoldenFlower();
            }
        }

        private void owlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImageOwls();
                unflipped = Card.getCardBackImageOwls();
            }
        }

        private void snakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImageSnakes();
                unflipped = Card.getCardBackImageSnakes();
            }
        }

        private void redSnakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImageSnakesRed();
                unflipped = Card.getCardBackImageSnakesRed();
            }
        }

        private void blueDragonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImageDragonsBlue();
                unflipped = Card.getCardBackImageDragonsBlue();
            }
        }

        private void defaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                cardGrid[i].Visible = true;
                cardGrid[i].Image = Card.getCardBackImage();
                unflipped = Card.getCardBackImage();
            }
        }
        #endregion

        //methods to manage the click events for the game
        #region card click events
        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources._4_of_clubs;
            if(firstImage == null)
            {
                firstImage = card1;
            }
            else if(firstImage != null && secondImage == null)
            {
                secondImage = card1;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card1.Enabled = false;
                    card20.Enabled = false;
                }
                else
                    timer2.Start();
            } 
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources._7_of_clubs;
            if (firstImage == null)
            {
                firstImage = card2;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card2;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card2.Enabled = false;
                    card16.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }
        
        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.jack_of_clubs;
            if (firstImage == null)
            {
                firstImage = card3;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card3;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card3.Enabled = false;
                    card21.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }
        
        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.queen_of_clubs;
            if (firstImage == null)
            {
                firstImage = card4;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card4;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card23.Enabled = false;
                    card4.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources._2_of_clubs;
            if (firstImage == null)
            {
                firstImage = card5;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card5;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card5.Enabled = false;
                    card24.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources._6_of_clubs;
            if (firstImage == null)
            {
                firstImage = card6;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card6;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card12.Enabled = false;
                    card6.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources._3_of_clubs;
            if (firstImage == null)
            {
                firstImage = card7;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card7;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card7.Enabled = false;
                    card11.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources._5_of_clubs;
            if (firstImage == null)
            {
                firstImage = card8;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card8;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card8.Enabled = false;
                    card17.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card9_Click(object sender, EventArgs e)
        {
            card9.Image = Properties.Resources._9_of_clubs;
            if (firstImage == null)
            {
                firstImage = card9;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card9;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card9.Enabled = false;
                    card14.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card10_Click(object sender, EventArgs e)
        {
            card10.Image = Properties.Resources._10_of_clubs;
            if (firstImage == null)
            {
                firstImage = card10;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card10;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card18.Enabled = false;
                    card10.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card11_Click(object sender, EventArgs e)
        {
            card11.Image = Properties.Resources._3_of_clubs;
            if (firstImage == null)
            {
                firstImage = card11;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card11;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card11.Enabled = false;
                    card7.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card12_Click(object sender, EventArgs e)
        {
            card12.Image = Properties.Resources._6_of_clubs;
            if (firstImage == null)
            {
                firstImage = card12;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card12;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card6.Enabled = false;
                    card12.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card13_Click(object sender, EventArgs e)
        {
            card13.Image = Properties.Resources.king_of_clubs;
            if (firstImage == null)
            {
                firstImage = card13;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card13;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card13.Enabled = false;
                    card22.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card14_Click(object sender, EventArgs e)
        {
            card14.Image = Properties.Resources._9_of_clubs;
            if (firstImage == null)
            {
                firstImage = card14;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card14;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card9.Enabled = false;
                    card14.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card15_Click(object sender, EventArgs e)
        {
            card15.Image = Properties.Resources._8_of_clubs;
            if (firstImage == null)
            {
                firstImage = card15;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card15;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card15.Enabled = false;
                    card19.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card16_Click(object sender, EventArgs e)
        {
            card16.Image = Properties.Resources._7_of_clubs;
            if (firstImage == null)
            {
                firstImage = card16;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card16;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card2.Enabled = false;
                    card16.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card17_Click(object sender, EventArgs e)
        {
            card17.Image = Properties.Resources._5_of_clubs;
            if (firstImage == null)
            {
                firstImage = card17;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card17;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card17.Enabled = false;
                    card8.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card18_Click(object sender, EventArgs e)
        {
            card18.Image = Properties.Resources._10_of_clubs;
            if (firstImage == null)
            {
                firstImage = card18;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card18;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card10.Enabled = false;
                    card18.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card19_Click(object sender, EventArgs e)
        {
            card19.Image = Properties.Resources._8_of_clubs;
            if (firstImage == null)
            {
                firstImage = card19;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card19;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card19.Enabled = false;
                    card15.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card20_Click(object sender, EventArgs e)
        {
            card20.Image = Properties.Resources._4_of_clubs;
            if (firstImage == null)
            {
                firstImage = card20;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card20;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card1.Enabled = false;
                    card20.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card21_Click(object sender, EventArgs e)
        {
            card21.Image = Properties.Resources.jack_of_clubs;
            if (firstImage == null)
            {
                firstImage = card21;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card21;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card21.Enabled = false;
                    card3.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card22_Click(object sender, EventArgs e)
        {
            card22.Image = Properties.Resources.king_of_clubs;
            if (firstImage == null)
            {
                firstImage = card22;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card22;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card13.Enabled = false;
                    card22.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card23_Click(object sender, EventArgs e)
        {
            card23.Image = Properties.Resources.queen_of_clubs;
            if (firstImage == null)
            {
                firstImage = card23;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card23;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card23.Enabled = false;
                    card4.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }

        private void card24_Click(object sender, EventArgs e)
        {
            card24.Image = Properties.Resources._2_of_clubs;
            if (firstImage == null)
            {
                firstImage = card24;
            }
            else if (firstImage != null && secondImage == null)
            {
                secondImage = card24;
            }
            if (firstImage != null && secondImage != null)
            {
                if (firstImage.Tag == secondImage.Tag)
                {
                    firstImage = null;
                    secondImage = null;
                    card5.Enabled = false;
                    card24.Enabled = false;
                }
                else
                    timer2.Start();
            }
        }
        #endregion

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            firstImage.Image = unflipped;
            secondImage.Image = unflipped;
            firstImage = null;
            secondImage = null;
        }
    }
}
