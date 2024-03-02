using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Appointment
    {
        private readonly string _NRIC;
        private string _name;
        private double _fees;
        private Date _visit;
        private Date _nextVisit;

        public Appointment()
        {

        }        
        
        public Appointment(string NRIC, string name, double fees, Date visit, Date nextVisit)
        {
            this._NRIC = NRIC;
            this._name = name;
            this._fees = fees;
            this._visit = visit;
            this._nextVisit = nextVisit;
        }

        public void setAppt(string name, double fees, Date visit,  Date nextVisit)
        {
            this._name = name;
            this._fees = fees;
            this._visit = visit;
            this._nextVisit = nextVisit;

        }
        
        public string Name
        {
            get { return this._name; }
        }         
        public Date Visit
        {
            get { return _visit; }
                    
        }            
        public Date NextVisit
        {
            get { return _nextVisit; }
                    
        }         
   

        public void displayAppt()
        {

            //  Console.WriteLine("Name: " + _name);
            //  Console.WriteLine("Fees: " + _fees);
            //   Console.WriteLine("Visit Date: " + Visit.DD + " - " + Visit.MM + " - " + Visit.YY);
                Console.WriteLine(" ");
                Console.Write("Patient Id: ");
                Console.Write(_NRIC + ",");
                Console.Write(_name + ",");

                Console.WriteLine(_fees);
                Console.WriteLine("Date of visit: " + Visit.DD + "/" + Visit.MM + "/" + Visit.YY);
                Console.WriteLine("Date of Next Visit: " + NextVisit.DD + "/" + NextVisit.MM + "/" + NextVisit.YY);
                Console.WriteLine(" ");
            
        }

        public void displayAppt(string NRTC)
        {
            if(_NRIC == NRTC)
            {
                Console.WriteLine("Match Found");
                displayAppt();
            }
        }









    }
}
