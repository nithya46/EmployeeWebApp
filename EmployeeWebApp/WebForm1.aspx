<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Employee Code:&nbsp;&nbsp;
        <asp:TextBox ID="txtECode" runat="server"></asp:TextBox>
        <br />
        Employee Name:&nbsp;
        <asp:TextBox ID="txtEName" runat="server"></asp:TextBox>
        <br />
        Employee Salary:&nbsp;
        <asp:TextBox ID="txtESal" runat="server"></asp:TextBox>
        <br />
        Department Id:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnAdd" runat="server" Text="Add Employee" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnDel" runat="server" Text="Delete Employee" />
        <br />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
