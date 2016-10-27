using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class cadastroCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Pet_Shop.CAMADAS.DAL.Cadastro_Clientes bllcliente = new Pet_Shop.CAMADAS.DAL.Cadastro_Clientes();
            gridCliente.DataSource = bllcliente.select();
            gridCliente.DataBind();
        }
    }

    protected void habilitaCampos(bool status)
    {
        if (Cache["OP"].ToString() != "E")
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCPF.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCEP.Text = "";
            txtEmail.Text = "";
        }

        txtId.Enabled = status;
        txtNome.Enabled = status;
        txtEndereco.Enabled = status;
        txtCPF.Enabled = status;
        txtCidade.Enabled = status;
        txtEstado.Enabled = status;
        txtCEP.Enabled = status;
        txtEmail.Enabled = status;

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
        txtNome.Focus();
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (txtId.Text != string.Empty)
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                Cache["OP"] = "E";
                habilitaCampos(true);
                txtNome.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado");
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        Pet_Shop.CAMADAS.MODEL.Cadastro_Clientes cliente = new Pet_Shop.CAMADAS.MODEL.Cadastro_Clientes();
        Pet_Shop.CAMADAS.BLL.Cadastro_Clientes bllcliente = new Pet_Shop.CAMADAS.BLL.Cadastro_Clientes();

        cliente.id = Convert.ToInt32(txtId.Text);
        cliente.nome = txtNome.Text;
        cliente.endereco = txtEndereco.Text;
        cliente.cpf = txtCPF.Text;
        cliente.cidade = txtCidade.Text;
        cliente.estado = txtEstado.Text;
        cliente.cep = txtCEP.Text;
        cliente.email = txtEmail.Text;

        string msg;

        if (Cache["OP"].ToString() == "I")
            msg = "Desaja Confirma Inserção dos Dados?";
        else msg = "Deseja Confirmar alteração dos Dados";

        DialogResult resp;
        resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        if (resp == DialogResult.OK)
            if (Cache["OP"].ToString() == "I")
                bllcliente.insert(cliente);
            else if (Cache["OP"].ToString() == "E")
                bllcliente.Update(cliente);

        gridCliente.DataSource = bllcliente.select();
        gridCliente.DataBind();
        gridCliente.SetPageIndex(gridCliente.PageCount);
        Cache["OP"] = "X";
        habilitaCampos(false);
    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtId.Text) > 0)
        {
            Pet_Shop.CAMADAS.MODEL.Cadastro_Clientes cliente = new Pet_Shop.CAMADAS.MODEL.Cadastro_Clientes();
            Pet_Shop.CAMADAS.BLL.Cadastro_Clientes bllcliente = new Pet_Shop.CAMADAS.BLL.Cadastro_Clientes();

            cliente.id = Convert.ToInt32(txtId.Text);
            DialogResult result;
            result = MessageBox.Show("Deseja Remover o Cliente Selecionado?",
                                      "Remover Cliente",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question,
                                      MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                bllcliente.Delete(cliente);
                MessageBox.Show("cliente removida com Sucesso...");
            }
            else
            {
                MessageBox.Show("Não foi confirmado a remoção do cliente...", "Remover");
            }
            gridCliente.DataSource = bllcliente.select();
            gridCliente.DataBind();

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

    protected void gridCliente_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Pet_Shop.CAMADAS.BLL.Cadastro_Clientes bllcliente = new Pet_Shop.CAMADAS.BLL.Cadastro_Clientes();
        gridCliente.DataSource = bllcliente.select();
        gridCliente.PageIndex = e.NewPageIndex;
        gridCliente.DataBind();
    }

    protected void gridCliente_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            GridViewRow linha = gridCliente.Rows[Convert.ToInt32(e.CommandArgument)];
            txtId.Text = linha.Cells[0].Text;
            txtNome.Text = linha.Cells[1].Text;
            txtEndereco.Text = linha.Cells[2].Text;
            txtCPF.Text = linha.Cells[3].Text;
            txtCidade.Text = linha.Cells[4].Text;
            txtEstado.Text = linha.Cells[5].Text;
            txtCEP.Text = linha.Cells[6].Text; ;
            txtEmail.Text = linha.Cells[7].Text;
        }
    }
}