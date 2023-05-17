using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace banco
{
    public partial class CadastroIHM : Form
    {
        Cliente cliente = new Cliente();
        public CadastroIHM()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = BDBanco.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
       
        public void LimparCampos()
        {
            tb_nomeCompleto.Text = "";
            mtb_cpf.Text = "";
            mtb_telefone.Text = "";
            tb_email.Text = "";
            tb_senha.Text = "";
            tb_senhaConfirm.Text = "";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cliente.setNome(tb_nomeCompleto.Text);
            cliente.setCpf(mtb_cpf.Text);
            cliente.setTelefone(mtb_telefone.Text);
            cliente.setEmail(tb_email.Text);
            cliente.setSenha(tb_senha.Text);

            if (tb_senha.Text == tb_senhaConfirm.Text)
            {
                ClienteBLL.validaCadastro(cliente);
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMsg(), "Erro");
                }
                else
                {
                    MessageBox.Show("Dados cadastrados com sucesso.", "Cadastro confirmado.");
                    LimparCampos();
                }
            } 
            else
            {
                MessageBox.Show("As senhas não conferem.", "Erro");
            }  
        }

        private void lb_voltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuLogin = new LoginIHM();
            menuLogin.Closed += (s, args) => this.Close();
            menuLogin.Show();
        }

    }
}
