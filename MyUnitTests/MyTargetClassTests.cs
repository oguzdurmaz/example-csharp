using UnitTestTargetProject;
using Xunit;

namespace MyUnitTests
{
    public class MyTargetClassTests
    {
        [Fact]
        public void Summary_WhenTwoIntegersAreProvided_ShouldReturnTotalAsInteger()
        {
            // Arrange
            MyTargetClass summtest = new MyTargetClass();
            // Act
            int actual = summtest.AddNumbers(Constants.Firstnumber, Constants.Secondnumber);
            //Assert
            Assert.Equal(25, actual);
        }

        [Fact]
        public void Subtract_WhenTwoIntegersAreProvided_ShouldReturnTotalAsInteger()
        {
            // Arrange
            MyTargetClass subtracttest = new MyTargetClass();
            // Act
            int actual = subtracttest.SubractNumbers(Constants.Firstnumber, Constants.Secondnumber);
            //Assert
            Assert.Equal(5, actual);
        }

        [Fact]
        public void Divide_WhenTwoIntegersAreProvided_ShouldReturnTotalAsInteger()
        {
            // Arrange
            MyTargetClass dividetest = new MyTargetClass();
            // Act
            int actual = dividetest.DivideNumbers(10, 2);
            //Assert
            Assert.Equal(5, actual);
        }
        
        [Fact]
        public void Multiple_WhenTwoIntegersAreProvided_ShouldReturnTotalAsInteger()
        {
            // Arrange
            MyTargetClass multipletest = new MyTargetClass();
            // Act
            int actual = multipletest.MultipleNumbers(35, 30);
            //Assert
            Assert.Equal(1050, actual);
        }
    }
}
