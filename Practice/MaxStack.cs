using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class MaxStack : IMaxStack
    {
        private const string stackEmptyMessage = "Stack is empty";
        private Stack<int> stackOfIntegers = null;

        public MaxStack()
        {
            stackOfIntegers = new Stack<int>();
        }

        public int GetMax()
        {

            if (stackOfIntegers.Count == 0)
            {
                throw new Exception(stackEmptyMessage);
            }

            return stackOfIntegers.Max();
        }

        public int Pop()
        {
            if (stackOfIntegers.Count == 0)
            {
                throw new EmptyStackException(stackEmptyMessage);
            }

            return stackOfIntegers.Pop();
        }

        public void Push(int element)
        {
            stackOfIntegers.Push(element);
        }
    }

    public class EmptyStackException : Exception
    {
        public EmptyStackException(string message)
            : base(message)
        {

        }
    }
}
