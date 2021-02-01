using System;

namespace Practice
{
    public class Square : Shape, IShape, IDrawable
    {
        internal Square()
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
            return 4;
        }

        public override string ToString()
        {
            return $"I am a square, my id is {Id()}. I have {SideCount()} sides";
        }
    }
}
