<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Post Code"></asp:Label>
            <asp:TextBox ID="txtpost" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="PhoneNumber"></asp:Label>
            <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="OwnServer"></asp:Label>
            <asp:CheckBox ID="ckeckyes" runat="server" Text="Yes" />
            <asp:CheckBox ID="checkno" runat="server" Text="No" />
        </p>
       <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" OnClientClick="btnok_OK" Text="OK" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" />
        <p>
            <asp:Label ID="Label8" runat="server" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txtcustomer" runat="server"></asp:TextBox>
            <asp:Button ID="btn_find" runat="server" OnClick="btn_find_Click" style="margin-top: 9px" Text="Find" />
        </p>
    </form>
</body>
</html>
