using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.LernkartenApp060.Business.Model.BusinessObjects
{
    class Statistics
    {
        CardCollection cards;
        public Statistics(CardCollection cards)
        {
            this.cards = cards;
        }

        /* Returns the ammount of items in the collection. */
        public int Size()
        {
            return this.cards.Count;
        }
        /* Retruns the percentage of sucessfully solved cards of the collection. */
        public int GetSuccessRate(bool solvedTwice)
        {
            int successCounter = 0;

            if (solvedTwice)
            {
                foreach (Card card in cards)
                {
                    if (card.Solved >= 2) { successCounter++; }
                }
            } else
            {
                foreach (Card card in cards)
                {
                    if (card.Solved >= 1) { successCounter++; }
                }
            }


            return successCounter / this.Size() * 100;
        }
    }
}
