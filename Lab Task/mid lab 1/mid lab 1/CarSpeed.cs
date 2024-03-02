using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_lab_1
{
    class CarSpeed
    {
        private float _acceleration;
        private string _engine_number;
        private bool start;
        private float _time;
        private float _velocity;

        public CarSpeed(float acc,string engine_num,bool s)
        {
            this._acceleration = acc;
            this._engine_number = engine_num;
            this.start = s;

           // Console.WriteLine("Car's acceleration is : "+_acceleration);

           
        }

        public void start_car()
        {
            start = true;
            Console.WriteLine("Car started successfully");
        }
        public void stop_car()
        {
            start = false;
            Console.WriteLine("Car stopped successfully");
        }

        public void set_acceleration(float ac)
        {
          
            this._acceleration = ac;
        }

        public float Acceleration
        {
            get
            {
                return this.Acceleration;
            }
        }

        public void set_engine_number(string engine_num)
        {
           
            this._engine_number = engine_num;
        }
        public string Engine_number
        {
            get
            {
                return this.Engine_number;
            }
        }

        public float Time
        {
            get
            {
                return this.Time;
            }
            set
            {
                this._time = value;
            }
        }

        public float get_velocity()
        {
            if (start == true)
            {
                _velocity = _acceleration * _time;
                return _velocity;
              
            }
            else
            {
                Console.WriteLine("start the car first");
            }

            return -1;
            //_velocity = _acceleration * _time;
            //  return _velocity;




        }

        public void showDetails()
        {
            Console.WriteLine("Car's acceleration is: "+_acceleration);
            Console.WriteLine("Start car successfully");

  
            Console.WriteLine("Velocity of the car after "+_time+" seconds is "+ get_velocity());
            Console.WriteLine("Car stopped successfully");
            //Console.WriteLine("the time is :"+_time);
        }
        public CarSpeed()
        {

        }



    }
}
