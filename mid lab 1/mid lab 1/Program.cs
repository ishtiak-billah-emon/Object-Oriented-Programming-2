using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSpeed [] cs = new CarSpeed[3];
            for (int i = 0; i <= 3; i++)
            {
                cs[i] = new CarSpeed();


                Console.WriteLine("Details for car " + (i + 1));
                Console.Write("Enter the engine number: ");
                string engine_num = Console.ReadLine();

                Console.Write("Enter the acceleration: ");
                float ac = float.Parse(Console.ReadLine());


                Console.Write("Enter the time: ");
                float time = float.Parse(Console.ReadLine());

                cs[i].set_acceleration(ac);
                cs[i].start_car();
                //cs[i].get_velocity(ac, time);
                cs[i].Time = time;
                cs[i].showDetails();
                Console.WriteLine("\n");
            }


           


           
       
            
            Console.ReadLine();
        }
    }
}
