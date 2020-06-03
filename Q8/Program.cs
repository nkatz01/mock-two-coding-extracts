using System;
using System.Timers;
//using System.Windows.Forms.Timer;
namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Sensor seneor = new Sensor();
             seneor.Monitor(1,10)  ;
               Console.ReadLine();
            //Console.WriteLine(what);
            
            Sensor.aTimer.Stop();
            Sensor.aTimer.Dispose();
        }

    }


    public class Sensor
    {

        public static System.Timers.Timer aTimer;
        public double ReadTemperature()//Object source, ElapsedEventArgs e
        {
            if (Read() == -300)
                throw new Exception();
            else
            {
             //   Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                //          e.SignalTime);
                 return Read();
            }
        }

        public double Read()
        {
            return -300;
            //  throw new NotImplementedException();
        }
        public void Monitor(double low, double high)
        {
             
              aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += delegate
            {
               int seconds = 0 ; 
                double n = Read();
                   Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",  DateTime.Now);
                if (n != -300)
                {
                    seconds = 0;

                    if (n > high || n < low)
                    {
                        Console.Error.WriteLine("Temp is out of range");
                    }
                }

                else if (n == -300)
                {
                    seconds++;
                }

                if (seconds>60)
                    Console.Error.WriteLine("Sensor not responsive");

            };
                //(sender, e) => ReadTemperature(sender, e) ;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
           



            //System.Timers.Timer tmr = new System.Timers.Timer();
            //tmr.Elapsed += (sender, args) => ReadTemperature();
            //tmr.AutoReset = true;
            //tmr.Interval = 1000;
            //tmr.Start();



            //var startTimeSpan = TimeSpan.Zero;  //https://stackoverflow.com/questions/13019433/calling-a-method-every-x-minutes
            //var periodTimeSpan = TimeSpan.FromSeconds(1);

            //var timer = new System.Threading.Timer((e) =>
            //{
            //    ReadTemperature();
            //    Console.WriteLine(DateTime.Now);
            //}, null, startTimeSpan, periodTimeSpan);


        }


    }
}