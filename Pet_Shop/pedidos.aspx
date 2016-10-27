<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pedidos.aspx.cs" Inherits="Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: 73px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table class="tabelaT"> 
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="ID: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtId" runat="server" Width="53px" Enabled="False"></asp:TextBox></td>           
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="ClienteID: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtClienteID" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="ProdutoID: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtProdutoID" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" Text="Quantidade: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtQuantidade" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>       
            <td>
                <asp:Label ID="Label4" runat="server" Text="Valor: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtValor" runat="server" Width="150px" Enabled="False"></asp:TextBox></td>             
        </tr>   
 
         <tr>
            <td>
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" Width="56px" />
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
        <asp:GridView ID="gridPedidos" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="1355px" AllowPaging="True" OnPageIndexChanging="gridPedidos_PageIndexChanging" OnRowCommand="gridPedidos_RowCommand" Height="299px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="clienteid" HeaderText="ClienteID">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="produtoid" HeaderText="ProdutoID">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="quantidade" HeaderText="Quantidade">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="valor" HeaderText="Valor">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:ButtonField Text="Selecionar" ButtonType="Button" CommandName="select">
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:ButtonField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        </asp:Content>


