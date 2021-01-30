using System;

namespace Practice
{
    public abstract class Shape
    {
        public Shape()
        {
            Id = Guid.NewGuid();
        }

        public int SideCount;
        public Guid Id { get; private set; }
    }

}
