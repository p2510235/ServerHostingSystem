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

        public string PhoneNumber
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

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerNo", CustomerNo);

            DB.Execute("sproc_tblcustomer_FilterByCustomerNo");

            if (DB.Count == 1)
            {
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["Phonenumber"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }

            else
            {
                return false;

            }
        }
    }
}
