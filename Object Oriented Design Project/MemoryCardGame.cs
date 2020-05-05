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
        bool gameOn = false;
        int timeLeft = 0;
        List<Image> cardList = new List<Image>();
        Random random = new Random();
        //first and second chosen cards
        PictureBox firstImage; 
        PictureBox secondImage;

        #endregion

        //method to add cards to cards list
        #region addCards
        public void addCards()
        {
            Image jackCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_hearts.png"); 
            cardList.Add(jackCard);
            Image jackCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_hearts.png");
            cardList.Add(jackCard2);
            Image queenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\queen_of_clubs.png");
            cardList.Add(queenCard);
            Image queenCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\queen_of_clubs.png");
            cardList.Add(queenCard2);
            Image kingCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\king_of_clubs.png");
            cardList.Add(kingCard);
            Image kingCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\king_of_clubs.png");
            cardList.Add(kingCard2);
            Image twoCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\2_of_clubs.png");
            cardList.Add(twoCard);
            Image twoCard2= Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\2_of_clubs.png");
            cardList.Add(twoCard2);
            Image threeCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\3_of_clubs.png");
            cardList.Add(threeCard);
            Image threeCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\3_of_clubs.png");
            cardList.Add(threeCard2);
            Image fourCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\4_of_clubs.png");
            cardList.Add(fourCard);
            Image fourCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\4_of_clubs.png"); ;
            cardList.Add(fourCard2);
            Image fiveCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\5_of_clubs.png");
            cardList.Add(fiveCard);
            Image fiveCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\5_of_clubs.png");
            cardList.Add(fiveCard2);
            Image sixCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\6_of_clubs.png");
            cardList.Add(sixCard);
            Image sixCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\6_of_clubs.png");
            cardList.Add(sixCard2);
            Image sevenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\7_of_clubs.png");
            cardList.Add(sevenCard);
            Image sevenCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\7_of_clubs.png");
            cardList.Add(sevenCard2);
            Image eightCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\8_of_clubs.png");
            cardList.Add(eightCard);
            Image eightCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\8_of_clubs.png");
            cardList.Add(eightCard2);
            Image nineCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\9_of_clubs.png");
            cardList.Add(nineCard);
            Image nineCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\9_of_clubs.png");
            cardList.Add(nineCard2);
            Image tenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\10_of_clubs.png");
            cardList.Add(tenCard);
            Image tenCard2 = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\10_of_clubs.png");
            cardList.Add(tenCard2);
        }
        #endregion

        //wallpapers for memory game
        #region Wallpapers
        Image valley = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\valley.jpg");
        Image city = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\city.jpg");
        Image lake = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\lake.jpg");
        Image dirtRoad = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\dirtRoad.jpg");
        Image park = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\park.jpg");
        #endregion

        //cards for the memory game

        Image unflipped = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\back.png");

        #region edits for cards NOT USED
        /*
        Image jackCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
        Image queenCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\queen_of_clubs.png");
        Image kingCard = Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\king_of_clubs.png");
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
        */
        #endregion

        public MemoryCardGame()
        {
            InitializeComponent();
            addCards();
            //randomizeCards();
        }

        //method to clear the cards and show the unflipped image
        #region clearCards
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
            string Name_0 = @"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\";
            string Name_1 = cardNo.ToString();
            string Name_2 = "_of_clubs.png";
            string filename = string.Concat(Name_0, Name_1, Name_2);

            if (cardNo == 11)
            {
                return Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\jack_of_clubs.png");
            }
            else if (cardNo == 12)
            {
                return Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\queen_of_clubs.png");
            }
            else if (cardNo == 13)
            {
                return Image.FromFile(@"C:\Users\Justin Gyolai\source\repos\OODproject\Object Oriented Design Project\Images\king_of_clubs.png");
            }
            else
                return Image.FromFile(filename);
                   
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

        //randomize cards and place them onto the board
        #region randomizeCards
        private void randomizeCards()
        {
            PictureBox newCard;
            int randomNo;
            

            for(int i = 0; i < 23; i++)
            {
                if(tableLayoutPanel1.Controls[i] is PictureBox)
                {
                    newCard = (PictureBox)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }
                randomNo = random.Next(0, 23);

                newCard.BackgroundImage = cardList[randomNo];

                cardList.RemoveAt(randomNo);
            }
        }
        #endregion

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
                gameOn = false;

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

        }

        private void imageClick(object sender, EventArgs e)
        {

        }
    }
}
