using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.TestTools
{

  [TestClass]
  public class ScoreTest
  {
    [TestMethod]
    public void GetLetters_ReturnLetters_char()
    {

      //Arrange
      Word newWord = new Word("test");
      char[] lettersArray = newWord.GetLetters();

      //Act
      //Assert
      Console.WriteLine(lettersArray[0]);
    }
    [TestMethod]
    public void ConvertLetterToValue_ReturnValueOfLetter_2()
    {
      //Arrange
      Word newWord = new Word("$fred");
      char[] lettersArray = newWord.GetLetters();
      char firstLetter = lettersArray[0];
      Console.WriteLine(firstLetter);
      //Act
      int firstLetterValue = newWord.ConvertLetterToValue(firstLetter);
      //Assert
      Console.WriteLine(firstLetterValue);

    }
  }
}
