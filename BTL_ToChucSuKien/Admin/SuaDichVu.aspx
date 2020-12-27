<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SuaDichVu.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Sửa dịch vụ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Sửa dịch vụ</h1>
    <asp:Table runat="server" Width="700px" CellPadding="10" HorizontalAlign="Center">
        <asp:TableRow>
            <asp:TableCell>ID Dịch vụ</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtIDDichVu" Width="500" Enabled="false"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Tiêu đề</asp:TableCell>
            <asp:TableCell><asp:TextBox runat="server" ID="txtTieuDe" Width="500"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Ảnh</asp:TableCell>
            <asp:TableCell>
                <asp:Image runat="server" ID="img" Width="200px"/>
                <label id="lblUpload" style="visibility: hidden;">Sửa thành</label>
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
    <asp:Button Text="Sửa dịch vụ" runat="server" ID="btnSua" OnClick="btnSua_Click"/>
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
                    $('#lblUpload').css('visibility', 'visible');
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