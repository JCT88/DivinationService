using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarot.Models
{
    public class Card
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public string Meaning { get; set; }
        public string ImageFileName { get; set; }
        public string Arcana { get; set; }
        public string Element { get; set; } // implement
        public string Suit { get; set; } // implement
    }
}