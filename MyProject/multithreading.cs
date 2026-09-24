using System;
namespace MyProject
{
    class Program
    {
        // Thread = an execution path of program  we can use multiples threads to
        //        different tasks of our program at the same time Current thread 
        //        thread using System.threading 
        static void Main (String[] args)
        {
              Thread mainThread = Thread.CurrentThread ;
              mainThread.Name = "Main Thread" ;
              
              // Console.WriteLine(mainThread.Name);
              // Thread thread1 = new Thread(CountDown);      /
              // Thread thread2 = new Thread(CountUp);

              Thread thread1 = new Thread(() => CountDown("Time #1"));
              Thread thread2 = new Thread(() => CountUp("Time #1"));
              thread1.Start();
              thread2.Start();
              Console.WriteLine(mainThread.Name + "is complete!");
              // CountDown();
              // CountUp();
        }
        public static void CountDown(String name)
        {
              for (int i = 10 ; i>= 0 ; i--)
              {
                    Console.WriteLine("Timer #1 :" + i + " seconds");
                    Thread.Sleep(1000);
              }
              Console.WriteLine("Timer #1 is complete !");
        }
         public static void CountUp(String name)
        {
              for (int i = 0 ; i <= 10 ; i++)
              {
                    Console.WriteLine("Timer #2 :" + i + " seconds");
                    Thread.Sleep(1000);
              }
              Console.WriteLine("Timer #2 is complete !");
        }
    }
}