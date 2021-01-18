/// <summary>
/// Entry point of the console application
/// </summary>
namespace CardGame
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GamePlay game = new GamePlay();
                game.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}