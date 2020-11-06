<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="form-group">
                <div class="form-label">
                    <asp:Label ID="lblUsername" runat="server" Text="Username" AssociatedControlID="txtUsername"></asp:Label>
                </div>
                <div class="form-container">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username can't be blank" ForeColor="Red" />
                </div>
            </div>

            <div class="form-group">
                <div class="form-label">
                    <asp:Label ID="lblPassword" runat="server" Text="Password" AssociatedControlID="txtPassword"></asp:Label>
                </div>
                <div class="form-container">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
                    <asp:RequiredFieldValidator ID="reqPassword" runat="server" ErrorMessage="Password can't be blank" ControlToValidate="txtPassword" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="button-container">
                <asp:Button ID="btnLogin" runat="server" CssClass="btn" Text="Login" OnClick="btnLogin_Click" />
                <div>
                    <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
