using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/score")]
    public ActionResult WordScore()
    {
      Word newWord = new Word(Request.Form["wordInput"]);
      int wordScore = newWord.GetWordScore();
      string word = newWord.GetWord();
      Console.WriteLine(wordScore);

      return View(wordScore);
    }
  }
}
