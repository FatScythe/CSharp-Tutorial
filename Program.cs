// LESSON 44
// using System.Threading; // This is not needed, at least not on this version of dotnet

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread = an execution path of a program
            //          We can use multiple threads to perform,
            //          different tasks of our program at the same tie
            //          Current thread running is the main thread

            Thread mainThread = Thread.CurrentThread;
            // Change the name of the thread
            mainThread.Name = "Main Thread";


            Thread thread1 = new Thread(CountDown);
            // Thread thread2 = new Thread(CountUp);
            // if you need to pass a value in the fn, we use a lambda expression/
            // callback fn
            Thread thread2 = new Thread(() => CountUp("Timer #2"));



            thread1.Start(); // To start a thread
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is completed");
            Console.ReadKey();
        }

        static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i);
                Thread.Sleep(1000); // To make a thread delay, in ms
            }
            Console.WriteLine("Timer #1 is completed");
        }

        static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(name + ": " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(name + " #2 is completed");
        }
    }

}
