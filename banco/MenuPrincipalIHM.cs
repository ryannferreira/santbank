using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class MenuPrincipalIHM : Form
    {
        public MenuPrincipalIHM()
        {
            InitializeComponent();
            lb_saldo.Text = "R$ " + ClienteDAL.saldo;
            lb_nomeLogado.Text = ClienteDAL.nome;
        }

        private void pic_extrato_Click(object sender, EventArgs e)
        {
            ExtratoIHM extratoIHM = new ExtratoIHM();
            extratoIHM.ShowDialog();
        }

        private void pic_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_cartão_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai caramba!", "Easter egg");
        }

        private void pic_deposito_Click(object sender, EventArgs e)
        {
            DepositoIHM depositoIHM = new DepositoIHM();
            depositoIHM.ShowDialog();
        }

        private void pic_saque_Click(object sender, EventArgs e)
        {
            SaqueIHM saqueIHM = new SaqueIHM();
            saqueIHM.ShowDialog();
        }

        private void pic_transferencia_Click(object sender, EventArgs e)
        {
            TransferenciaIHM transferenciaIHM = new TransferenciaIHM();
            transferenciaIHM.ShowDialog();
        }

    }
}
