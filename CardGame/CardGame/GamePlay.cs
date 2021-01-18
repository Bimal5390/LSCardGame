/// <summary>
/// 
/// </summary>
namespace CardGame
{
    using CardGame.Entity;
    using System;

    public class GamePlay
    {
        int choice;
        CardDeck deck;

        // Constructor - initializes the deck
        public GamePlay()
        {
            deck = new CardDeck();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            Console.WriteLine("!!!!!!!! Card Game Started !!!!!!!!!");
            do
            {
                Console.WriteLine("Please Choose one of the below Options to play: ");
                Console.WriteLine("1. Play a Card");
                Console.WriteLine("2. Shuffle the Deck");
                Console.WriteLine("3. Restart the Game");
                Console.WriteLine("4. Stop the Game");
                Console.WriteLine("Hello, What do you suppose to do ?");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Card card;
                        card = deck.PlayCard();
                        if (card != null)
                        {
                            Console.WriteLine("Hello, Card Withdrawn is: ");
                            Console.WriteLine($"Card Number:{card.CardNumber.ToString()} && Card Shape: {card.CardShape.ToString()}");
                        }
                        else
                            Console.WriteLine("No Cards Available! Kindly Restart the Game!! ");
                        break;
                    case 2:
                        deck.ShuffleCards();
                        Console.WriteLine("Cards Shuffled !!");
                        break;
                    case 3:
                        deck = new CardDeck();
                        Console.WriteLine("Game Restarted !!");
                        break;
                    case 4:
                        Console.WriteLine("Game Stopped !!");
                        break;
                    default:
                        Console.WriteLine("Please, Retry with below options!");
                        break;
                }
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                //Console.Clear();
            } while (choice != 4);
        }
    }
}