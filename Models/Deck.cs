using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarot.Models
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        public void shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}