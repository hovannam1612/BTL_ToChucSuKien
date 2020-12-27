<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ThemDichVu.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Thêm dịch vụ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Thêm dịch vụ</h1>
    
    <asp:Table runat="server" Width="457px" CellPadding="10">
        <asp:TableRow>
            <asp:TableCell>Tiêu đề</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtTieuDe" Width="500"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Ảnh</asp:TableCell>
            <asp:TableCell>
                <img id="blah" src="#" alt="Preview" width="200" style="visibility: hidden;"/>
                <asp:FileUpload ID="fileUpload" runat="server" CssClass="fileupload" onchange="readURL(this)"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Mô tả ngắn</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtMoTaNgan" TextMode="MultiLine" Width="500"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Nội dung</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtNoiDung" runat="server" TextMode="MultiLine" Width="500"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Giá</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtGia" runat="server" Width="500"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Danh mục</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlDanhMuc" runat="server" Width="300"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Phương tiện</asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlPhuongTien" runat="server" Width="300"></asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button Text="Thêm" runat="server" ID="btnThem" OnClick="btnThem_Click1" />
    <asp:Button Text="Danh sách dịch vụ" runat="server" 
        PostBackUrl="~/Admin/QuanLyDichVu.aspx" ID="btnDanhSach"/>
    <br />
    <br />
    <br />
    <asp:Label Text="" ID="lblMsg" runat="server" Font-Bold="true" Font-Size="16px" ></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
    <script type="text/javascript">
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah').css('visibility', 'visible');
                    $('#blah').attr('src', e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }
        }
        $("#fileUpload").change(function () {
            readURL(this);
        });
    </script>
</asp:Content>
