using System;
using System.Linq.Expressions;
using System.Timers;
 
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
        public double ReadTemperature() 
        {
            if (Read() == -300.0)
                throw new Exception();
            else
            {
           
                 return Read();
            }
        }

        public double Read()
        {
       
             throw new NotImplementedException();
        }
        public void Monitor(double low, double high)
        {
            int seconds = 0;

            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += delegate
            {
                try {
                double n = Read();
                    if (n != -300.0)
                    {
                        seconds = 0;

                        if (n > high || n < low)
                        {
                            Console.Error.WriteLine("Temp is out of range");
                        }
                    }

                }

                catch (Exception e) {

               
                    seconds++;
                }
                   Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",  DateTime.Now);

                if (seconds>60)
                    Console.Error.WriteLine("Sensor not responsive");

            };
                
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
           


 


        }


    }
}