using System;
using System.Collections.Generic;
using WordCounting.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("---------------------------------------------------\nWelcome to the WordCounter Console App. Please enter a sentence followed by a word you wish to count. Do not include punctuation.");

      Loop();      
    }

    public static void Loop()
    {
      Console.WriteLine("sentence:");
      string sentence = Console.ReadLine();
      Console.WriteLine("word");
      string word = Console.ReadLine();

      Counter newWordCounter = new Counter(sentence, word);
      string[] sentenceArray = newWordCounter.SplitSentence();
      newWordCounter.CountWords(sentenceArray);

      Console.WriteLine("Phrase contains " + newWordCounter.Count + " occurence(s) of the word '" + word + "'\n \nWould you like to try again with a new sentence? (yes/exit)");
      string runAgain = Console.ReadLine();
      if (runAgain.ToLower() == "yes")
      {
        Console.Clear();
        Loop();
      }
    }
  }
}