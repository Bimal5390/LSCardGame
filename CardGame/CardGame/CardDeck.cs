/// <summary>
/// Class contains card play logic, shuffle logic
/// </summary>
namespace CardGame
{
    using CardGame.Entity;
    using CardGame.Enum;
    using System;

    public class CardDeck
    {
        private Card[] cards;
        int i;
        private const int _totalCards = 52, _totalCardNumbers = 13, _totalCardShapes = 4;

        /// <summary>
        /// Constructor - Creates set of 52 cards and shuffles them
        /// </summary>
        public CardDeck()
        {
            try
            {
                i = _totalCards - 1;
                cards = new Card[_totalCards];
                int x = 0;
                for (int a = 0; a <= _totalCardShapes - 1; a++)
                {
                    for (int b = 0; b <= _totalCardNumbers - 1; b++)
                    {
                        cards[x] = new Card((CardShape)a, (CardNumber)b);
                        x++;
                    }
                }
                this.ShuffleCards();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Logic to Shuffle the remaining card
        /// </summary>
        public void ShuffleCards()
        {
            try
            {
                Random rnd = new Random();
                int index = 0;
                for (int j = 0; j <= i; j++)
                {
                    index = rnd.Next(i - j);
                    Card temp = cards[index];
                    cards[index] = cards[i];
                    cards[i] = temp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Logic for Play a card from the deck
        /// </summary>
        /// <returns></returns>
        public Card PlayCard()
        {
            Card temp = null;
            try
            {
                if (i >= 0)
                {
                    temp = cards[i];
                    cards[i] = null;
                    i--;
                }
                else temp = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
            return temp;
        }
    }
}