using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    
        

        class Param
        {
            public string callerName;
            public Param(string s)
            {
                callerName = s;
            }
        }
        class ThreadTester
        {
            string myName;
            public ThreadTester(string s)
            {
                myName = s;
            }
            public static void GlobalWorker()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Global worker {0}", i);
                    Thread.Sleep(2000);
                }
                Console.WriteLine("Global worker - done");
            }
            public void ObjectWorker()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("I'm {0} - repeating {1}", myName, i);
                    Thread.Sleep(2000);
                }
                Console.WriteLine("I'm {0} - done", myName);
            }
        }

        public class MainClass
        {
            public MainClass()
            {
            }

            // simplest threading method
            public static void Simplest()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Simplest worker {0}", i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Simplest worker - done");
            }
            public static int Main(string[] args)
            {
                // simplest way
                Console.WriteLine("Simple thread - create");
                ThreadStart simplest = new ThreadStart(Simplest); //static Simplest work 1 s
                Thread thread1 = new Thread(simplest);
                thread1.Start();
                Console.WriteLine("Simple thread - started");

                // simple way with static class method
                Console.WriteLine("Thread on static method - create");
                ThreadStart entry2 = new ThreadStart(ThreadTester.GlobalWorker);  //global 2
                Thread thread2 = new Thread(entry2);
                thread2.Start();
                Console.WriteLine("Thread on static method - started");

                // thread on object
                Console.WriteLine("Thread on objects - create");
                ThreadTester testObject1 = new ThreadTester("First"); //I'am  repat 2
                ThreadTester testObject2 = new ThreadTester("Second");
                ThreadStart entry3 = new ThreadStart(testObject1.ObjectWorker);
                ThreadStart entry4 = new ThreadStart(testObject2.ObjectWorker);
                Thread thread3 = new Thread(entry3);
                Thread thread4 = new Thread(entry4);
                thread3.Start();
                thread4.Start();
                Console.WriteLine("Thread on objects - started");
            Console.ReadLine();
            return 0;
            }
        }
}
