using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var action = Console.ReadLine();

            if (action=="+" )
            {
                var result = n1 + n2;
                if (result%2==0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even",n1,n2, result );
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, result);
                }
                
            }
            else if (action=="-")
            {
                var result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, result);
                }
            }
            else if (action=="*")
            {
                var result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", n1, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, result);
                }
            }
            else if (action=="/")
            {
                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}",n1, n2, n1/n2 );
                }
            }
            else if (action =="%")
            {
                if (n2==0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2}",n1, n2, n1 % n2);
                }    
            }
        }
    }
}
