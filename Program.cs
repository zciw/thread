using System;
using System.Threading;

namespace thread
{
    class Program
    {
        static void displayText()
        {
            Console.WriteLine("some text");
        }
        
        static int[] generujTab(int rozmiar)
        {
            int[] t = new int[rozmiar];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(1, 5);
            }
            return t;
        }
 
        static int suma(int[] t, int start, int end)
        {
            var n = 0;
            for (int i = start; i < end; i++)
            {
                n = t[i] + n;
            }
            return n;
        }
		static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Thread t = new Thread(new ThreadStart(displayText));

            t.Start();
            Console.WriteLine("other text");

            int[] losowe = generujTab(1000);
            int s = suma(losowe, 0, losowe.Length);
            Console.WriteLine(s);
        }
    }
}
