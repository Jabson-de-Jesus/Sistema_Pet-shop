<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="cadastroClientes.aspx.cs" Inherits="cadastroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="tabelaT"> 
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="ID: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtId" runat="server" Width="53px" Enabled="False"></asp:TextBox></td           
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nome: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNome" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Endereço: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEndereco" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="CPF: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCPF" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Cidade: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCidade" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Estado: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEstado" runat="server" Width="100px" Enabled="False"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="CEP: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCEP" runat="server" Width="100px" Enabled="False"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Email: " CssClass="fonteLetras"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="245px" Enabled="False"></asp:TextBox></td>

        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" Width="59px" />
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
        <asp:GridView ID="gridCliente" runat="server" AllowPaging="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Height="291px" PageSize="5" Width="1354px" AutoGenerateColumns="False" OnPageIndexChanging="gridCliente_PageIndexChanging" OnRowCommand="gridCliente_RowCommand" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="nome" HeaderText="NOME" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="endereco" HeaderText="ENDEREÇO" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="cpf" HeaderText="CPF" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="cidade" HeaderText="CIDADE" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="estado" HeaderText="ESTADO" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="cep" HeaderText="CEP" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="email" HeaderText="EMAIL" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Selecionar" >
                <ItemStyle HorizontalAlign="Center" />
                </asp:ButtonField>
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle ForeColor="Black" BackColor="#DEDFDE" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </div>
</asp:Content>

