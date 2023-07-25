namespace Testing
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void Test_CalculateTriangleArea()
        {
            Triangle triangle = new Triangle(15, 13, 17);
            double? area = triangle.GetArea();
            Assert.AreEqual(93.9, area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CalculateTriangleAreaWithZeroInput()
        {
            Triangle triangle = new Triangle(0, 0, 0);
            triangle.GetArea();
        }

        [TestMethod]
        public void Test_IsTriangleRight()
        {
            Triangle triangle = new Triangle(15, 13, 17); // Не прямугольный треугольник
            bool result = triangle.IsRightTriangle();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_IsTriangleRight2()
        {
            Triangle triangle = new Triangle(3, 4, 5); // Прямугольный треугольник
            bool result = triangle.IsRightTriangle();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_GetRightTriangleLegsAndHypotenuse()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            triangle.IsRightTriangle(out _, out _, out uint hypotenuse);
            Assert.AreEqual(5U, hypotenuse); // если гипотенуза совпала, то значит стороны определены верны
        }

        [TestMethod]
        public void Test_IsValidTriangle()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.IsTrue(triangle.Validate());
        }

        [TestMethod]
        public void Test_IsValidTriangle2()
        {
            Triangle triangle = new Triangle(5, 4, 10);
            Assert.IsFalse(triangle.Validate());
        }
    }
}
