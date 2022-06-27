using ES_ExercicioPratico.Models;
using Xunit;

namespace ES_ExercicioPratico_Tests
{
    public class KeyTests
    {
        [Fact]
        public void Test_Prize_1Prize()
        {
            ///A A A
            ///ARRANGE
            string excpetedPrice = "1� pr�mio";
            Key key = new() { Number1 = 1, Number2 = 2, Number3 = 3, Number4 = 4, Number5 = 5, Star1 = 1, Star2 = 2 };
            Key selectedKey = new() { Number1 = 1, Number2 = 2, Number3 = 3, Number4 = 4, Number5 = 5, Star1 = 1, Star2 = 2 };

            //ACT
            string prize = key.PrizePosition(selectedKey);

            //ASSERT
            Assert.Equal(excpetedPrice, prize);
        }
    }
}