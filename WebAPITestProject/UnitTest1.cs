using OperatorsClassLibrary;

namespace WebAPITestProject
{
    [TestClass]
    public class UnitTest1
    {
        // Addition Tests

        /*
         * Below method is used to verify add operation when first number is zero
         */
        [TestMethod]
        public void TestAddMethodWithZeroAsFirstNumber()
        {
            double additionresult;
            additionresult = Operations.Add(0, 20);
            Assert.AreEqual(20, additionresult);
        }

        /*
         * Below method is used to verify add operation when second number is zero
         */
        [TestMethod]
        public void TestAddMethodWithZeroAsSecondNumber()
        {
            double additionresult;
            additionresult = Operations.Add(10, 0);
            Assert.AreEqual(10, additionresult);
        }

        /*
         * Below method is used to verify add operation when both numbers are zero
         */
        [TestMethod]
        public void TestAddMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double additionresult;
            additionresult = Operations.Add(0, 0);
            Assert.AreEqual(0, additionresult);
        }

        /*
         * Below method is used to verify add operation when both numbers are positive
         */
        [TestMethod]
        public void TestAddMethodWithPositiveNumbers()
        {
            double additionresult;
            additionresult = Operations.Add(20, 20);
            Assert.AreEqual(40, additionresult);
        }

        /*
         * Below method is used to verify add operation when both numbers are negative
         */
        [TestMethod]
        public void TestAddMethodWithBothNegativeNumbers()
        {
            double additionresult;
            additionresult = Operations.Add(-10, -20);
            Assert.AreEqual(-30, additionresult);
        }

