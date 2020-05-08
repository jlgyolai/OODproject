using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Design_Project
{
    public static class functional
    {
        //needed to create a way to combine a player's hand into a queue, instead of one card at a time through Queue's enqueue();
        public static void Combine(this Queue<Card> deck, Queue<Card> cardsToInsert)
        {
            foreach(var card in cardsToInsert)
            {
                deck.Enqueue(card);
            }
        }
    }
}
