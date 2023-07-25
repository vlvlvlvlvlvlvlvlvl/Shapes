namespace Testing
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void Test_CalculateCircleArea()
        {
            Circle circle = new Circle(8);
            double area = circle.GetArea();
            Assert.AreEqual(201.06, area);
        }

        [TestMethod]
        public void Test_CalculateCircleAreaWithZeroInput() 
        {
            Circle circle = new Circle(0);
            double area = circle.GetArea();
            Assert.AreEqual(area, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CalculateCircleAreaWithNegativeInput()
        {
            Circle circle = new Circle(-1);
            circle.GetArea();
        }

        public void Test_CalculateCircleAreaWithDoubleInput()
        {
            Circle circle = new Circle(2.5);
            double area = circle.GetArea();
            Assert.AreEqual(19.63, area);
        }
    }
}