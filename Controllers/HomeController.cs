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
            TarotDeck tarotDeck = new TarotDeck();
            List<Card> deck = tarotDeck.AssignCardValues();
            return View(deck);
        }

    }
}