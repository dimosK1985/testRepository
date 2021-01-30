using System;

namespace Practice
{
    public class Square : Shape, IDrawable
    {
        public Square()
        {
            this.SideCount = 4;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
