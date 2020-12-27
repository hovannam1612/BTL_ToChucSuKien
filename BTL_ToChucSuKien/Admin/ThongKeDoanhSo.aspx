<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ThongKeDoanhSo.aspx.cs" Inherits="BTL_ToChucSuKien.Admin.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Thống kê doanh số
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Thống kê doanh số</h1>
    <asp:GridView ID="dgvDoanhSo" AllowPaging="True" PageSize="10" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1000px"  HorizontalAlign="Center" OnPageIndexChanging="dgvDoanhSo_PageIndexChanging" OnRowDataBound="dgvDoanhSo_RowDataBound" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField HeaderText="ID dịch vụ" DataField="iddichvu"/>
            <asp:BoundField HeaderText="Tiêu đề" DataField="tieude"/>
            <asp:BoundField HeaderText="Ảnh" DataField="anh"/>
            <asp:BoundField HeaderText="Mô tả ngắn" DataField="motangan"/>
            <asp:BoundField HeaderText="Nội dung" DataField="noidung"/>
             <asp:TemplateField HeaderText="Giá">
                    <ItemTemplate>
                         
                        <asp:Label ID="lblGia" runat="server" Text='<%# Eval("Gia")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:BoundField HeaderText="ID danh mục" DataField="iddanhmuc"/>
            <asp:BoundField HeaderText="ID phương tiện" DataField="idphuongtien"/>
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
    <br />
     <Label runat="server">Tổng Doanh Thu&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </Label><asp:Label ID="lblDoanhthu" runat="server" ForeColor="Black"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" runat="server">
</asp:Content>
