﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServerHostingLibrary;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AvailableStock = new clsStock();
        //get the data from the session object
        AvailableStock = (clsStock)Session["AvailableStock"];
        //display the house number for this entry
        Response.Write(AvailableStock.ServerNo);
    }
}