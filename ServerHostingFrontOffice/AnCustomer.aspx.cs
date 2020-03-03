using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class AnCustomer : System.Web.UI.Page
{
    private int txtno;

    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Write(AnCustomer.CustomerNo);
    }
    protected void btnok_click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer.CustomerNo = txtno;
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        Response.Redirect("CustomerViewer.aspx");
    }
}