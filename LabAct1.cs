using System;

class Program
{
    static void Main()
    {
        int x = 30; // Define the upper limit
        for (int i = 1; i <= x; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("foo bar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}