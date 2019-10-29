<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="main.ui.login.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Đăng kí</title>

    <!--Basic Styles-->
    <link href="../../assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../assets/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../assets/css/weather-icons.min.css" rel="stylesheet" />

    <!--Fonts-->
    <%--<link href="http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,400,600,700,300" rel="stylesheet" />--%>

    <!--Beyond styles-->
    <link href="../../assets/css/beyond.min.css" rel="stylesheet" />
    <link href="../../assets/css/demo.min.css" rel="stylesheet" />
    <link href="../../assets/css/typicons.min.css" rel="stylesheet" />
    <link href="../../assets/css/animate.min.css" rel="stylesheet" />

    <!--Page Related styles-->
    <link href="../../assets/css/datatable.min.css" rel="stylesheet" />

    <!--Skin Script: Place this script in head to load scripts for skins and rtl support-->
    <script src="../../assets/js/skins.min.js"></script>
</head>
<body>
    <div class="login-container animated fadeInDown">
        <form method="POST" class="form-horizontal" runat="server" enctype="multipart/form-data" onsubmit="return submitForm();">
            <div class="loginbox bg-white">
                <div class="loginbox-title">Tạo tài khoản</div>
                <div class="loginbox-or">
                    <div class="or-line"></div>
                    <div class="or">-----</div>
                </div>
                <div class="loginbox-textbox">
                    <asp:Label ID="lblThongbao" runat="server" Text=""></asp:Label>
                </div>
                <div class="loginbox-textbox">
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email" required="required"></asp:TextBox>
                </div>
                <div class="loginbox-textbox">
                    <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" runat="server" placeholder="Password" required="required"></asp:TextBox>
                </div>
                <div class="loginbox-textbox">
                    <asp:TextBox ID="txtRepass" TextMode="Password" CssClass="form-control" runat="server" placeholder=" Repeat Password" required="required"></asp:TextBox>
                </div>
                <div class="loginbox-submit">
                    <asp:Button ID="btnLogin" class="btn btn-primary btn-block" runat="server" Text="Đăng kí" OnClick="btnLogin_Click" />

                </div>
            </div>
            </form>
    </div>
    <script type="text/javascript">
        var email = document.getElementById("<%= txtEmail.ClientID %>");
        var mk = document.getElementById("<%= txtPassword.ClientID %>");
        var mk2 = document.getElementById("<%= txtRepass.ClientID %>");
       

        function submitForm() {
            if (validateF()) {
                return true;
            }
            else {
                return false;
            }
        }

        function validateF() {
            if (mk.value != mk2.value) {
                alert("Mật khẩu và mật khẩu xác nhận không giống nhau!");
                return false;
            }

            
            return true;
        }

       
    </script>
    <!--Basic Scripts-->
    <script src="../../assets/js/jquery.min.js"></script>
    <script src="../../assets/js/bootstrap.min.js"></script>
    <script src="../../assets/js/slimscroll/jquery.slimscroll.min.js"></script>

    <!--Beyond Scripts-->
    <script src="../../assets/js/beyond.js"></script>
</body>
</html>
