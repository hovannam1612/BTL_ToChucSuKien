<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SuaTaiKhoan.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sửa tài khoản
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Sửa Tài Khoản</h1>
        <asp:Table runat="server" Width="416px" CellPadding="10">
        <asp:TableRow>
            <asp:TableCell>ID tài khoản</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtIDTaiKhoan" Width="200" Enabled="false"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>Tên đăng nhập</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtTenDangNhap" Width="200"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
       
        <asp:TableRow>
            <asp:TableCell>Mật khẩu</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtMatKhau" Width="200" ></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Địa chỉ</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtDiaChi" Width="200"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Số điện thoại</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtSoDienThoai" Width="200"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Họ tên</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtHoTen" Width="200"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Quyền truy cập</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="drQuyenTruyCap" runat="server" Width="200" ></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell>Trạng thái</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="drTrangThai" runat="server" Width="200"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button Text="Sửa Tài Khoản" runat="server" ID="btnSua" OnClick="btnSua_Click" />
    <asp:Button Text="Danh sách tài khoản" runat="server" 
        PostBackUrl="~/Admin/QuanLyTaiKhoan.aspx" ID="btnDanhSach"/>
    <br />
    <br />
    <br />
    <asp:Label Text="" ID="lblMsg" runat="server" Font-Bold="true" Font-Size="16px" ></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
