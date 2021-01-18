/// <summary>
/// 
/// </summary>
namespace CardGame.CardDeck
{
    using CardGame.Entity;
    using CardGame.Enum;
    using System;

    public class CardDeck
    {
        private Card[] cards;
        int i;
        private const int _totalCards = 52, _totalCardNumbers = 13, _totalCardShapes = 4;

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