<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ManageDocuments.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title>Đăng nhập</title>
    <link href="Content/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />

   
</head>
<body class="gray-bg">
    <div class="middle-box text-center loginscreen animated fadeInDown">
        <div>
            <div>
                <h1 class="logo-name" style="margin-left: -40px;">VTĐT</h1>
            </div>
            <h3>Đăng nhập hệ thống</h3>
            <p>Quản lý nhà hàng</p>
            <form class="m-t" role="form" runat="server">
                <div class="form-group">
                    <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPass" TextMode="Password" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
                </div>
                <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary block full-width m-b" Text="Đăng nhập" OnClick="btnLogin_Click" />
            </form>
        </div>
    </div>
    <script src="Content/assets/js/jquery-3.1.1.min.js"></script>
    <script src="Content/assets/js/bootstrap.min.js"></script>
    <script src="Content/assets/js/plugins/metisMenu/jquery.metisMenu.js"></script>
    <script src="Content/assets/js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

  </body>
</html>
