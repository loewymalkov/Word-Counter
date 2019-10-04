using Microsoft.VisualStudio.TestTools.UnitTesting;
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

  }
}