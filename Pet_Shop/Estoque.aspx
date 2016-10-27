<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Estoque.aspx.cs" Inherits="Estoque" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 835px;
        }
        .auto-style2 {
            height: 82px;
            text-align: center;
        }
        .auto-style3 {
            width: 633px;
            height: 226px;
        }
        .auto-style4 {
            font-size: large;
            margin-top: 5px;
        }
        .auto-style5 {
            text-align: center;
            height: 600px;
        }
        .auto-style6 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="0" class="auto-style1">
            <tr>
                <td class="auto-style2" style="background-color: #3366FF">
                    <img class="auto-style3" src="petshop.jpg" /></td>
            </tr>
            <tr>
                <td style="background-color: #CCCC00">
                    <div class="auto-style5">
                        <div>
                            <strong>
                                <asp:Button ID="HOME" runat="server" Text="HOME" BackColor="#99FF99" CssClass="auto-style6" OnClick="HOME_Click" Width="133px" />  <asp:Button ID="btgravar" runat="server" Text="Cadastrar " BackColor="#99FF99" CssClass="auto-style6" Width="120px" OnClick="btgravar_Click" />
                            </strong>
                        </div>
                        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style4" DataKeyField="id" DataSourceID="SqlDataSource1" GridLines="Both" HorizontalAlign="Center" Width="418px" Height="280px">
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <ItemStyle BackColor="White" ForeColor="#330099" />
                            <ItemTemplate>
                                id:
                                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id", "{0:D}") %>' />
                                <br />
                                descricao:
                                <asp:Label ID="descricaoLabel" runat="server" Text='<%# Eval("descricao") %>' />
                                <br />
                                quantidade:
                                <asp:Label ID="quantidadeLabel" runat="server" Text='<%# Eval("quantidade", "{0:D}") %>' />
                                <br />
                                valor:
                                <asp:Label ID="valorLabel" runat="server" Text='<%# Eval("valor", "{0:C}") %>' />
                                <br />
<br />
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        </asp:DataList>
                    </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PetShopConnectionString2 %>" DeleteCommand="DELETE FROM [Cadastro_Produto] WHERE [id] = @id" InsertCommand="INSERT INTO [Cadastro_Produto] ([descricao], [quantidade], [valor]) VALUES (@descricao, @quantidade, @valor)" SelectCommand="SELECT * FROM [Cadastro_Produto]" UpdateCommand="UPDATE [Cadastro_Produto] SET [descricao] = @descricao, [quantidade] = @quantidade, [valor] = @valor WHERE [id] = @id">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="descricao" Type="String" />
                            <asp:Parameter Name="quantidade" Type="Int32" />
                            <asp:Parameter Name="valor" Type="Double" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="descricao" Type="String" />
                            <asp:Parameter Name="quantidade" Type="Int32" />
                            <asp:Parameter Name="valor" Type="Double" />
                            <asp:Parameter Name="id" Type="Int32" />
                        </UpdateParameters>
                        
                    </asp:SqlDataSource>
                
                </td>
            
            </tr>
        </table>
    
    </div>

    </form>
</body>
</html>
