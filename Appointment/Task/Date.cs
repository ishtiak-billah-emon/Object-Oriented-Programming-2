using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Date
    {
        private int _dd;
        private int _mm;
        private int _yy;

        public Date() { }
        public Date(int dd = 1, int mm = 1, int yy = 2017) {
            this._dd = dd;
            this._mm = mm;
            this._yy = yy;
        }

        void setDate(int dd, int mm, int yy)
        {
            this._dd = dd;
            this._mm = mm;
            this._yy = yy;

        }

        public int DD
        {
            get
            {
                return _dd;
            }
        }
        public int MM
        {
            get
            {
                return _mm;
            }
        }
               
        public int YY
        {
            get
            {
                return _yy;
            }
        }

    }


}
