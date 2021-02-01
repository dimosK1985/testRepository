using System;
using Practice.Shapes;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.AddShape(ShapesFactory.CreateShape(shapeSideCount: 3));

            Console.WriteLine("blah");
            Console.WriteLine(game.ToString());

            Console.ReadLine();

            game.AddShape(ShapesFactory.CreateShape(shapeSideCount: 4));

            Console.WriteLine(game.ToString());

            Console.ReadLine();

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
