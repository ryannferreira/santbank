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

namespace banco
{
    public partial class LoginIHM : Form
    {
        Cliente cliente = new Cliente();

        public LoginIHM()
        {
            InitializeComponent();
        }
        private void btn_logar_Click(object sender, EventArgs e)
        {
            cliente.setCpf(mtb_loginCpf.Text);
            cliente.setSenha(tb_loginSenha.Text);

            bool senhaValida = cliente.VerificarSenhaDigitada(tb_loginSenha.Text);

            ClienteBLL.validaLogin(cliente);

            if (senhaValida && !Erro.getErro())
            {
                MenuPrincipalIHM menuPrincipalIHM = new MenuPrincipalIHM();
                this.Hide(); 
                menuPrincipalIHM.ShowDialog();
            }
            else
            {
                MessageBox.Show(Erro.getMsg(), "Erro");
            }

        }

        private void btn_cadastreSe_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroIHM cadastroIHM = new CadastroIHM();
            cadastroIHM.Show();
        }
    }
}
