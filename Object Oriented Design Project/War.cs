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
        private Player theDealer;
        private Player thePlayer;
        int playerCardCount = 0;
        Image unflipped = Properties.Resources.back;
        Queue<Card> playerQcards = new Queue<Card>();
        Queue<Card> dealerQcards = new Queue<Card>();
        PictureBox[] playerCards = new PictureBox[5];
        PictureBox[] dealerCards = new PictureBox[5];


        public War()
        {
            InitializeComponent();
        }

        private void War_Load(object sender, EventArgs e)
        {
            theDealer = new Player("CPU");
            thePlayer = new Player("You");

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

            btnBattle.Enabled = true;
            WarExit.Enabled = true;

            Queue<Card> theDeck = Deck.newDeck();
            Queue<Card> playerDeck = theDealer.dealCards(theDeck);
            thePlayer.playerHand = playerDeck;
            playerCardCount = 26;
            CardsInHand.Text = "Cards in Hand: " + playerCardCount.ToString();

        }

        //method for new game in menu strip
        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            //when new game is selected from the menu
            btnBattle.Enabled = true;
            //shuffle the deck
            Queue<Card> theDeck = Deck.newDeck();
            Queue<Card> playerDeck = theDealer.dealCards(theDeck);
            thePlayer.playerHand = playerDeck;
            playerCardCount = 26;
            CardsInHand.Text = "Cards in Hand: " + playerCardCount.ToString();
        }


        //method for battle button click
        private void battleClick(object sender, EventArgs e)
        {
            //used to hide the picture boxes after a skirmish
            playerCards[1].Visible = false;
            playerCards[2].Visible = false;
            playerCards[3].Visible = false;
            playerCards[4].Visible = false;

            dealerCards[1].Visible = false;
            dealerCards[2].Visible = false;
            dealerCards[3].Visible = false;
            dealerCards[4].Visible = false;

            Queue<Card> battle = new Queue<Card>();
            if (thePlayer.playerHand.Count > 0)
            {
                var playercard = thePlayer.playerHand.Dequeue();
                playerCardCount--;
                CardsInHand.Text = "Cards in Hand: " + playerCardCount.ToString();

                var dealercard = theDealer.playerHand.Dequeue();

                playerCard.Image = playercard.cardFront();
                dealerCard.Image = dealercard.cardFront();

                battle.Enqueue(playercard);
                battle.Enqueue(dealercard);

                while (playercard.Face == dealercard.Face)
                {
                    if (thePlayer.playerHand.Count < 4)
                    {
                        thePlayer.playerHand.Clear();
                        return;
                    }
                    if (theDealer.playerHand.Count < 4)
                    {
                        theDealer.playerHand.Clear();
                        return;
                    }

                    battle.Enqueue(thePlayer.playerHand.Dequeue());
                    playerCards[1].Visible = true;
                    playerCards[1].Image = unflipped;
                    playerCards[1].SendToBack();

                    battle.Enqueue(thePlayer.playerHand.Dequeue());
                    playerCards[2].Visible = true;
                    playerCards[2].Image = unflipped;

                    battle.Enqueue(thePlayer.playerHand.Dequeue());
                    playerCards[3].Visible = true;
                    playerCards[3].Image = unflipped;

                    playerCardCount = playerCardCount - 3;
                    CardsInHand.Text = "Cards in Hand: " + playerCardCount.ToString();

                    battle.Enqueue(theDealer.playerHand.Dequeue());
                    dealerCards[1].Visible = true;
                    dealerCards[1].Image = unflipped;
                    dealerCards[1].SendToBack();

                    battle.Enqueue(theDealer.playerHand.Dequeue());
                    dealerCards[2].Visible = true;
                    dealerCards[2].Image = unflipped;

                    battle.Enqueue(theDealer.playerHand.Dequeue());
                    dealerCards[3].Visible = true;
                    dealerCards[3].Image = unflipped;

                    playercard = thePlayer.playerHand.Dequeue();
                    playerCards[4].Visible = true;
                    pWarBattle.Image = playercard.cardFront();
                    pWarBattle.BringToFront();
                    playerCardCount--;
                    CardsInHand.Text = "Cards in Hand: " + playerCardCount.ToString();

                    dealercard = theDealer.playerHand.Dequeue();
                    dealerCards[4].Visible = true;
                    dWarBattle.Image = dealercard.cardFront();
                    dWarBattle.BringToFront();
                    

                    battle.Enqueue(playercard);
                    battle.Enqueue(dealercard);
                }
                if (playercard.Face < dealercard.Face)
                {
                    theDealer.playerHand.Combine(battle);

                }
                else
                {
                    playerCardCount += battle.Count;
                    thePlayer.playerHand.Combine(battle);
                }

            }
            else
            {
                MessageBox.Show("Game Over. Player ran out of Cards.");
                btnBattle.Enabled = false;
            }



        }
  

        #region event handlers
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
            //playerCards[0].Image = Card.getCardBackImageEyes();
            playerCards[1].Image = Card.getCardBackImageEyes();
            playerCards[2].Image = Card.getCardBackImageEyes();
            playerCards[3].Image = Card.getCardBackImageEyes();
            //playerCards[4].Image = Card.getCardBackImageEyes();

            //dealerCards[0].Image = Card.getCardBackImageEyes();
            dealerCards[1].Image = Card.getCardBackImageEyes();
            dealerCards[2].Image = Card.getCardBackImageEyes();
            dealerCards[3].Image = Card.getCardBackImageEyes();
            //dealerCards[4].Image = Card.getCardBackImageEyes();

            unflipped = Properties.Resources.eyes;
        }

        private void goldenFlowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // playerCards[0].Image = Card.getCardBackImageGoldenFlower();
            playerCards[1].Image = Card.getCardBackImageGoldenFlower();
            playerCards[2].Image = Card.getCardBackImageGoldenFlower();
            playerCards[3].Image = Card.getCardBackImageGoldenFlower();
            //playerCards[4].Image = Card.getCardBackImageGoldenFlower();

            //dealerCards[0].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[1].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[2].Image = Card.getCardBackImageGoldenFlower();
            dealerCards[3].Image = Card.getCardBackImageGoldenFlower();
            //dealerCards[4].Image = Card.getCardBackImageGoldenFlower();

            unflipped = Properties.Resources.goldenFlower;
        }

        private void owlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // playerCards[0].Image = Card.getCardBackImageOwls();
            playerCards[1].Image = Card.getCardBackImageOwls();
            playerCards[2].Image = Card.getCardBackImageOwls();
            playerCards[3].Image = Card.getCardBackImageOwls();
            //playerCards[4].Image = Card.getCardBackImageOwls();

           //dealerCards[0].Image = Card.getCardBackImageOwls();
            dealerCards[1].Image = Card.getCardBackImageOwls();
            dealerCards[2].Image = Card.getCardBackImageOwls();
            dealerCards[3].Image = Card.getCardBackImageOwls();
            //dealerCards[4].Image = Card.getCardBackImageOwls();

            unflipped = Properties.Resources.owls;
        }

        private void snakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //playerCards[0].Image = Card.getCardBackImageSnakes();
            playerCards[1].Image = Card.getCardBackImageSnakes();
            playerCards[2].Image = Card.getCardBackImageSnakes();
            playerCards[3].Image = Card.getCardBackImageSnakes();
           // playerCards[4].Image = Card.getCardBackImageSnakes();

            //dealerCards[0].Image = Card.getCardBackImageSnakes();
            dealerCards[1].Image = Card.getCardBackImageSnakes();
            dealerCards[2].Image = Card.getCardBackImageSnakes();
            dealerCards[3].Image = Card.getCardBackImageSnakes();
            //dealerCards[4].Image = Card.getCardBackImageSnakes();

            unflipped = Properties.Resources.snakes;
        }

        private void redSnakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // playerCards[0].Image = Card.getCardBackImageSnakesRed();
            playerCards[1].Image = Card.getCardBackImageSnakesRed();
            playerCards[2].Image = Card.getCardBackImageSnakesRed();
            playerCards[3].Image = Card.getCardBackImageSnakesRed();
           // playerCards[4].Image = Card.getCardBackImageSnakesRed();

            //dealerCards[0].Image = Card.getCardBackImageSnakesRed();
            dealerCards[1].Image = Card.getCardBackImageSnakesRed();
            dealerCards[2].Image = Card.getCardBackImageSnakesRed();
            dealerCards[3].Image = Card.getCardBackImageSnakesRed();
          //  dealerCards[4].Image = Card.getCardBackImageSnakesRed();

            unflipped = Properties.Resources.snakesRed;
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

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //playerCards[0].Image = Card.getCardBackImage();
            playerCards[1].Image = Card.getCardBackImage();
            playerCards[2].Image = Card.getCardBackImage();
            playerCards[3].Image = Card.getCardBackImage();
           // playerCards[4].Image = Card.getCardBackImage();

            //dealerCards[0].Image = Card.getCardBackImage();
            dealerCards[1].Image = Card.getCardBackImage();
            dealerCards[2].Image = Card.getCardBackImage();
            dealerCards[3].Image = Card.getCardBackImage();
           // dealerCards[4].Image = Card.getCardBackImage();

            unflipped = Properties.Resources.back;
        }
    }
    #endregion
}
