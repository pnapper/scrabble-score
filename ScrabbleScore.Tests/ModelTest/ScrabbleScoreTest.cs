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
    public void GetWord_ReturnString_word()
    {
      //Arrange
      Word newWord = new Word("friend");
      //Act
      string word = newWord.GetWord();
      //Assert
      Console.WriteLine(word);
    }
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
      int firstLetterValue = Word.ConvertLetterToValue(firstLetter);
      //Assert
      Console.WriteLine(firstLetterValue);
    }
    [TestMethod]
    public void GetWordScore_ReturnScore_4letters()
    {
      //Arrange
      Word newWord = new Word("farm");
      //Act
      int wordScore = newWord.GetWordScore();
      //Assert
      Console.WriteLine(wordScore);
    }

    [TestMethod]
    public void GetWordScore_ReturnError_NonLetter()
    {
      //Arrange
      Word newWord = new Word("farm$");
      //Act
      int wordScore = newWord.GetWordScore();
      //Assert
      Console.WriteLine(wordScore);
    }

  }
}
