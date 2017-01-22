using System;


namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age<16)
            {// old or young
                if (gender =="f")
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }

            else
            {
                if (gender=="f")
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
