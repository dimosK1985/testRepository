using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace UnitTests
{
    [TestClass]
    public class StringReverseTests
    {
        [TestMethod]
        public void StringReverse_StringEmpty_ReturnsTrue()
        {
            // Arrange - Act
            bool reverseEmptyIsPalindrome = StaticHelperMethods.IsStringPalindrome(string.Empty);
            // Assert ..
            Assert.IsTrue(reverseEmptyIsPalindrome);
        }

        [TestMethod]
        public void StringReverse_StringNull_ReturnsTrue()
        {
            // Arrange - Act
            bool reverseNullIsPalindrome = StaticHelperMethods.IsStringPalindrome(null);
            // Assert
            Assert.IsTrue(reverseNullIsPalindrome);
        }

        [TestMethod]
        public void StringReverse_StringAbc_ReturnsFalse()
        {
            // Arrange - Act
            bool reverseIsPalindrome = StaticHelperMethods.IsStringPalindrome("abc");
            // Assert
            Assert.IsFalse(reverseIsPalindrome);
        }

        [TestMethod]
        public void StringReverse_StringAnna_ReturnsTrue()
        {
            // Arrange - Act
            bool reverseIsPalindrome = StaticHelperMethods.IsStringPalindrome("anna");
            // Assert
            Assert.IsTrue(reverseIsPalindrome);
        }
    }
}
