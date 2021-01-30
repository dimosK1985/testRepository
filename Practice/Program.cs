using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(triangle);

            Dictionary<Guid, string> keyValuePairs = new Dictionary<Guid, string>();
            HashSet<Shape> shapes1 = new HashSet<Shape>();

            keyValuePairs.Add(triangle.Id, "a");
            // keyValuePairs.Add(triangle.Id, "1");

            shapes1.Add(triangle);
            shapes1.Add(triangle);

            foreach (IDrawable shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }
}
