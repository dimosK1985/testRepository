using System;

namespace Practice
{
    public class Triangle : Shape, IShape, IDrawable
    {
        internal Triangle()
        {
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public Guid Id()
        {
            return this.id;
        }

        public int SideCount()
        {
            return 3;
        }
    }
}
