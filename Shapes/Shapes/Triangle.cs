namespace Shapes
{
    public class Triangle : Shape
    {
        // Т.к. нужно чтобы можно было легче добавлять новые фигуры, я сделал, чтобы длины сторон были с модификатором protected.
        // в этом случае можно будет наследоваться от фигуры и добавлять ещё стороны.
        public uint A { get; protected set; }
        public uint B { get; protected set; }
        public uint C { get; protected set; }

        public Triangle(uint a, uint b, uint c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override bool Validate()
        {
            return (A + B > C) && (A + C > B) && (B + C > A);
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным. Сделал чтобы можно было определить какие стороны катеты, а какая сторона гипотенуза
        /// </summary>
        /// <param name="leg1"></param>
        /// <param name="leg2"></param>
        /// <param name="hypotenuse"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool IsRightTriangle(out uint leg1,  out uint leg2, out uint hypotenuse) 
        {
            if (!Validate())
            {
                throw new ArgumentException("Стороны треугольника не образуют треугольник.");
            }

            if(A * A + B * B == C * C)
            {
                leg1 = A;
                leg2 = B;
                hypotenuse = C;

                return true;
            }
            else if(C * C + A * A == B * B)
            {
                leg1 = C;
                leg2 = A;
                hypotenuse = B;

                return true;
            }
            else if(C * C + B * B == A * A)
            {
                leg1 = C;
                leg2 = B;
                hypotenuse = A;

                return true;
            }

            leg1 = leg2 = hypotenuse = 0;
            return false;
        }

        public bool IsRightTriangle()
        {
            return IsRightTriangle(out _, out _, out _);
        }

        public override double GetArea()
        {
            if (!Validate())
            {
                throw new ArgumentException("Стороны треугольника не образуют треугольник.");
            }

            double semiPerimeter = (A + B + C) / 2.0;
            return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C)), 2, MidpointRounding.AwayFromZero);
        }
    }
}
