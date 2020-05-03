using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Player
    {
        public int hardHandValue = 0;
        public int softHandValue = 0;
        private List<Card> privHand = new List<Card>();
        Deck theDeck;
        
        public Player(Deck thedeck)
        {
            theDeck = thedeck;

        }

        public Card playerDraw()
        {
            Card drawnCard = theDeck.drawCard();
            //this.addCardValue(drawnCard);
            return drawnCard;
        }
        public void resetPlayer()
        {
            hardHandValue = 0;
            softHandValue = 0;
            privHand.Clear();
        }

        public Card getPlayerHand()
        {
            return privHand.Last();
        }


    }
}
