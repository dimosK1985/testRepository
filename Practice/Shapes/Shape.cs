using System;

namespace Practice
{
    public abstract class Shape
    {
        public Shape()
        {
            id = Guid.NewGuid();
        }

        protected Guid id;
    }

    public interface IShape
    {
        int SideCount();

        Guid Id();
    }

}
