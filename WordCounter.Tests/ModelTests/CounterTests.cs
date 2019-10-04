using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounting.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {

    [TestMethod]
    public void Counter_CreateCounter_newCountHasSentence()
    {
      Counter newCount = new Counter("for the people by the people", "people");
      string sentence = newCount.Sentence;
      Assert.AreEqual(sentence, "for the people by the people");
    }

    [TestMethod]
    public void Counter_CreateCounter_newCountHasWord()
    {
      Counter newCount = new Counter("for the people by the people", "people");
      string word = newCount.Word;
      Assert.AreEqual(word, "people");
    }

    [TestMethod]
    public void Counter_CreateCounter_SplitSentence()
    {
      Counter newCount = new Counter("for the people by the people", "people");
      string[] resultArray = newCount.SplitSentence();
      string[] testArray = {"for", "the", "people", "by", "the", "people"};
      Assert.AreEqual(resultArray.ToString(), testArray.ToString());
    }

    [TestMethod]
    public void Counter_CountWords_OccurencesOfWord()
    {
      Counter newCount = new Counter("for the people by the people", "people");
      string[] resultArray = newCount.SplitSentence();
      newCount.CountWords(resultArray);
      Assert.AreEqual(newCount.Count, 2);
    }

    [TestMethod]
    public void Counter_CountWords_ReturnNull()
    {
      Counter newCount = new Counter("for the people by the people", "cat");
      string[] resultArray = newCount.SplitSentence();
      newCount.CountWords(resultArray);
      Assert.AreEqual(newCount.Count, 0);
    }
  }
}