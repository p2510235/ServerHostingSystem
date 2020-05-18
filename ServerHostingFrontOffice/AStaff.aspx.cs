using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class AStaff : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff name for this entry
        Response.Write(AStaff.StaffName);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance 
        clsStaff AStaff = new clsStaff();
        string StaffNo = txtStaffNo.Text;
        string StaffName = txtStaffName.Text;
        string StaffRole = txtStaffRole.Text;
        string StaffStartDate = txtStaffStartDate.Text;
        string StaffDOB = txtStaffDOB.Text;

        string Error = "";
        Error = AStaff.Valid(StaffNo, StaffName, StaffRole, StaffDOB, StaffStartDate);
        if (Error == "")
        {

        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        AStaff.StaffName = txtStaffName.Text;
        //capture the staff date of birth
        AStaff.StaffDOB = Convert.ToDateTime(txtStaffDOB.Text);
        //capture the staff start date
        AStaff.StaffStartDate = Convert.ToDateTime(txtStaffStartDate.Text);
        //capture the staff role
        AStaff.StaffRole = txtStaffRole.Text;
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create and instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffNo;
        //variable to store the result of the find operation
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find the record
        Boolean Found = AStaff.Find(StaffNo);
        if (Found == true)
        {
            txtStaffNo.Text = AStaff.StaffNo;
            txtStaffName = AStaff.StaffName;
            txtStaffRole = AStaff.StaffRole;
            txtStaffDOB = AStaff.StaffDOB; 
            txtStaffStartDate = AStaff.StaffStartDate.DateAdded.ToString();
        }
    }


}