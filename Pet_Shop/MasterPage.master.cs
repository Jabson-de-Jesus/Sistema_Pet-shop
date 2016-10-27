using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cadastroClientes.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("cadastroProdutos.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("pedidos.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListaProdutos.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListaClientes.aspx");
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
