using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHostingLibrary
{
    public class clsCustomer
    {
        public string txtno;
        public int CustomerNo { get; set; }
        private Int32 mCustomerNo;

        public Int32 CustomerNO
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }

        }

        private DateTime mDateAdded;

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }

        }
        private string mName;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }

        }
        private string mPostCode;

        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }

        }
        private string mPhoneNumber;

        public string PPhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }

        }
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }

        }
        public bool Find(int CustomerNo)
        {
            mPhoneNumber = "07946274531";
            mName = "Sam";
            mPostCode = "NG31 8RL";
            mCustomerNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mActive = true;
            return true;
        }
    }
}
 