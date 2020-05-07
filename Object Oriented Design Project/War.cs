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
    public partial class War : Form
    {
        //fields for the war game
        static Deck theDeck = new Deck();
        Dealer theDealer = new Dealer(theDeck);
        Player thePlayer = new Player(theDeck);
        int playerCardCount = 0;
        int playerCardVisible = 0;
        int dealerCardVisible = 0;
        PictureBox[] playerCards = new PictureBox[5];
        PictureBox[] dealerCards = new PictureBox[5];
        bool isGameOver = false;

        public War()
        {
            InitializeComponent();
        }

        //method for closing the app and returning to main menu
        private void WarExit_Click(object sender, EventArgs e)
        {
            //Close this form when done with it
            this.Hide();
            var newForm = new MainMenu();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

        //method for button highlight
        private void WarExit_MouseEnter(object sender, EventArgs e)
        {
            WarExit.BackColor = Color.Olive;
        }

        private void WarExit_MouseLeave(object sender, EventArgs e)
        {
            WarExit.BackColor = Color.OliveDrab;
        }

        private void War_Load(object sender, EventArgs e)
        {

            //array for the visible cards
            playerCards[0] = playerCard;
            playerCards[1] = pWar1;
            playerCards[2] = pWar2;
            playerCards[3] = pWar3;
            playerCards[4] = pWarBattle;

            dealerCards[0] = dealerCard;
            dealerCards[1] = dWar1;
            dealerCards[2] = dWar2;
            dealerCards[3] = dWar3;
            dealerCards[4] = dWarBattle;

            playerCards[0].Visible = true;
            playerCards[0].Image = Card.getCardBackImage();
            dealerCards[0].Visible = true;
            dealerCards[0].Image = Card.getCardBackImage();
            /*
            for(int counter = 0; counter <5, counter++)
            {
                playerCards[counter].Visible();
            }
            */
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //when new game is selected from the menu

            //shuffle the deck
            theDeck.shuffleDeck();
            //enable buttons
            btnBattle.Enabled = true;
            WarExit.Enabled = true;
            //reset the dealer and player
            theDealer.resetDealer();
            thePlayer.resetPlayer();

            //split the deck and distribute to player and dealer
            for (int counter = 0; counter < 2; counter++)
            {
                playerCards[counter].Visible = true;
                playerCards[counter].Image = Card.getCardBackImage();
                dealerCards[counter].Visible = true;
                dealerCards[counter].Image = Card.getCardBackImage();
            }
            for (int counter = 2; counter < 5; counter++)
            {
                playerCards[counter].Visible = false;
                playerCards[counter].Image = Card.getCardBackImage();
                dealerCards[counter].Visible = false;
                dealerCards[counter].Image = Card.getCardBackImage();
            }
        }



        private void battleClick(object sender, EventArgs e)
        {
            CardsInHand.Text = string.Format("{0}", playerCardCount.ToString());
            if (playerCardVisible < 5)
            {
                //draw from player's hand and flip card over

                playerCards[playerCardVisible].Image = thePlayer.playerDraw().cardFront();
                playerCards[playerCardVisible].Visible = true;

                //draw from dealer's hand and flip over
                dealerCards[dealerCardVisible].Image = theDealer.getOneDealerCard().cardFront();
                //compare face value

                //if dealer card == player card: stalemate. Start skirmish

                //if needed: 
                //draw four cards from player hand, flip over last

                //if needed:
                //draw four cards from dealer hand, flip over last

                //compare face value of each fourth card

                //highest card face value wins the skirmish.

                //update player's card count

                //if player's card count = 52, player wins
                //if player's card count = 0, player loses
                //if player's card count is 0 > x > 52, can continue play
                if (playerCardCount == 52)
                {
                    MessageBox.Show("Player wins!");
                    CardsInHand.Text = playerCardCount.ToString();
                    isGameOver = true;
                }
                else if (playerCardCount == 0)
                {
                    MessageBox.Show("Dealer wins!");
                    CardsInHand.Text = playerCardCount.ToString();
                    isGameOver = true;
                }
                else
                {
                    CardsInHand.Text = playerCardCount.ToString();
                }
            }
        }

        //methods for highlighting buttons
        private void btnBattle_MouseEnter(object sender, EventArgs e)
        {
            btnBattle.BackColor = Color.Olive;
        }

        private void btnBattle_MouseLeave(object sender, EventArgs e)
        {
            btnBattle.BackColor = Color.OliveDrab;
        }

        //methods to change deck theme
        private void eyesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerCards[0].Image = Card.getCardBackImageEyes();
            playerCards[1].Image = Card.getCardBackImageEyes();
            playerCards[2].Image = Card.getCardBackImageEyes();
            playerCards[3].Image = Card.getCardBackImageEyes();
            playerCards[4].Image = Card.getCardBackImageEyes();

            dealerCards[0].Image = Card.getCardBackImageEyes();
            dealerCards[1].Image = Card.getCardBackImageEyes();
            dealerCards[2].Image = Card.getCardBackImageEyes();
            dealerCards[3].Image = Card.getCardBackImageEyes();
            dealerCards[4].Image = Card.getCardBackImageEyes();
        }

        private void goldenFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerCards[0].Image = Card.getCardBackImageGoldenFlower();
            playerCards[1].Image = Card.getCardBackImageGoldenFlower();
            playerCards[2].Image = Card.getCardBackImageGoldenFlower();
            playerCards[3].Image = Card.getCardBackImageGoldenFlower();
            playerCards[4].Image = Card.getCardBackImageGoldenFlower();

            dealerCards[0].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[1].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[2].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[3].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[4].Image = Card.getCardBackImageGoldenFlower();
        }

        private void owlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerCards[0].Image = Card.getCardBackImageOwls();
            playerCards[1].Image = Card.getCardBackImageOwls();
            playerCards[2].Image = Card.getCardBackImageOwls();
            playerCards[3].Image = Card.getCardBackImageOwls();
            playerCards[4].Image = Card.getCardBackImageOwls();

            dealerCards[0].Image = Card.getCardBackImageOwls();
            dealerCards[1].Image = Card.getCardBackImageOwls();
            dealerCards[2].Image = Card.getCardBackImageOwls();
            dealerCards[3].Image = Card.getCardBackImageOwls();
            dealerCards[4].Image = Card.getCardBackImageOwls();
        }

        private void snakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerCards[0].Image = Card.getCardBackImageSnakes();
            playerCards[1].Image = Card.getCardBackImageSnakes();
            playerCards[2].Image = Card.getCardBackImageSnakes();
            playerCards[3].Image = Card.getCardBackImageSnakes();
            playerCards[4].Image = Card.getCardBackImageSnakes();

            dealerCards[0].Image = Card.getCardBackImageSnakes();
            dealerCards[1].Image = Card.getCardBackImageSnakes();
            dealerCards[2].Image = Card.getCardBackImageSnakes();
            dealerCards[3].Image = Card.getCardBackImageSnakes();
            dealerCards[4].Image = Card.getCardBackImageSnakes();
        }

        private void redSnakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerCards[0].Image = Card.getCardBackImageSnakesRed();
            playerCards[1].Image = Card.getCardBackImageSnakesRed();
            playerCards[2].Image = Card.getCardBackImageSnakesRed();
            playerCards[3].Image = Card.getCardBackImageSnakesRed();
            playerCards[4].Image = Card.getCardBackImageSnakesRed();

            dealerCards[0].Image = Card.getCardBackImageSnakesRed();
            dealerCards[1].Image = Card.getCardBackImageSnakesRed();
            dealerCards[2].Image = Card.getCardBackImageSnakesRed();
            dealerCards[3].Image = Card.getCardBackImageSnakesRed();
            dealerCards[4].Image = Card.getCardBackImageSnakesRed();
        }

        //method for information click on menu strip
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pop up message box displaying credits
            MessageBox.Show(
                "This game was created by Justin Gyolai \n" +
                "for the Object Oriented Design Course \n" +
                "at Dakota State University Spring 2020.");
        }
    }
}
