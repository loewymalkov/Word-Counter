using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class Counter
  {
    // public Dictionary<string, int> WordDictionary = new Dictionary<string, int>{};
    public string Sentence { get; set; }
    public string Word { get; set; }

    public Counter(string sentence, string word)
    {
      Sentence = sentence;
      Word = word;
      // WordDictionary;
    }

    // COUNT WORDS WITHOUT SPLITTING THE STRING INTO WORDS OR EVALUATE BASED ON CHARS
    // IF CHARACTER BEFORE AND AFTER MATCHING WORDS ARE SPACES, ADD TO COUNT, ELSE DON'T

    // public static string SplitSentence()
    // {
    //   string[] wordArray = Counter.SplitSentence.Split();
    //   // store the split sentence in an array of words
    // }

    public static CountWords()
    {
      // loop through the words in the array and evaluate if they match the chosen word, and make sure it doesn't contain a letter directly after
      // add 1 if the word matches, else move to next word
    }
  }
}