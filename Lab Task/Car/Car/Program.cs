using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
           /* CarSpeed c = new CarSpeed();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Detials for Car {0}", i);
                Console.Write("Enter the Engine Number: ");
                string engine_number = Console.ReadLine();
                c.set_engine_number(engine_number);
                Console.Write("Enter the acceleration: ");
                float acceleration = float.Parse(Console.ReadLine());
                // c.Acceleration = acceleration;
                c.set_acceleration(acceleration);
                Console.Write("Enter the time: ");
                float time = float.Parse(Console.ReadLine());
                c.set_time(time);
                c.start_car();
                c.showDetails();
                c.stop_car();

            }
            */

            CarSpeed[] c = new CarSpeed[2];
            for(int i = 0; i < 2; i++)
            {
                c[i] = new CarSpeed();

                Console.WriteLine(" ");
                Console.WriteLine("Detials for Car {0}", i);
                Console.Write("Enter the Engine Number: ");
                string engine_number = Console.ReadLine();
                c[i].set_engine_number(engine_number);
                Console.Write("Enter the acceleration: ");
                float acceleration = float.Parse(Console.ReadLine());
                // c.Acceleration = acceleration;
                c[i].set_acceleration(acceleration);
                Console.Write("Enter the time: ");
                float time = float.Parse(Console.ReadLine());
                c[i].set_time(time);
                c[i].start_car();
                c[i].showDetails();
                c[i].stop_car();
            }



            Console.ReadKey();

        }
    }
}