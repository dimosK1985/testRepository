using System;

namespace Practice
{
    public class Triangle : Shape, IDrawable
    {
        public Triangle()
        {
            this.SideCount = 3;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
