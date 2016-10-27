using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class cadastroProdutos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Pet_Shop.CAMADAS.DAL.Cadastro_Produtos bllproduto = new Pet_Shop.CAMADAS.DAL.Cadastro_Produtos();
            gridProduto.DataSource = bllproduto.select();
            gridProduto.DataBind();
        }
    }
    protected void habilitaCampos(bool status)
    {
        if (Cache["OP"].ToString() != "E")
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";      
        }

        txtId.Enabled = status;
        txtDescricao.Enabled = status;
        txtQuantidade.Enabled = status;
        txtValor.Enabled = status;
       
        btnInserir.Enabled = !status;
        btnEditar.Enabled = !status;
        btnGravar.Enabled = status;
        btnRemover.Enabled = !status;
        btnCancelar.Enabled = status;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (txtId.Text != string.Empty)
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                Cache["OP"] = "E";
                habilitaCampos(true);
                txtDescricao.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado");
    }

    protected void btnInserir_Click(object sender, EventArgs e)
    {
        Cache["OP"] = "I";
        habilitaCampos(true);
        txtId.Text = "-1";
        txtDescricao.Focus();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Pet_Shop.CAMADAS.MODEL.Cadastro_Produtos produto = new Pet_Shop.CAMADAS.MODEL.Cadastro_Produtos();
        Pet_Shop.CAMADAS.BLL.Cadastro_Produtos bllproduto = new Pet_Shop.CAMADAS.BLL.Cadastro_Produtos();

        produto.id = Convert.ToInt32(txtId.Text);
        produto.descricao = txtDescricao.Text;
        produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
        produto.valor = Convert.ToInt32(txtValor.Text);
        
        string msg;

        if (Cache["OP"].ToString() == "I")
            msg = "Desaja Confirma Inserção dos Dados?";
        else msg = "Deseja Confirmar alteração dos Dados";

        DialogResult resp;
        resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        if (resp == DialogResult.OK)
            if (Cache["OP"].ToString() == "I")
                bllproduto.insert(produto);
            else if (Cache["OP"].ToString() == "E")
                bllproduto.update(produto);

        gridProduto.DataSource = bllproduto.select();
        gridProduto.DataBind();
        gridProduto.SetPageIndex(gridProduto.PageCount);
        Cache["OP"] = "X";
        habilitaCampos(false);
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtId.Text) > 0)
        {
            Pet_Shop.CAMADAS.MODEL.Cadastro_Produtos produto = new Pet_Shop.CAMADAS.MODEL.Cadastro_Produtos();
            Pet_Shop.CAMADAS.BLL.Cadastro_Produtos bllproduto = new Pet_Shop.CAMADAS.BLL.Cadastro_Produtos();

            produto.id = Convert.ToInt32(txtId.Text);
            DialogResult result;
            result = MessageBox.Show("Deseja Remover o Produto Selecionado?",
                                      "Remover Produto",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                bllproduto.delete(produto);
                MessageBox.Show("Produto removida com Sucesso...");
            }
            else
            {
                MessageBox.Show("Não foi confirmado a remoção do Produto...", "Remover");
            }
            gridProduto.DataSource = bllproduto.select();
            gridProduto.DataBind();

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

    protected void gridProduto_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Pet_Shop.CAMADAS.BLL.Cadastro_Produtos bllproduto = new Pet_Shop.CAMADAS.BLL.Cadastro_Produtos();
        gridProduto.DataSource = bllproduto.select();
        gridProduto.PageIndex = e.NewPageIndex;
        gridProduto.DataBind();
    }

    protected void gridProduto_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            GridViewRow linha = gridProduto.Rows[Convert.ToInt32(e.CommandArgument)];
            txtId.Text = linha.Cells[0].Text;
            txtDescricao.Text = linha.Cells[1].Text;
            txtQuantidade.Text = linha.Cells[2].Text;
            txtValor.Text = linha.Cells[3].Text;
        }
    }
}
