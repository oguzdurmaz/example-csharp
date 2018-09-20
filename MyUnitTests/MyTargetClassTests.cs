using UnitTestTargetProject;
using Xunit;




namespace MyUnitTests
{
    public class MyTargetClassTests
    {

        [Fact]
        public void VerifySummation()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;           
        }

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
        public void VerifySubtraction()
        {
            const int intFirstNumber = 15;
            const int intsecondNumber = 10;
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
        public void VerifyDivide()
        {
            const int intFirstNumber = 10;
            const int intsecondNumber = 2;
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
        public void VerifyMultiple()
        {
            const int intFirstNumber = 35;
            const int intsecondNumber = 30;
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
