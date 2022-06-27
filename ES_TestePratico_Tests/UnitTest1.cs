using ES_ExercicioPratico.Models;
using Xunit;

namespace ES_TestePratico_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Prizes()
        {
            ///A A A
            ///ARRANGE
            string excpetedPrice = "1º prémio";
            Key key = new() { Number1 = 1, Number2 = 2, Number3 = 3, Number4 = 4, Number5 = 5, Star1 = 1, Star2 = 2 };
            Key selectedKey = new() { Number1 = 1, Number2 = 2, Number3 = 3, Number4 = 4, Number5 = 5, Star1 = 1, Star2 = 2 };

            //ACT
            string prize = key.PrizePosition(selectedKey);

            //ASSERT
            Assert.Equal(excpetedPrice, prize);
        }
    }
}