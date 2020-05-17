using System;
using System.Collections.Generic;
using System.Linq;
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
}