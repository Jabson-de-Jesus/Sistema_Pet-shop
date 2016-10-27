<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListaProdutos.aspx.cs" Inherits="PRODUTOS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">    
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:GridView ID="gridListaProdutos" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" Height="299px" PageSize="5" Width="100%" AutoGenerateColumns="False" CellSpacing="2" ForeColor="Black" DataSourceID="SqlDataSource1" DataKeyNames="id">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" >
                </asp:BoundField>
                <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" >
                </asp:BoundField>
                <asp:BoundField DataField="quantidade" HeaderText="quantidade" SortExpression="quantidade" >
                </asp:BoundField>
                <asp:BoundField DataField="valor" HeaderText="valor" SortExpression="valor" >
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    <p>
        <asp:Button ID="btestoque" runat="server" Text="Estoque" OnClick="btestoque_Click" Width="110px" />

    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PetShopConnectionString2 %>" SelectCommand="SELECT * FROM [Cadastro_Produto]"></asp:SqlDataSource>
    </div>
</asp:Content>


