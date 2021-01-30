using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CreateTriangle_HasThreeSides()
        {
            // Arrange - Act
            Triangle triangle = new Triangle();
            // Assert
            Assert.AreEqual(3, triangle.SideCount);
        }

        [TestMethod]
        public void CreateTriangle_DrawTriangle_ThrowsException()
        {
            // Arrange - Act
            Triangle triangle = new Triangle();
            // Assert
            Assert.ThrowsException<NotImplementedException>(() => triangle.Draw());
        }
    }
}
