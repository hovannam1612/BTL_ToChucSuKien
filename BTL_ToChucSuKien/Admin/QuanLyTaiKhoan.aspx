<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="QuanLyTaiKhoan.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Quản lý tài khoản
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Danh Sách Tài Khoản</h1>

    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" ID="lblQuyenTruyCap">Quyền truy cập</asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="drQuyenTruyCap" runat="server" Width="100" Height="25"></asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" ID="lblTrangthai">Trạng thái</asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="drTrangThai" runat="server" Width="100" Height="25"></asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" ID="lblSoDienThoai">Số điện thoại</asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btTim" Text="Tìm kiếm" runat="server" OnClick="btTim_Click" />


    <br />

    <br />

    <asp:GridView ID="dgvTaiKhoan" AllowPaging="True" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1000px" HorizontalAlign="Center" OnPageIndexChanging="dgvTaiKhoan_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="ID Tài Khoản" DataField="idtaikhoan" />
            <asp:BoundField HeaderText="Tên đăng nhập" DataField="tendangnhap" />
            <asp:BoundField HeaderText="Mật khẩu" DataField="matkhau" />
            <asp:BoundField HeaderText="Địa chỉ" DataField="diachi" />
            <asp:BoundField HeaderText="Số điện thoại" DataField="sodienthoai" />
            <asp:BoundField HeaderText="Họ tên" DataField="hoten" />
            <asp:BoundField HeaderText="Quyền truy cập" DataField="quyentruycap" />
            <asp:BoundField HeaderText="Trạng thái" DataField="trangthai" />
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnXoa" Text="Xóa"
                        CommandArgument='<%#Bind("idtaikhoan") %>' CommandName="xoa" OnCommand="Xoa_Click"
                        OnClientClick="return confirm('Bạn có muốn xóa không?')" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnSua" Text="Sửa"
                        CommandArgument='<%#Bind("idtaikhoan") %>' CommandName="sua"
                        OnCommand="Sua_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:Label Text="" ID="lblMsg" runat="server" Font-Size="18px" Font-Bold="true"></asp:Label>
    <br />
    <br />
    <asp:Button runat="server" Text="Thêm tài khoản" PostBackUrl="~/Admin/ThemTaiKhoan.aspx" />
    <br />
    <br />
    <a href="QuanLyTaiKhoan.aspx" style="text-decoration: underline">Back</a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
