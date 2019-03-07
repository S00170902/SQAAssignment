<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQAAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <asp:RadioButton ID="male" runat="server" GroupName="gender" Text="Male" OnCheckedChanged="rb_CheckedChanged" />
            <asp:RadioButton ID="female" runat="server" GroupName="gender" Text="Female" OnCheckedChanged="rb_CheckedChanged" />
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
            <asp:Label ID="prem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
