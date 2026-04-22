<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="drs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	name :<br />
			<asp:TextBox ID="txtid" runat="server" OnTextChanged="txtid_TextChanged"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtid" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
			<br />
			password :</div>
    	<asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
			<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtid" ControlToValidate="txtpwd" ErrorMessage="NAME and PWD not match"></asp:CompareValidator>
		<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtpwd" ErrorMessage="enter Strong pwd " ValidationExpression=".*@.*\d.*"></asp:RegularExpressionValidator>
    	<p>
			<asp:Button ID="Button1" runat="server" OnClick="Page_Load" Text="Submit" />
		</p>
    </form>
</body>
</html>
