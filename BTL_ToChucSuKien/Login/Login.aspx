<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BTL_ToChucSuKien.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link href="style.css" rel="stylesheet" />
    <!------ Include the above in your HEAD tag ---------->

    <script src="http://mymaplist.com/js/vendor/TweenLite.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row vertical-offset-100">
                <div class="col-md-4 col-md-offset-4">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h1 class="panel-title">Đăng nhập</h1>
                        </div>
                        <div class="panel-body">
                                <fieldset>
                                    <div class="form-group">
                                        <label>Tên đăng nhập</label>
                                        <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Mật khẩu</label>
                                        <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <asp:Button ID="txtLogin" Text="Đăng nhập" runat="server" OnClick="txtLogin_Click"/>
                                    
                                </fieldset>
                            <a href="../Web/Home.aspx">Về trang chủ</a>
                            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
