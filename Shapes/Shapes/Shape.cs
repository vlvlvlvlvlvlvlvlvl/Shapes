namespace Shapes
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public virtual bool Validate()
        {
            return true;
        }
    }
}
