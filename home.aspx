<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="drs.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:GridView ID="gv1" runat="server">
			</asp:GridView>
            <asp:DropDownList ID="dd1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dd"></asp:DropDownList>
            <asp:DropDownList ID="dd2" runat="server" ></asp:DropDownList>

        </div>
    </form>
</body>
</html>
