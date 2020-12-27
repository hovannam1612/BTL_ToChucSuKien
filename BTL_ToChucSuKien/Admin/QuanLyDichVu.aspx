<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="QuanLyDichVu.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Quản Lý dịch vụ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Danh sách dịch vụ</h1>
    <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTimKiem" runat="server" Width="246px" placeholder="nhập tiêu đề"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlTimKiem" runat="server" Height="25px" Width="173px" OnSelectedIndexChanged="ddlTimKiem_SelectedIndexChanged">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" Width="127px" OnClick="btnTimKiem_Click" />
    <br />
    <br />
    <br />
    <asp:GridView ID="dgvDichVu" AllowPaging="True" PageSize="10" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1000px" OnPageIndexChanging="dgvDichVu_PageIndexChanging" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="iddichvu" />
            <asp:BoundField HeaderText="Tiêu đề" DataField="tieude" />
            <asp:TemplateField HeaderText="Ảnh">
                <ItemTemplate>
                    <asp:Image ID="img" runat="server" ImageUrl='<%#"~/Images/"+Eval("anh") %>' Width="100px"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Mô tả ngắn" DataField="motangan" />
            <asp:BoundField HeaderText="Nội dung" DataField="noidung" />
            <asp:BoundField HeaderText="Giá" DataField="gia" />
            <asp:BoundField HeaderText="ID DM" DataField="iddanhmuc" />
            <asp:BoundField HeaderText="ID Phương tiện" DataField="idphuongtien" />
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnXoa" Text="Xóa"
                        CommandArgument='<%#Bind("iddichvu") %>' CommandName="xoa" OnCommand="Xoa_Click"
                        OnClientClick="return confirm('Bạn có muốn xóa không?')" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnSua" Text="Sửa"
                        CommandArgument='<%#Bind("iddichvu") %>' CommandName="sua"
                        OnCommand="Sua_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:Label Text="" ID="lblMsg" runat="server" Font-Size="18px" Font-Bold="true"></asp:Label>
    <br />
    <br />
    <div style="margin-left: 480px">
        <asp:Button runat="server" Text="Thêm dịch vụ" PostBackUrl="~/Admin/ThemDichVu.aspx" Height="37px" Width="137px" />
</div>
</asp:Content>
