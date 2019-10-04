using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class Counter
  {
    public Dictionary<string, int> WordDictionary = new Dictionary<string, int>{};
    public string Sentence { get; set; }
    public string Word { get; set; }

    public Counter(string sentence, string word)
    {
      Sentence = sentence;
      Word = word;
      WordDictionary;
    }

    public static string SplitSentence()
    {
      string[] wordArray = Counter.SplitSentence.Split();
    }

    public static SendToDictionary()
    {

    }
  }
}