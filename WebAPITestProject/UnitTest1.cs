using OperatorsClassLibrary;

namespace WebAPITestProject
{
    [TestClass]
    public class UnitTest1
    {
        // Addition Tests

        [TestMethod]
        public void TestAddMethodWithZeroAsFirstNumber()
        {
            double additionresult;
            additionresult = Operations.Add(0, 20);
            Assert.AreEqual(20, additionresult);
        }

        [TestMethod]
        public void TestAddMethodWithZeroAsSecondNumber()
        {
            double additionresult;
            additionresult = Operations.Add(10, 0);
            Assert.AreEqual(10, additionresult);
        }

        [TestMethod]
        public void TestAddMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double additionresult;
            additionresult = Operations.Add(0, 0);
            Assert.AreEqual(0, additionresult);
        }

        [TestMethod]
        public void TestAddMethodWithPositiveNumbers()
        {
            double additionresult;
            additionresult = Operations.Add(20, 20);
            Assert.AreEqual(40, additionresult);
        }

        [TestMethod]
        public void TestAddMethodWithBothNegativeNumbers()
        {
            double additionresult;
            additionresult = Operations.Add(-10, -20);
            Assert.AreEqual(-30, additionresult);
        }

        [TestMethod]
        public void TestAddMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double additionresult;
            additionresult = Operations.Add(20, -20);
            Assert.AreEqual(0, additionresult);
        }

        [TestMethod]
        public void TestAddMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double additionresult;
            additionresult = Operations.Add(-20, 20);
            Assert.AreEqual(0, additionresult);
        }
        [TestMethod]
        public void TestAddMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double additionresult;
            additionresult = Operations.Add(30, -20);
            Assert.AreEqual(10, additionresult);
        }

        // Subtraction Tests

        [TestMethod]
        public void TestSubtractMethodWithZeroAsFirstNumber()
        {
            double subResult;
            subResult = Operations.Subtract(0, 20);
            Assert.AreEqual(-20, subResult);
        }

        [TestMethod]
        public void TestSubtractMethodWithZeroAsSecondNumber()
        {
            double subResult;
            subResult = Operations.Add(10, 0);
            Assert.AreEqual(10, subResult);
        }

        [TestMethod]
        public void TestSubtractMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double subResult;
            subResult = Operations.Add(0, 0);
            Assert.AreEqual(0, subResult);
        }

        [TestMethod]
        public void TestSubtractMethodWithPositiveNumbers()
        {
            double subResult;
            subResult = Operations.Add(20, 20);
            Assert.AreEqual(40, subResult);
        }

        [TestMethod]
        public void TestSubtractMethodWithBothNegativeNumbers()
        {
            double subResult;
            subResult = Operations.Add(-10, -20);
            Assert.AreEqual(10, subResult);
        }

        [TestMethod]
        public void TestSubtractMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double subResult;
            subResult = Operations.Add(20, -20);
            Assert.AreEqual(40, subResult);
        }

        [TestMethod]
        public void TestSubtractMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double subResult;
            subResult = Operations.Add(-20, 20);
            Assert.AreEqual(-40, subResult);
        }
        [TestMethod]
        public void TestSubtractMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double subResult;
            subResult = Operations.Add(30, -20);
            Assert.AreEqual(50, subResult);
        }

        // Multiply Tests


        [TestMethod]
        public void TestMultiplyMethodWithZeroAsFirstNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(0, 20);
            Assert.AreEqual(0, multiplyResult);
        }

        [TestMethod]
        public void TestMultiplyMethodWithZeroAsSecondNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(10, 0);
            Assert.AreEqual(0, multiplyResult);
        }

        [TestMethod]
        public void TestMultiplyMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(0, 0);
            Assert.AreEqual(0, multiplyResult);
        }

        [TestMethod]
        public void TestMultiplyMethodWithPositiveNumbers()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(20, 20);
            Assert.AreEqual(400, multiplyResult);
        }

        [TestMethod]
        public void TestMultiplyMethodWithBothNegativeNumbers()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(-10, -20);
            Assert.AreEqual(200, multiplyResult);
        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(20, -20);
            Assert.AreEqual(-400, multiplyResult);
        }

        [TestMethod]
        public void TestMultiplyMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(-20, 20);
            Assert.AreEqual(-400, multiplyResult);
        }
        [TestMethod]
        public void TestMultiplyMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(30, -20);
            Assert.AreEqual(-600, multiplyResult);
        }

        // Division tests


        [TestMethod]
        public void TestDivisionMethodWithZeroAsFirstNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(0, 20);
            Assert.AreEqual(0, divisionResult);
        }

        [TestMethod]
        public void TestDivisionMethodWithZeroAsSecondNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(10, 0);
            Assert.AreEqual(-1, divisionResult);
        }

        [TestMethod]
        public void TestDivisionMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(0, 0);
            Assert.AreEqual(-1, divisionResult);
        }

        [TestMethod]
        public void TestDivisionMethodWithPositiveNumbers()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(20, 20);
            Assert.AreEqual(1, divisionResult);
        }

        [TestMethod]
        public void TestDivisionMethodWithBothNegativeNumbers()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(-20, -20);
            Assert.AreEqual(1, divisionResult);
        }

        [TestMethod]
        public void TestDivisionMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(20, -20);
            Assert.AreEqual(-1, divisionResult);
        }

        [TestMethod]
        public void TestDivisionMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(-20, 20);
            Assert.AreEqual(-1, divisionResult);
        }
        [TestMethod]
        public void TestDivisionMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(40, -20);
            Assert.AreEqual(-2, divisionResult);
        }
    }
}