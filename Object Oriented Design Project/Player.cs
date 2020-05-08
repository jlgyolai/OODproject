using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public class Player
    {
        public string name 
        { 
            get; 
            set; 
        }
        public Queue<Card> playerHand 
        {
            get; 
            set;
        }

        public Player()
        {

        }

        public Player(string playerName)
        {
            name = playerName;
        }

        public Queue<Card> dealCards(Queue<Card> cards)
        {
            Queue<Card> thePlayerCards = new Queue<Card>();
            Queue<Card> theDealerCards = new Queue<Card>();

            int counter = 2;
            while(cards.Any())
            {
                if(counter%2 == 0)
                {
                    thePlayerCards.Enqueue(cards.Dequeue());
                }
                else
                {
                    theDealerCards.Enqueue(cards.Dequeue());
                }
                counter++;
            }
            playerHand = theDealerCards;
            return thePlayerCards;
        }
    }
}
