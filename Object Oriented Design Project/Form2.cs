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
        int playerCardVisible = 0;
        int dealerCardVisible = 0;
        PictureBox[] playerCards = new PictureBox[5];
        PictureBox[] dealerCards = new PictureBox[5];
        bool isGameOver = false;

        public War()
        {
            InitializeComponent();
        }

        private void WarExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainMenu();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }

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
            playerCards[0] = playerCard1;
            playerCards[1] = playerCard2;
            playerCards[2] = playerCard3;
            playerCards[3] = playerCard4;
            playerCards[4] = playerCard5;
            dealerCards[0] = dealerCard1;
            dealerCards[1] = dealerCard2;
            dealerCards[2] = dealerCard3;
            dealerCards[3] = dealerCard4;
            dealerCards[4] = dealerCard5;


        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //when new game is selected from the menu

            theDeck.shuffleDeck();
            btnBattle.Enabled = true;
            WarExit.Enabled = true;
            theDealer.resetDealer();
            thePlayer.resetPlayer();

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

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This game was created by Justin Gyolai \n" +
                "for the Object Oriented Design Course \n" +
                "at Dakota State University Spring 2020.");
        }
    }
}
