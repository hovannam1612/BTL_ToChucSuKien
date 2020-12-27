<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="QuanLyBinhLuan.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Quản lý bình luận
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Danh sách bình luận</h1>
    <asp:GridView ID="dgvBinhLuan" AllowPaging="True" PageSize="10" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1000px"  HorizontalAlign="Center" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
             <asp:BoundField HeaderText="ID Bình Luận" DataField="idbinhluan" />
            <asp:BoundField HeaderText="Nội dung" DataField="noidung" />
            <asp:BoundField HeaderText="ID Tài khoản" DataField="idtaikhoan" />
            <asp:BoundField HeaderText="ID Dịch vụ" DataField="iddichvu" />
             <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button runat="server" ID="btnXoa" Text="Xóa"
                        CommandArgument='<%#Bind("idbinhluan") %>' CommandName="xoa" OnCommand="Xoa_Click"
                        OnClientClick="return confirm('Bạn có muốn xóa không?')" />
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
