using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Dealer
    {
        public int handValue = 0;
        private List<Card> privHand = new List<Card>();
        Deck theDeck;


        public Dealer(Deck thedeck)
        {
            theDeck = thedeck;
        }

        public Card getOneDealerCard()
        {
            Card drawnCard = theDeck.drawCard();
            handValue = drawnCard.ValueOf;
            privHand.Add(drawnCard);
            return drawnCard;
        }

        public void resetDealer()
        {
            handValue = 0;
            privHand.Clear();
        }

        
    }
}
