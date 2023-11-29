using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay18Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Your Lucky Number from 1-10");
                int num = int.Parse(Console.ReadLine());

                Game game = new Game();

                for (int i = 0; i < num; i++)
                {
                    game.Spin();
                }

                if (game.EnergyLevel >= 4 && game.WinningProbability > 60)
                {
                    Console.WriteLine("Winner");
                }
                else if (game.EnergyLevel >= 1 && game.WinningProbability > 50)
                {
                    Console.WriteLine("Runner Up");
                }
                else
                {
                    Console.WriteLine("Looser");
                }

                Console.WriteLine("If you want to continue Then press y");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}