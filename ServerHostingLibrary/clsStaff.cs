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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to serach for
            DB.AddParameter("@StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count ==1 )
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mStaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffStartDate"]);
                mStaffRole = Convert.ToString(DB.DataTable.Rows[0]["StaffRole"]);
                mEmploymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["EmploymentStatus"]);

                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            

        }

        public string Valid(string staffNo,
                            string staffName,
                            string staffRole,
                            string staffDOB,
                            string staffStartDate)
            ///this function accepts 5 parameteres 
            ///the function returns a string containing any error messafe
            ///if no errors found then a blank string is returned
        {
            String Error = "";
            DateTime DateTemp;
            DateTime DateTemp2;
            if (staffNo.Length == 0)
            {
                Error = Error + "The staff number may not be blank: "; 
            }
            //if the staff no is greater than 6 
            if (staffNo.Length > 6)
            {
                Error = Error + "Has to be less than 6 chararcters";
            }
            if (staffName.Length == 0)
            {
                Error = Error + "The name cannot be blank";

            }
            if (staffName.Length > 50)
            {
                Error = Error + "Name too long";

            }
            if (staffRole.Length == 0)
            {
                Error = Error + "Role cannot be blank";
            }

            if (staffRole.Length > 50)
            {
                Error = Error + "role too long";
            }
            try
            {
                DateTemp = Convert.ToDateTime(staffStartDate);
               
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "Invalid format";
            }
            return Error;

        }
    }
}
