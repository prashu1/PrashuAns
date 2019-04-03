<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADOConnectedTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            AddressID&nbsp;
            <asp:TextBox ID="AddressID" runat="server"></asp:TextBox>
            <br />
            <br />
            FirstName<asp:TextBox ID="FName" runat="server"></asp:TextBox>
            <br />
            <br />
            LastName<asp:TextBox ID="LName" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            EMail&nbsp;&nbsp;
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone&nbsp;
            <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>
