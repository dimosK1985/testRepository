using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        // 1. Get Max -> nothing in stack -> exception thrown
        // 2. Get Max -> 0 + 1 in list -> returns 1
        // 3. Get Max ->  -5 -7 in list -> returns -5
        // 4. one in stack, Pop twice // or Pop empty stack
        // 5. Push one int, expect it to be Max?
        // 5. Push one int, expect it to be Poped
        // 6. Pop , ask to pop when empty stack (exception? or not)
        // 7. Push 3, Pop, expect the last one
        private const string stackEmptyMessage = "Stack is empty";

        [TestMethod]
        public void MaxStack_NothingInStack_GetMax_ThrowsException()
        {
            // Arrange
            MaxStack maxStack = new MaxStack();
            // Act
            Action action = () => maxStack.GetMax();
            // Assert
            Assert.ThrowsException<Exception>(action, stackEmptyMessage);
        }

        [TestMethod]
        public void MaxStack_NothingInStack_Pop_ThrowsException()
        {
            // Arrange
            MaxStack maxStack = new MaxStack();
            // Act
            Action action = () => maxStack.Pop();
            // Assert
            Assert.ThrowsException<EmptyStackException>(action, stackEmptyMessage);
        }

        [TestMethod]
        public void MaxStack_PushThreeIntegers_Pop_PopReturnsLast()
        {
            // Arrange
            int expectedInt = 5;
            MaxStack maxStack = new MaxStack();
            // Act
            maxStack.Push(1);
            maxStack.Push(-2);
            maxStack.Push(expectedInt);
            // Assert
            Assert.AreEqual(expectedInt, maxStack.Pop());
        }
    }
}
