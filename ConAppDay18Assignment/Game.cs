using System;

namespace ConAppDay18Assignment
{
    public class Game
    {
        public int EnergyLevel { get; private set; }
        public int WinningProbability { get; private set; }
        private Random random;

        public Game()
        {
            EnergyLevel = 1;
            WinningProbability = 100;
            random = new Random();
        }

        public void Spin()
        {
            int spinResult = random.Next(1, 11); // Simulating a random spin result between 1 and 10
            switch (spinResult)
            {
                case 1:
                    EnergyLevel += 1;
                    WinningProbability += 10;
                    break;
                case 2:
                    EnergyLevel += 2;
                    WinningProbability += 20;
                    break;
                case 3:
                    EnergyLevel -= 3;
                    WinningProbability -= 30;
                    break;
                case 4:
                    EnergyLevel += 4;
                    WinningProbability += 40;
                    break;
                case 5:
                    EnergyLevel += 5;
                    WinningProbability += 50;
                    break;
                case 6:
                    EnergyLevel -= 1;
                    WinningProbability -= 60;
                    break;
                case 7:
                    EnergyLevel += 1;
                    WinningProbability += 70;
                    break;
                case 8:
                    EnergyLevel -= 2;
                    WinningProbability -= 20;
                    break;
                case 9:
                    EnergyLevel -= 3;
                    WinningProbability -= 30;
                    break;
                case 10:
                    EnergyLevel += 10;
                    WinningProbability += 100;
                    break;
                default:
                    break;
            }
        }
    }
}