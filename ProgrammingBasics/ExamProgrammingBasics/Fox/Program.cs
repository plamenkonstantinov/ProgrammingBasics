using System;


namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            //mid = n/3

            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 3;
            int mid = n / 3;
            int asterixTopLeft = 1;
            int asterixTopRight = 1;
            int dashestop = 2*n-1;
            int asterixmidLeft = n / 2;
            int asterixmidRight = n / 2;
            int asterixMid = n;
            int dashesBottomLeft = 1;
            int dashesBottomRight = 1;
            int asterixBot = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('*', asterixTopLeft), new string('-', dashestop), new string('*', asterixTopRight));
                asterixTopLeft++;
                asterixTopRight++;
                dashestop -= 2;


            }
            for (int i = 0; i < mid; i++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|", new string('*', asterixmidLeft), new string('*', asterixMid), new string('*',asterixmidRight));
                asterixmidRight++;
                asterixmidLeft++;
                asterixMid -=2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', dashesBottomLeft), new string('*', asterixBot), new string('-', dashesBottomRight));
                dashesBottomLeft++;
                dashesBottomRight++;
                asterixBot -= 2;


            }

        }
    }
}
