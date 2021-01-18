/// <summary>
/// Object class for card
/// </summary>
namespace CardGame.Entity
{
    using CardGame.Enum;

    public class Card
    {
        public CardNumber CardNumber { get; set; }
        public CardShape CardShape { get; set; }

        public Card(CardShape cardShape, CardNumber cardNumber)
        {
            CardNumber = cardNumber;
            CardShape = cardShape;
        }
    }
}