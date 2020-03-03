using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Write(AnCustomer.CustomerNo);
    }
}