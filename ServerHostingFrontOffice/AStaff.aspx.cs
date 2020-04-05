using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class AStaff :  System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the sesssion object
        AStaff = (clsStaff)Session["AStaff"];
        //display the house number for this entry
        Response.Write(AStaff.StaffNo);
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff number
        AStaff.StaffNo = txtStaffNo.Text;
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("AStaffViewer.aspx");
    }
}