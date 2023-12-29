using TestExpression.StringEvaluator;

namespace TestExpression.UnitTest
{
    public class EvaluatorUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ThrowsErrorIfStringExpressionIsEmpty()
        {

            try
            {
                // Arrange
                Evaluator stringEvaluator = new Evaluator();

                // Act
                var result = stringEvaluator.Evaluate(string.Empty);

                // Assert
                Assert.Fail();
            }
            catch (Exception ex)
            {
                if (ex.Message != "Expression cannot be null or empty")
                {
                    Assert.Fail();
                }

            }
        }

        [TestCase("+5-")]
        [TestCase("xy1g")]
        [TestCase("+10")]
        [TestCase("1/-+1")]
        public void ThrowsErrorIfStringExpressionIsNotValid(string expression)
        {
            try
            {
                // Arrange
                Evaluator stringEvaluator = new Evaluator();

                // Act
                var result = stringEvaluator.Evaluate(expression);

                // Assert
                Assert.Fail();
            }
            catch (Exception ex)
            {
                if (ex.Message != "Expression is not valid. Only + or - or / or * are available")
                {
                    Assert.Fail();
                }

            }

        }

        [TestCase("0/0")]
        [TestCase("1/0")]
        public void ThrowsErrorWhenDividingByZero(string expression)
        {
            try
            {
                // Arrange
                Evaluator stringEvaluator = new Evaluator();

                // Act
                var result = stringEvaluator.Evaluate(expression);

                // Assert
                Assert.Fail();
            }
            catch (Exception ex)
            {

            }

        }

        [TestCase("4+5*2", 14)]
        [TestCase("4+5/2", 6.5)]
        [TestCase("4+5/2-1", 5.5)]
        public void GetResultFromStringExpression(string expression, decimal expectedResult)
        {
            // Arrange
            Evaluator stringEvaluator = new Evaluator();

            // Act
            decimal result = stringEvaluator.Evaluate(expression);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }



    }
}
