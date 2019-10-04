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
      // Arrange
      Counter newCount = new Counter("for the people by the people", "people");
      // Act
      string sentence = newCount.Sentence;
      // Assert
      Assert.AreEqual(sentence, "for the people by the people");
    }

  }
}