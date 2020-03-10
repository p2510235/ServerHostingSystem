<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AvailableStock.aspx.cs" Inherits="AvailableStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-left: 21px;
        }
        #Text2 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Server Desc&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
            <asp:TextBox ID="txtServerDesc" runat="server"></asp:TextBox>
            <br />
           Server Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtServerType" runat="server"></asp:TextBox>
            <br />
            DateAdded&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtServerDateAdded" runat="server"></asp:TextBox>
            <br />
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtServerPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            Available&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="chkboxAvailable" type="checkbox" /><br />
            <br />
            </div>
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" OnClientClick="submit_OK" Text="submit" />
        <asp:Button ID="cancel" runat="server" Text="cancel" />
    </form>
</body>
</html>
