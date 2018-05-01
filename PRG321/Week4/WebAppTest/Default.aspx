<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
    
    </div>
    &nbsp;<asp:Label ID="lblShopping" runat="server" BackColor="White" BorderColor="Black" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="Black" Text="Add Items to your Shopping List:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="m_tbOne" runat="server"></asp:TextBox>
        <asp:Button ID="m_btnOne" runat="server" BackColor="Black" BorderColor="#000066" BorderStyle="Groove" Font-Bold="True" Font-Size="Small" ForeColor="White" OnClick="m_btnOne_Click" Text="Add" Width="68px" />
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
