<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cadastroProdutos.aspx.cs" Inherits="cadastroProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="tabelaT">
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="ID: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtId" runat="server" Width="53px" Enabled="False"></asp:TextBox></td           
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Descrição: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDescricao" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Quantidade: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtQuantidade" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Valor: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtValor" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>

        </tr>    
         <tr>
            <td>
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" Width="55px" />
            </td>
            <td>
                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" Width="70px" />
                <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" Width="70px" />
                <asp:Button ID="btnRemover" runat="server" Text="Remover" OnClick="btnRemover_Click" Width="70px" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="70px" OnClick="btnCancelar_Click" />
            </td>

         </tr>
    </table>
    <div style="width: 100%; overflow: auto;">
        <asp:GridView ID="gridProduto" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" Height="293px" PageSize="5" Width="100%" AutoGenerateColumns="False" OnPageIndexChanging="gridProduto_PageIndexChanging" OnRowCommand="gridProduto_RowCommand" CellSpacing="2" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="descricao" HeaderText="DESCRIÇÃO" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="quantidade" HeaderText="QUANTIDADE" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="valor" HeaderText="VALOR" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Selecionar" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:ButtonField>
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
        <div>
            <asp:GridView ID="gridprodutos" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" />
                    <asp:BoundField DataField="descricao" HeaderText="descricao" />
                    <asp:BoundField DataField="quantidade" HeaderText="quantidade" />
                    <asp:BoundField DataField="valor" HeaderText="valor" />
                </Columns>
            </asp:GridView>
       
</asp:Content>

