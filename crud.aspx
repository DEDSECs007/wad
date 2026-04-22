<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="drs.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        	<asp:TextBox ID="id" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="id2" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="name" runat="server" OnTextChanged="name_TextChanged"></asp:TextBox><br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>

        </div>
    	<asp:Button ID="btnupdate" runat="server" Text="update" Height="29px" OnClick="btnupdate_Click" />
		<asp:Button ID="btndelete" runat="server" Text="Delete" />
		<asp:Button ID="btnselect" runat="server" Text="Select" />
    	<asp:GridView ID="gv1" runat="server">
		</asp:GridView>
    </form>
</body>
</html>
