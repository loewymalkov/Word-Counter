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

    // public static CountWords(string[] wordArray)
    // {
    //   for (int i = 0; i <= wordArray.Length; i++)
    //   {
    //     if (wordArray[i] == Counter.Word)
    //     {
    //       // add to a count
    //       Counter.Count += 1;
    //     }
    //   }
    //   // loop through the words in the array and evaluate if they match the chosen word, and make sure it doesn't contain a letter directly after
    //   // add 1 if the word matches, else move to next word
    // }
  }
}