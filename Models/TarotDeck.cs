using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarot.Models
{
    public class TarotDeck : Deck
    {        
        // Method returns a list of shuffled tarot cards with Name, Value, and Meaning properties
        public List<Card> AssignCardValues()
        {
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
                Cards.Add(card);
            }
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
                if (card.ImageFileName.ToUpper().Contains("CUPS")) card.Suit = "Cups";
                if (card.ImageFileName.ToUpper().Contains("WANDS")) card.Suit = "Wands";
                if (card.ImageFileName.ToUpper().Contains("DISKS")) card.Suit = "Disks";
                if (card.ImageFileName.ToUpper().Contains("SWORDS")) card.Suit = "Swords";
                Cards.Add(card);
            }
            // Shuffle the deck 10 times
            shuffle(10);
            return Cards;
        }
    }
}