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
        private void LoginIHM_Load(object sender, EventArgs e)
        {

        }
        private void btn_logar_Click(object sender, EventArgs e)
        {
            cliente.setCpf(mtb_loginCpf.Text);
            cliente.setSenha(tb_loginSenha.Text);
            string senhaDigitada = tb_loginSenha.Text;

            bool senhaValida = cliente.VerificarSenhaDigitada(senhaDigitada);

            ClienteBLL.validaLogin(cliente);

            if (senhaValida && !Erro.getErro())
            {
                ClienteDAL.cpflogado = cliente.getCpf();
                this.Hide();
                MenuPrincipalIHM menuPrincipalIHM = new MenuPrincipalIHM();
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

        private void tb_loginSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtb_loginCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
