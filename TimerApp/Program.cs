using System;
using System.Windows.Forms;

namespace TimerApp
{
    class Program
    {
        private static DateTime startedAt;

        static void Main(string[] args)
        {

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToString("HH:mm:ss"));
            //Console.WriteLine("Before loop begins\n");

            //Stopwatch sp = new Stopwatch();
            //sp.Start();
            //date = date.AddSeconds(10);

            //Console.WriteLine(date.ToString());
            //Console.WriteLine(DateTime.Now.ToString());

            //do
            //{
            //    var anotherDate = DateTime.Now.ToString("mm:ss");
            //    if (!DateTime.Now.ToString("mm:ss").Equals(anotherDate))
            //    {
            //        Console.WriteLine(anotherDate);
            //    }

            //} while (!DateTime.Now.ToString("HH:mm:ss").Equals(date.ToString("HH:mm:ss")));

            //sp.Stop();
            //Console.WriteLine("Time Elapsed .....");

            //Console.WriteLine(sp.Elapsed);



            Timer ShowElapsedTime = new Timer();
            ShowElapsedTime.Interval = 1000;     // 10 seconds
            ShowElapsedTime.Tick += ShowElapsedTime_Tick;
            ShowElapsedTime.Start();
            startedAt = DateTime.Now;

        }
         void ShowElapsedTime_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = DateTime.Now - startedAt;
            Console.WriteLine($"{ diff.Hours.ToString()}:{ diff.Minutes.ToString()}:{ diff.Seconds.ToString()}");

        }


    }
}
