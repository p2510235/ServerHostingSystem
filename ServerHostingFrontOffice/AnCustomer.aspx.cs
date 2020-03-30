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

        string Name = txtname.Text;
        string phoneNumber = txtphone.Text;
        string DateAdded = txtdate.Text;
        string postcode = txtpost.Text;
        string Error = "";
        Error = AnCustomer.Valid(Name, phoneNumber, postcode, DateAdded);
        if (Error == "")
        {
            AnCustomer.Name = Name;
            AnCustomer.PhoneNumber = phoneNumber;
            AnCustomer.PostCode = postcode;
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            AnCustomer = (clsCustomer)Session["AnCustomer"];
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
     
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
