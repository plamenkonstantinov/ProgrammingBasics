using System;


namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            int help = 0;

            for (int i1 = 1; i1 <= player1; i1++)
            {
                for (int i2 = 1; i2 <= player2; i2++)
                {
                    help++;
                    if (help>maxBattles)
                    {
                            break;
                    }
                    Console.Write("({0} <-> {1}) ", i1, i2 );
                }
            }

        }
    }
}