        /*
         * Below method is used to verify add operation when first number is positive
         * and second number is negative
         */
        [TestMethod]
        public void TestAddMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double additionresult;
            additionresult = Operations.Add(20, -20);
            Assert.AreEqual(0, additionresult);
        }

        /*
         * Below method is used to verify add operation when first number is negative
         * and second number is positive
         */
        [TestMethod]
        public void TestAddMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double additionresult;
            additionresult = Operations.Add(-20, 20);
            Assert.AreEqual(0, additionresult);
        }

        /*
         * Below method is used to verify add operation when positive number 
         * greater than negative number
         */
        [TestMethod]
        public void TestAddMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double additionresult;
            additionresult = Operations.Add(30, -20);
            Assert.AreEqual(10, additionresult);
        }

        /*
         * Below method is used to verify add operation when negative number 
         * greater than positive number
         */
        [TestMethod]
        public void TestAddMethodWithNegativeNumberGreaterThanPositiveNumber()
        {
            double additionresult;
            additionresult = Operations.Add(-30, 20);
            Assert.AreEqual(-10, additionresult);
        }

        // Subtraction Tests

        /*
         * Below method is used to verify subtract operation when first number is zero
         */
        [TestMethod]
        public void TestSubtractMethodWithZeroAsFirstNumber()
        {
            double subResult;
            subResult = Operations.Subtract(0, 20);
            Assert.AreEqual(-20, subResult);
        }

        /*
         * Below method is used to verify subtract operation when second number is zero
         */
        [TestMethod]
        public void TestSubtractMethodWithZeroAsSecondNumber()
        {
            double subResult;
            subResult = Operations.Subtract(10, 0);
            Assert.AreEqual(10, subResult);
        }

        /*
         * Below method is used to verify subtract operation when first number
         * and second number are zero
         */
        [TestMethod]
        public void TestSubtractMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double subResult;
            subResult = Operations.Subtract(0, 0);
            Assert.AreEqual(0, subResult);
        }

        /*
         * Below method is used to verify subtract operation 
         * when both numbers are positive
         */
        [TestMethod]
        public void TestSubtractMethodWithPositiveNumbers()
        {
            double subResult;
            subResult = Operations.Subtract(20, 20);
            Assert.AreEqual(40, subResult);
        }

        /*
         * Below method is used to verify subtract operation 
         * when both numbers are negative
         */
        [TestMethod]
        public void TestSubtractMethodWithBothNegativeNumbers()
        {
            double subResult;
            subResult = Operations.Subtract(-10, -20);
            Assert.AreEqual(10, subResult);
        }

        /*
         * Below method is used to verify subtract operation 
         * when first number is positive and second is negative
         */
        [TestMethod]
        public void TestSubtractMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double subResult;
            subResult = Operations.Subtract(20, -20);
            Assert.AreEqual(40, subResult);
        }

        /*
         * Below method is used to verify subtract operation 
         * when both first number is negative and second is positive
         */
        [TestMethod]
        public void TestSubtractMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double subResult;
            subResult = Operations.Subtract(-20, 20);
            Assert.AreEqual(-40, subResult);
        }

        /*
         * Below method is used to verify subtract operation 
         * when positive number greater than negative
         */
        [TestMethod]
        public void TestSubtractMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double subResult;
            subResult = Operations.Subtract(30, -20);
            Assert.AreEqual(50, subResult);
        }

        /*
         * Below method is used to verify subtract operation 
         * when negative number greater than positive
         */
        [TestMethod]
        public void TestSubtractMethodWithNegativeNumberGreaterThanPositiveNumber()
        {
            double subResult;
            subResult = Operations.Subtract(-30, 20);
            Assert.AreEqual(-10, subResult);
        }

        // Multiply Tests

        /*
         * Below method is used to verify multiply operation when first number is zero
         */
        [TestMethod]
        public void TestMultiplyMethodWithZeroAsFirstNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(0, 20);
            Assert.AreEqual(0, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when second number is zero
         */
        [TestMethod]
        public void TestMultiplyMethodWithZeroAsSecondNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(10, 0);
            Assert.AreEqual(0, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when both numbers are zero
         */
        [TestMethod]
        public void TestMultiplyMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(0, 0);
            Assert.AreEqual(0, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when both numbers are positive
         */
        [TestMethod]
        public void TestMultiplyMethodWithPositiveNumbers()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(20, 20);
            Assert.AreEqual(400, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when both number negative
         */
        [TestMethod]
        public void TestMultiplyMethodWithBothNegativeNumbers()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(-10, -20);
            Assert.AreEqual(200, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when first number positive
         * and second one negative
         */
        [TestMethod]
        public void TestMultiplyMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(20, -20);
            Assert.AreEqual(-400, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when first number negative
         * and second one positive
         */
        [TestMethod]
        public void TestMultiplyMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(-20, 20);
            Assert.AreEqual(-400, multiplyResult);
        }

        /*
         * Below method is used to verify mulitply operation when negative number
         * greater than positive number
         */
        [TestMethod]
        public void TestMultiplyMethodWithNegativeNumberGreaterThanPositiveNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(-40, 20);
            Assert.AreEqual(-800, multiplyResult);
        }

        /*
         * Below method is used to verify multiply operation when positive number
         * greater than negative number
         */
        [TestMethod]
        public void TestMultiplyMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double multiplyResult;
            multiplyResult = Operations.Multiply(30, -20);
            Assert.AreEqual(-600, multiplyResult);
        }

        // Division tests

        /*
         * Below method is used to verify divide operation when first number is zero
         */
        [TestMethod]
        public void TestDivisionMethodWithZeroAsFirstNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(0, 20);
            Assert.AreEqual(0, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when second number is zero
         */
        [TestMethod]
        public void TestDivisionMethodWithZeroAsSecondNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(10, 0);
            Assert.AreEqual(-1, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when both number are zero
         */
        [TestMethod]
        public void TestDivisionMethodWithZeroAsFirstNumberAndSecondNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(0, 0);
            Assert.AreEqual(-1, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when both are positive numbers
         */
        [TestMethod]
        public void TestDivisionMethodWithPositiveNumbers()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(20, 20);
            Assert.AreEqual(1, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when both numbers are negative
         */
        [TestMethod]
        public void TestDivisionMethodWithBothNegativeNumbers()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(-20, -20);
            Assert.AreEqual(1, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when first number is positive
         * and second number is negative
         */
        [TestMethod]
        public void TestDivisionMethodWithFirstNumberPositiveAndSecondNumberNegative()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(20, -20);
            Assert.AreEqual(-1, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when first number is negative
         * and second number is positive
         */
        [TestMethod]
        public void TestDivisionMethodWithFirstNumberNegativeAndSecondNumberPositive()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(-20, 20);
            Assert.AreEqual(-1, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when positive number
         * greater than negative number
         */
        [TestMethod]
        public void TestDivisionMethodWithPositiveNumberGreaterThanNegativeNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(40, -20);
            Assert.AreEqual(-2, divisionResult);
        }

        /*
         * Below method is used to verify divide operation when negative number
         * greater than positive number
         */
        [TestMethod]
        public void TestDivisionMethodWithNegativeNumberGreaterThanPositiveNumber()
        {
            double divisionResult;
            divisionResult = Operations.Multiply(-40, 20);
            Assert.AreEqual(-2, divisionResult);
        }
    }
}