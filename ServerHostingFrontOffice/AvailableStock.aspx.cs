using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class AvailableStock : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {
    }

   



    protected void submit_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AvailableStock = new clsStock();
        //capture the server description
        AvailableStock.ServerDesc = txtServerDesc.Text;
        //capture the server type
        AvailableStock.ServerType = txtServerType.Text;
        //capture the date added
        AvailableStock.ServerDateAdded =Convert.ToDateTime( txtServerDateAdded.Text);
        //capture the server price
        AvailableStock.ServerPrice = txtServerPrice.Text;
        //store the address in the session object
        Session["AvailableStock"] = AvailableStock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}