using System;

namespace Practice.Shapes
{
    public class ShapesFactory
    {
        public static IShape CreateShape(int shapeSideCount)
        {
            switch (shapeSideCount)
            {
                case 3:
                    return new Triangle();
                case 4:
                    return new Square();
                default:
                    throw new IncorrectSideCountException("Incorrect side count given");
            }
        }
    }

    public class IncorrectSideCountException : Exception
    {
        public IncorrectSideCountException(string message) : base(message)
        {

        }
    }
}
