using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public static class Deck
    {
        public static Queue<Card> newDeck()
        {
            Queue<Card> theDeck = new Queue<Card>();
            for(int suit = 0; suit < 4; suit++)
            {
                for(int face = 1; face <14; face++)
                {
                    theDeck.Enqueue(new Card(face, suit));
                }
            }
            
           return shuffleDeck(theDeck);
        }

        private static Queue<Card> shuffleDeck(Queue<Card> theDeck)
        {
            List<Card> temp = theDeck.ToList();
            Random random = new Random(DateTime.Now.Millisecond);
            
            for(int i = temp.Count -1; i > 0; --i)
            {
                int j = random.Next(i + 1);

                Card tempCard = temp[i];
                temp[i] = temp[j];
                temp[j] = tempCard;
            }

            Queue<Card> shuffledDeck = new Queue<Card>();
            foreach (var card in temp)
            {
                shuffledDeck.Enqueue(card);
            }
      
            return shuffledDeck;
        }

    }
} 
