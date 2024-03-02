using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class CarSpeed
    {
        private float _acceleration;
        private string _engineNumber;
        private bool _start;
        private float _time;

        /*
                public  float Acceleration
                {
                    set {
                        _acceleration = value; 
                    }
                    get
                    {
                        return _acceleration;
                    }
                }

                public string EngineNumber
                {
                    set { 
                        _engineNumber = value; 
                    }
                    get { 
                        return _engineNumber; 
                    }
                }


                */

        public CarSpeed() { }
        public CarSpeed(float _acceleration, string _engineNumber, bool _start = false)
        {
            this._acceleration = _acceleration;
            this._engineNumber = _engineNumber;
            this._start = _start;
        }



        public void start_car()
        {
            _start = true;
            //Console.WriteLine("Car Started Successfully");
        }
        public void stop_car()
        {
            _start = false;
            Console.WriteLine("Car stopped Successfully");
        }

        public void set_acceleration(float acceleration)
        {
            this._acceleration = acceleration;

        }

        public void set_engine_number(string engineNumber)
        {
            this._engineNumber = engineNumber;
        }

        public void set_time(float time)
        {

            this._time = time;
        }

        public float get_velocity()
        {
            if (_start == false)
            {
                //  Console.WriteLine("start the car first then retrieve velocity after acclereation.");
                return 0;
            }
            else
            {
                return _acceleration * _time;
            }
        }

        public void showDetails()
        {
            Console.WriteLine("Engine number of a car set to {0}", _engineNumber);
            Console.WriteLine("Car's acceleration is {0}", _acceleration.ToString("F3"));

            if (get_velocity() == 0)
            {
                Console.WriteLine("start the car first then retrieve velocity after acclereation.");
            }
            else
            {
                Console.WriteLine("Car Started Successfully");
                Console.WriteLine("Velocity of the car after {0}  seconds is {1}  ", _time.ToString("F2"), get_velocity().ToString("F2"));
            }

        }

    }
}