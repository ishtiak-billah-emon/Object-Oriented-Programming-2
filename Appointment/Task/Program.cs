using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date d1 = new Date(1, 3, 2015);
          //  Date d2 = new Date(2, 6, 2015);

            Date[] d = new Date[2];
            Date[] nextDate = new Date[2];
            Appointment[] appointments = new Appointment[2];

            for (int i = 0; i < appointments.Length; i++)
            {
                Console.WriteLine(" ");
                
                Console.Write("Enter ID : ");
                string id = Console.ReadLine();

                Console.Write("Enter Name : ");
                string name = Console.ReadLine();

                Console.Write("Enter Fees: ");
                double fees = Double.Parse(Console.ReadLine());

                Console.Write("Enter Visit Date: "); int dd = Int32.Parse(Console.ReadLine()); 
                Console.Write("Enter Visit Month: "); int mm = Int32.Parse(Console.ReadLine()); 
                Console.Write("Enter Visit Year: "); int yy = Int32.Parse(Console.ReadLine());

                d[i] = new Date(dd, mm, yy);

                Console.Write("Enter Next Visit Date: ");  dd = Int32.Parse(Console.ReadLine()); 
                Console.Write("Enter Next  Visit Month: ");  mm = Int32.Parse(Console.ReadLine()); 
                Console.Write("Enter Next  Visit Year: ");  yy = Int32.Parse(Console.ReadLine()); 

                nextDate[i] = new Date(dd, mm, yy);

                appointments[i] = new Appointment(id, name, fees, d[i], nextDate[i]);


            }

            for (int i = 0; i < appointments.Length; i++)
            {
                appointments[i].displayAppt();
            }

            Console.WriteLine("Appointment ID: ");
            string appId = Console.ReadLine();

            int j= 0;
            for ( j = 0; j < appointments.Length; j++) 
            {
                appointments[j].displayAppt(appId);
            }

            if(j == appointments.Length)
            {
                Console.WriteLine("Appointment ID not found");
            }


            Console.ReadKey();

        }
    }
}
