using System;

namespace StopWatchSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int choice;
            try
            {
                do
                {

                    Console.Write("1-Start Timer\n2-Stop Timer\n3-Read Timer\n0-Quit\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: stopwatch.Start(); break;
                        case 2: stopwatch.Stop(); break;
                        case 3: Console.WriteLine(stopwatch.ElapsedTime()); break;
                    }

                } while (choice != 0);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
