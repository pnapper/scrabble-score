using System.Collections.Generic;
using System;

namespace ScrabbleScore.Models
{
  public class Word
  {
    private string _word;
    private int _score;
    // private static List<char> _letters = new List<char> {};
    // public Word(string word, int score = 0)
    public Word(string word, int score)
    {
      _word = word;
      _score = score;
    }

    public string GetWord()
    {
      return _word;
    }

    public int GetScore()
    {
      return _score;
    }

    public char[] GetLetters()
    {
      string Word = _word.ToLower();
      char[] letterList = Word.ToCharArray();
      return letterList;
    }

    public void SetWordScore(int newScore)
    {
      _score = newScore;
    }

    public static int ConvertLetterToValue(char letter)
    {
      int letterValue = 0;
      if (Char.IsLetter(letter) == true)
      {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'l' || letter == 'n' || letter == 'r' || letter == 's' || letter == 't')
        {
          letterValue = 1;
        }
        else if (letter == 'd' || letter == 'g' )
        {
          letterValue = 2;
        }
        else if (letter == 'b' || letter == 'c' || letter == 'm' || letter == 'p' )
        {
          letterValue = 3;
        }
        else if (letter == 'f' || letter == 'h' || letter == 'v' || letter == 'w' || letter == 'y')
        {
          letterValue = 4;
        }
        else if (letter == 'k')
        {
          letterValue = 5;
        }
        else if (letter == 'j' || letter == 'x')
        {
          letterValue = 8;
        }
        else if (letter == 'q' || letter == 'z')
        {
          letterValue = 10;
        }
      }
      return letterValue;
    }

    public int GetWordScore()
    {
      char[] letters = this.GetLetters();
      int wordScore = 0;
      for (var i=0; i< letters.Length; i++)
      {

        int letterScore = Word.ConvertLetterToValue(letters[i]);
        if (letterScore == 0)
        {
          i += letters.Length;
          wordScore = 0;
        }
        wordScore = wordScore + letterScore;
      }
      this.SetWordScore(wordScore);
      return wordScore;
    }

  }
}
