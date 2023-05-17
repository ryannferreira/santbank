using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Win32.SafeHandles;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace banco
{
    internal class ClienteDAL
    {
        private static String strConexao = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = BDBanco.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;
        public static string cpflogado;


        public static void conecta()
        {
            try
            {
                conn.Open();
            }

            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }
        public static void desconecta()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static void cadastraCliente(Cliente cliente)
        {
            conecta();
            string aux = "insert into TabClientes(nome, cpf, email, telefone, senha) values (@nome, @cpf, @email, @telefone, @senha)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = cliente.getNome();
            strSQL.Parameters.Add("@cpf", OleDbType.VarChar).Value = cliente.getCpf();
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cliente.getEmail();
            strSQL.Parameters.Add("@telefone", OleDbType.VarChar).Value = cliente.getTelefone();
            strSQL.Parameters.Add("@senha", OleDbType.VarChar).Value = cliente.getSenha();

            Erro.setErro(false);

            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Erro.setMsg("Conta já existente!");
            }
            desconecta();
        }

        public static void verificaCpfExistente(Cliente cliente)
        {
            conecta();
            string aux = "select cpf from TabClientes where cpf= @cpf";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@cpf", OleDbType.VarChar).Value = cliente.getCpf();

            OleDbDataReader dr = strSQL.ExecuteReader();

            if (dr.Read())
            {
                Erro.setMsg("Já existe um cadastrado vínculado ao CPF!");
                return;
            }

            desconecta();
        }

        public static void consultaLogin(Cliente cliente)
        {
            conecta();
            string aux = "select cpf, senha from TabClientes where cpf= @cpf and senha= @senha";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@cpf", OleDbType.VarChar).Value = cliente.getCpf();
            strSQL.Parameters.Add("@senha", OleDbType.VarChar).Value = cliente.getSenha();

            OleDbDataReader dr = strSQL.ExecuteReader();

            Erro.setErro(false);

            if (dr.Read())
            {
                //
            }
            else
            {
                Erro.setMsg("Senha incorreta, tente novamente!");
            }
            desconecta();
        }

        public static void criaConta(Cliente cliente)
        {
            conecta();
            string aux = "insert into TabConta(saldo, dataAbertura, cpf_user) values (0, @dataAbertura, @cpf_user)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@dataAbertura", OleDbType.DBDate).Value = DateTime.Now;
            strSQL.Parameters.Add("@cpf_user", OleDbType.VarChar).Value = cliente.getCpf();
            

            Erro.setErro(false);

            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Erro na criação de conta bancária!", "Erro");
            }
        }

    }
}
