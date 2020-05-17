using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHostingLibrary
{
    public class clsStaff
    {
        private DateTime mStaffStartDate;
        private int mStaffNo;
        private string mStaffName;
        private DateTime mStaffDOB;
        private string mStaffRole;
        private bool mEmploymentStatus;

        public int StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
        }

        public string StaffName
        {
            get
            {//this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the property
                mStaffName = value;
            }
        }

        public DateTime StaffDOB
        {
            get
            {
                return mStaffDOB;
            }
            set
            {
                mStaffDOB = value;
            }
        }
        public DateTime StaffStartDate
        {
            get
            {
                return mStaffStartDate;
            }
            set
            {
                mStaffStartDate = value;
            }
        }


            
        public string StaffRole
        {
            get
            {
                return mStaffRole;
            }
            set
            {
                mStaffRole = value;
            }
        }

        public bool EmploymentStatus
        {
            get
            {
                return mEmploymentStatus;
            }
            set
            {
                mEmploymentStatus = value;
            }
        }

        public bool Find(int StaffNo)
        {
            //set the private data memebrs to the test data value
            mStaffNo = 1;
            mStaffStartDate = DateTime.Now.Date;
            mStaffDOB = Convert.ToDateTime(1998, 11, 14);
            mStaffName = "Joe Bloggs";
            mStaffRole = "Manager";
            m

            //always return true
            return true;
        }
    }
}
