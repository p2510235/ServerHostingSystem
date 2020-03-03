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
        <asp:Label ID="Label1" runat="server" Text="CustomerNo"></asp:Label>
        <asp:TextBox ID="txtno" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
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
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Yes" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="No" />
        </p>
        <asp:Button ID="btnok" runat="server" Text="Ok" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
