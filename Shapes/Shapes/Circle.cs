namespace Shapes

{
    public class Circle : Shape
    {
        public double Radius { get; protected set; }

        public Circle(double radius)
        { 
            Radius = radius; 
        }

        public override bool Validate()
        {
            if (Radius < 0)
            {
                return false;
            }

            return true;
        }

        public override double GetArea()
        {
            if(!Validate()) 
            {
                throw new ArgumentException("Фигура не является окружностью, т.к. радиус меньше нуля.");
            }

            return Math.Round(Math.PI * Radius * Radius, 2, MidpointRounding.AwayFromZero);
        }
    }
}
