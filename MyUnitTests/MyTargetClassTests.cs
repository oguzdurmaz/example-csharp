using UnitTestTargetProject;
using Xunit;

namespace MyUnitTests
{
    public class MyTargetClassTests
    {
        [Fact]
        public void Summary()
        {
            // Arrange
            MyTargetClass summtest = new MyTargetClass();
            // Act
            int actual = summtest.AddNumbers(15,10);
            //Assert
            Assert.Equal(25, actual);
        }

        [Fact]
        public void Subtract()
        {
            // Arrange
            MyTargetClass subtracttest = new MyTargetClass();
            // Act
            int actual = subtracttest.SubractNumbers(15,10);
            //Assert
            Assert.Equal(5, actual);
        }

        [Fact]
        public void Divide()
        {
            // Arrange
            MyTargetClass dividetest = new MyTargetClass();
            // Act
            int actual = dividetest.DivideNumbers(10, 2);
            //Assert
            Assert.Equal(5, actual);
        }
        
        [Fact]
        public void Multiple()
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
