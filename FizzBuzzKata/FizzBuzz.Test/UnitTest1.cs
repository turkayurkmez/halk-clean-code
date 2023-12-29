using FizzBuzz.Game;
using Xunit;

namespace FizzBuzz.Test
{
    public class UnitTest1
    {
        //[Fact]
        //public void ItIsExist()
        //{
        //    var gameBoard = new FizzBuzz.Game.FizzBuzzBoard();
        //    var number = 3;
        //    string response = gameBoard.GetWordForNumber(number);
        //}

        FizzBuzzBoard board = new FizzBuzzBoard();

        [Fact]
        public void When_Using_three_Return_Fizz()
        {

            //Arrange:
            var board = new FizzBuzzBoard();
            var number = 3;

            //Act:
            string actual = board.GetWordForNumber(number);
            //Assert:
            Assert.Equal("Fizz", actual);


        }

        [Fact]
        public void When_sending_five_return_buzz()
        {
            var board = new FizzBuzzBoard();
            var number = 5;

            //Act:
            string actual = board.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void When_send_multiply_three_return_fizz(int number)
        {
            string actual = board.GetWordForNumber(number);
            Assert.Equal("Fizz", actual);
        }


        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void When_send_multiply_five_return_buzz(int number)
        {
            string actual = board.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);
        }
    }
}