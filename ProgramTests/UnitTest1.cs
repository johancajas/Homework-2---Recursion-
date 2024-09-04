namespace ProgramTests;

public class UnitTest1
{
    public class UnitTest
    {    [Fact]
        public void TestPowerOf2Iterative()
        {
            // Arrange
            int n = 3;
            int expected = 8;

            // Act
            int result = Program.PowerOf2Iterative(n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPowerOf2Recursive()
        {
            // Arrange
            int n = 3;
            int expected = 8;

            // Act
            int result = Program.PowerOf2Recursive(n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPowerOf2Iterative_Zero()
        {
            // Arrange
            int n = 0;
            int expected = 1;

            // Act
            int result = Program.PowerOf2Iterative(n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPowerOf2Recursive_Zero()
        {
            // Arrange
            int n = 0;
            int expected = 1;

            // Act
            int result = Program.PowerOf2Recursive(n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPowerOf2Iterative_LargerNumber()
        {
            // Arrange
            int n = 5;
            int expected = 32;

            // Act
            int result = Program.PowerOf2Iterative(n);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPowerOf2Recursive_LargerNumber()
        {
            // Arrange
            int n = 5;
            int expected = 32;

            // Act
            int result = Program.PowerOf2Recursive(n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}