using InternTask.Lib;

namespace InternTask.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Circle_CreateCircle_Succes()
        {
            var r = 1;

            var circle = new Circle(r);

            Assert.IsNotNull(circle);
        }

        [TestMethod]
        public void Circle_CreateCircle_Fail()
        {
            var r = -1;

            Assert.ThrowsException<ArgumentException>(() => new Circle(r));
        }

        [TestMethod]
        public void Circle_GetSurface_Succes()
        {
            var r = 1;

            var circle = new Circle(r);

            Assert.AreEqual(circle.GetSurface(), Math.PI);
        }

        [TestMethod]
        public void Triangle_Create_Succes()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void Triangle_CreateCircle_Fail()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 2, 3));
        }

        [TestMethod]
        public void Triangle_GetSurface_Succes()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var triange = new Triangle(a, b, c);

            var p = a + b + c;
            var s = p * (p - a) * (p - b) * (p - c);

            Assert.AreEqual(triange.GetSurface(), Math.Sqrt(s));
        }

        [TestMethod]
        public void Triangle_IsRight_Succes()
        {
            var triangle = new Triangle(4, 3, 5);

            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void Triangle_IsRight_Fail()
        {
            var triangle = new Triangle(4, 4, 5);

            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}