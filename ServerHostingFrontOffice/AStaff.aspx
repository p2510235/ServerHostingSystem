<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Staff Number<asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
            <asp:Button ID="Find" runat="server" Text="Find" Height="21px" />
            <br />
            <br />
            Name<asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        </div>
        <p>
            Date of Birth<asp:TextBox ID="txtStaffDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            Start Date<asp:TextBox ID="txtStaffStartDate" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            Role<asp:TextBox ID="txtStaffRole" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            Employment Status<asp:CheckBox ID="Active" runat="server" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
