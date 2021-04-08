<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="Proje.Web.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:baglanti %>" SelectCommand="SELECT * FROM [Bilet]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
