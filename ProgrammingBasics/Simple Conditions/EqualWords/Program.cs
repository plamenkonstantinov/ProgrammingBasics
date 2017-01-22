using System;


namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = (Console.ReadLine().ToLower());
            var text2 = (Console.ReadLine().ToLower());
            if (text1 == text2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
