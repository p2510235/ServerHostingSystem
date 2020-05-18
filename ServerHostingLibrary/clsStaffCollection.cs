using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerHostingLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member 
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.EmploymentStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmploymentStatus"]);
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.StaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStartDate"]);
                AStaff.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                
                //add the record to the private data mamber
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }

        }

        //public property for list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property 
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }



        public int Add()
        {
            //adds a new record to the database based on the values of this
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffStartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@EmploymentStatus", mThisStaff.EmploymentStatus);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSTaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@StaffStartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@EmploymentStatus", mThisStaff.EmploymentStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

    }
}
 