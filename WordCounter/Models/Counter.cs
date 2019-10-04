using System;
using System.Collections.Generic;

namespace WordCounting.Models
{
  public class Counter
  {
    public string Sentence { get; set; }
    public string Word { get; set; }
    public int Count { get; set; }

    public Counter(string sentence, string word)
    {
      Sentence = sentence;
      Word = word;
      Count = 0;
    }

    public string[] SplitSentence()
    {
      string[] wordArray = Sentence.Split(' ');
      return wordArray;
    }

    public void CountWords(string[] wordArray)
    {
      for (int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == this.Word)
        {
          this.Count += 1;
        }
      }
    }
  }
}