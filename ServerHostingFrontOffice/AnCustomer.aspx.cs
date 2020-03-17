using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class AnCustomer : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        // clsCustomer AnCustomer = new clsCustomer();
        //  AnCustomer = (clsCustomer)Session["AnCustomer"];
        //  Response.Write(AnCustomer.CustomerNo);
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();

        AnCustomer.Name = txtname.Text;
        AnCustomer.PostCode = txtpost.Text;
        AnCustomer.PhoneNumber = txtphone.Text;
        //AnCustomer.DateAdded = txtdate.Text.ToString();

        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btn_find_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;
        CustomerNo = Convert.ToInt32(txtcustomer.Text);
        Found = AnCustomer.Find(CustomerNo);
        if (Found == true)

        {
            txtdate.Text = AnCustomer.DateAdded.ToString();
            txtname.Text = AnCustomer.Name;
            txtpost.Text = AnCustomer.PostCode;
            txtphone.Text = AnCustomer.PhoneNumber;

        }
    }
}
