using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {

    [TestMethod]
    public void Counter_CreateCount_Input()
    {
      // Arrange
      Counter newRectangle = new Rectangle(4, 4);
      // Act
      int result = newRectangle.GetArea();
      // Assert
      Assert.AreEqual(result, 16);
    }

  }
}