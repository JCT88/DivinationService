using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarot.Models;

namespace Tarot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Assign cards values, shuffle 10x, and store in a list
            List<Card> assignedCards = AssignCardValues(shuffleTimes: 10);
            // Pass the card list to the Home Index view
            return View(assignedCards);
        }

        // Method returns a list of shuffled tarot cards with Name, Value, and Meaning properties
        public List<Card> AssignCardValues(int shuffleTimes)
        {
            Deck deck = new Deck();
            // Access dictionary data
            Dictionary<MajorArcana, int> majorValues = ThothTarotValues.MajorArcanaNumericalValues;
            Dictionary<MajorArcana, string> majorMeaning = ThothTarotValues.MajorArcanaMeaning;
            Dictionary<MajorArcana, string> majorString = ThothTarotValues.MajorArcanaStringValues;
            Dictionary<MajorArcana, string> majorIMGFileNames = ThothTarotValues.MajorArcanaIMGFileNames;
            // Loop through the Major Arcana and add to the deck
            for (int i = 0; i < 21; i++)
            {
                Card card = new Card();
                // Access MajorArcana enum and convert the name to a string
                card.Name = majorString[(MajorArcana)i];
                // Accessing a dictionary and using an enum as a key
                card.Value = majorValues[(MajorArcana)i];
                card.Meaning = majorMeaning[(MajorArcana)i];
                card.ImageFileName = majorIMGFileNames[(MajorArcana)i];
                card.Arcana = "Major";
                card.Suit = "Trump";
                deck.Cards.Add(card);
            }
            // Access dictionary data
            Dictionary<MinorArcana, int> minorValues = ThothTarotValues.MinorArcanaNumerical;
            Dictionary<MinorArcana, string> minorMeaning = ThothTarotValues.MinorArcanaMeanings;
            Dictionary<MinorArcana, string> minorString = ThothTarotValues.MinorArcanaStringValues;
            Dictionary<MinorArcana, string> minorIMGFileNames = ThothTarotValues.MinorArcanaIMGFileNames;
            // Loop through the Minor Arcana
            for (int i = 1; i < 57; i++)
            {
                Card card = new Card();
                // Access MajorArcana enum and convert the name to a string
                card.Name = minorString[(MinorArcana)i];
                // Accessing a dictionary and using an enum as a key
                card.Value = minorValues[(MinorArcana)i];
                card.Meaning = minorMeaning[(MinorArcana)i];
                card.ImageFileName = minorIMGFileNames[(MinorArcana)i];
                card.Arcana = "Minor";
                // Check the suit according to the file name and assign a suit and element to each minor arcana
                if (card.ImageFileName.ToUpper().Contains("CUPS")) card.Suit = "Cups"; card.Element = "Water";
                if (card.ImageFileName.ToUpper().Contains("WANDS")) card.Suit = "Wands"; card.Element = "Fire";
                if (card.ImageFileName.ToUpper().Contains("DISKS")) card.Suit = "Disks"; card.Element = "Earth";
                if (card.ImageFileName.ToUpper().Contains("SWORDS")) card.Suit = "Swords"; card.Element = "Air";
                deck.Cards.Add(card);
            }
            // This method takes in an int which shuffles the cards in deck.Cards that amount of times
            void shuffle(int times = 1)
            {
                for (int i = 0; i < times; i++)
                {
                    List<Card> TempList = new List<Card>();
                    Random random = new Random();
                    while (deck.Cards.Count > 0)
                    {
                        int randomIndex = random.Next(0, deck.Cards.Count);
                        TempList.Add(deck.Cards[randomIndex]);
                        deck.Cards.RemoveAt(randomIndex);
                    }
                    deck.Cards = TempList;
                }
            }
            // Shuffle the deck 10x and return the list
            shuffle(shuffleTimes);
            return deck.Cards;
        }
    }
}