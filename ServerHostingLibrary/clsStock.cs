using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHostingLibrary
{
    public class clsStock
    {
        public string ServerDesc;
        public string ServerType;
        public DateTime ServerDateAdded;
        public string ServerPrice;
        public bool Active;
        public string NodeLocation;
        private Int32 mServerNo;


        public Int32 ServerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mServerNo;
            }
            set
            {
                //this line of code allows data into the property
                mServerNo = value;
            }
        }
    }
}