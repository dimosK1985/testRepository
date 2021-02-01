using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Shapes
{
    public class Game
    {
        private List<IShape> listOfShapes;

        public Game()
        {
        }

        public void AddShape(IShape shape)
        {
            if (listOfShapes == null)
            {
                listOfShapes = new List<IShape>();
            }

            listOfShapes.Add(shape);
        }

        public void RemoveShape(IShape shape)
        {
            if (listOfShapes == null)
            {
                listOfShapes = new List<IShape>();
                return;
            }

            IShape shapeToRemove = listOfShapes.First(s => s.Id() == shape.Id());

            listOfShapes.Remove(shapeToRemove);
        }

        public override string ToString()
        {
            string shapes = string.Empty;
            listOfShapes.ForEach(x => shapes += x.ToString() + Environment.NewLine);
            return shapes;
        }
    }
}
