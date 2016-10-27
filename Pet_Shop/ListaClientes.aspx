<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ListaClientes.aspx.cs" Inherits="ListaClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gridListaClientes" runat="server" AllowPaging="True" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" Height="300px" PageSize="5" Width="1354px" AutoGenerateColumns="False" CellSpacing="1" GridLines="None" DataSourceID="SqlDataSource2" DataKeyNames="id">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" >
                </asp:BoundField>
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" >
                </asp:BoundField>
                <asp:BoundField DataField="endereco" HeaderText="endereco" SortExpression="endereco" >
                </asp:BoundField>
                <asp:BoundField DataField="cpf" HeaderText="cpf" SortExpression="cpf" >
                </asp:BoundField>
                <asp:BoundField DataField="cidade" HeaderText="cidade" SortExpression="cidade" >
                </asp:BoundField>
                <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" >
                </asp:BoundField>
                <asp:BoundField DataField="cep" HeaderText="cep" SortExpression="cep" >
                </asp:BoundField>
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" >
                </asp:BoundField>
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
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PetShopConnectionString2 %>" DeleteCommand="DELETE FROM [Cadastro_Clientes] WHERE [id] = @id" InsertCommand="INSERT INTO [Cadastro_Clientes] ([nome], [endereco], [cpf], [cidade], [estado], [cep], [email]) VALUES (@nome, @endereco, @cpf, @cidade, @estado, @cep, @email)" SelectCommand="SELECT * FROM [Cadastro_Clientes]" UpdateCommand="UPDATE [Cadastro_Clientes] SET [nome] = @nome, [endereco] = @endereco, [cpf] = @cpf, [cidade] = @cidade, [estado] = @estado, [cep] = @cep, [email] = @email WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="nome" Type="String" />
            <asp:Parameter Name="endereco" Type="String" />
            <asp:Parameter Name="cpf" Type="Int32" />
            <asp:Parameter Name="cidade" Type="String" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="cep" Type="Int32" />
            <asp:Parameter Name="email" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nome" Type="String" />
            <asp:Parameter Name="endereco" Type="String" />
            <asp:Parameter Name="cpf" Type="Int32" />
            <asp:Parameter Name="cidade" Type="String" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="cep" Type="Int32" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PETSHOPConnectionString %>" SelectCommand="SELECT * FROM [Cadastro_Clientes]"></asp:SqlDataSource>
    </div>
</asp:Content>

