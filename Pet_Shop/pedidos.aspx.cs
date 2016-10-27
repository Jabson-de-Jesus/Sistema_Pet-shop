using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Pedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Pet_Shop.CAMADAS.DAL.Pedidos bllpedidos = new Pet_Shop.CAMADAS.DAL.Pedidos();
            gridPedidos.DataSource = bllpedidos.select();
            gridPedidos.DataBind();
        }
    }

    protected void habilitaCampos(bool status)
    {
        if (Cache["OP"].ToString() != "E")
        {
            txtId.Text = "";
            txtClienteID.Text = "";
            txtProdutoID.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        txtId.Enabled = status;
        txtClienteID.Enabled = status;
        txtProdutoID.Enabled = status;
        txtQuantidade.Enabled = status;
        txtValor.Enabled = status;

        btnInserir.Enabled = !status;
        btnEditar.Enabled = !status;
        btnGravar.Enabled = status;
        btnRemover.Enabled = !status;
        btnCancelar.Enabled = status;
    }

    protected void btnInserir_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "I";
        habilitaCampos(true);
        txtId.Text = "-1";
        txtClienteID.Focus();
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (txtId.Text != string.Empty)
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                Cache["OP"] = "E";
                habilitaCampos(true);
                txtClienteID.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado");
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Pet_Shop.CAMADAS.MODEL.Pedidos pedidos = new Pet_Shop.CAMADAS.MODEL.Pedidos();
        Pet_Shop.CAMADAS.BLL.Pedidos bllpedidos = new Pet_Shop.CAMADAS.BLL.Pedidos();

        pedidos.id = Convert.ToInt32(txtId.Text);
        pedidos.clienteid = Convert.ToInt32(txtClienteID.Text);
        pedidos.produtoid = Convert.ToInt32(txtProdutoID.Text);
        pedidos.quantidade = Convert.ToInt32(txtQuantidade.Text);
        pedidos.valor = Convert.ToInt32(txtValor.Text);
        
       // if (Cache["OP"].ToString() == "I")
                   
                bllpedidos.insert(pedidos);
          //  else if (Cache["OP"].ToString() == "E")
         //       bllpedidos.update(pedidos);

        gridPedidos.DataSource = bllpedidos.select();
        gridPedidos.DataBind();
        gridPedidos.SetPageIndex(gridPedidos.PageCount);
        Cache["OP"] = "X";
        habilitaCampos(false);
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtId.Text) > 0)
        {
            Pet_Shop.CAMADAS.MODEL.Pedidos pedidos = new Pet_Shop.CAMADAS.MODEL.Pedidos();
            Pet_Shop.CAMADAS.BLL.Pedidos bllpedidos = new Pet_Shop.CAMADAS.BLL.Pedidos();

            pedidos.id = Convert.ToInt32(txtId.Text);
            DialogResult result;
            result = MessageBox.Show("Deseja Remover o Pedido Selecionado?",
                                      "Remover Pedido",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                bllpedidos.delete(pedidos);
                MessageBox.Show("Pedido removido com Sucesso...");
            }
            else
            {
                MessageBox.Show("Não foi confirmado a remoção do Pedido...", "Remover");
            }
            gridPedidos.DataSource = bllpedidos.select();
            gridPedidos.DataBind();

            Cache["OP"] = "X";
            habilitaCampos(false);

        }
        else MessageBox.Show("Não há registros Selecionados", "Remover");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Cache["OP"] = 'X';
        habilitaCampos(false);
    }

    protected void gridPedidos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Pet_Shop.CAMADAS.BLL.Pedidos bllpedidos = new Pet_Shop.CAMADAS.BLL.Pedidos();
        gridPedidos.DataSource = bllpedidos.select();
        gridPedidos.PageIndex = e.NewPageIndex;
        gridPedidos.DataBind();
    }


    protected void gridPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "select")
        {
            GridViewRow linha = gridPedidos.Rows[Convert.ToInt32(e.CommandArgument)];
            txtId.Text = linha.Cells[0].Text;
            txtClienteID.Text = linha.Cells[1].Text;
            txtProdutoID.Text = linha.Cells[2].Text;
            txtQuantidade.Text = linha.Cells[3].Text;
            txtValor.Text = linha.Cells[4].Text;

        }
    }
}
