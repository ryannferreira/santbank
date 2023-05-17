using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace banco
{
    internal class ClienteBLL
    {
        
        public static void conecta()
        {
            ClienteDAL.conecta();
        }

        public static void desconecta()
        {
            ClienteDAL.desconecta();
        }

        public static bool validaCPF(Cliente cliente)
        {
            string cpf = cliente.getCpf();

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int primeiroDigito = 11 - (soma % 11);
            if (primeiroDigito > 9)
            {
                primeiroDigito = 0;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            int segundoDigito = 11 - (soma % 11);
            if (segundoDigito > 9)
            {
                segundoDigito = 0;
            }

            if (cpf[9].ToString() != primeiroDigito.ToString() || cpf[10].ToString() != segundoDigito.ToString())
            {
                return false;
            }

            return true;
        }

        public static bool validaEmail(Cliente cliente)
        {
            string email = cliente.getEmail();

            string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex regex = new Regex(padraoEmail);

            if (regex.IsMatch(email))
            {
                return true;
            }

            return false;
        }
        public static void validaLogin(Cliente cliente)
        {
            Erro.setErro(false);
            if (cliente.getCpf().Equals(""))
            {
                Erro.setMsg("O CPF é de preenchimento obrigatório!");
                return;
            }
            if (cliente.getSenha().Equals(""))
            {
                Erro.setMsg("A senha é de preenchimento obrigatório!");
                return;
            }

            ClienteDAL.consultaLogin(cliente);
        }

        public static void validaCadastro(Cliente cliente)
        {
            Erro.setErro(false);
            if (cliente.getNome().Equals(""))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório!");
                return;
            }
            
            if (cliente.getCpf().Length < 14)
            {
                Erro.setMsg("O cpf é de preenchimento obrigatório!");
                return;

            }
            else if (validaCPF(cliente) == false)
            {
                Erro.setMsg("CPF inválido!");
                return;
            }

            if (cliente.getEmail().Equals(""))
            {
                Erro.setMsg("O e-mail é de preenchimento obrigatório!");
                return;
            }
            else if (validaEmail(cliente) == false)
            { 
                Erro.setMsg("E-mail inválido!");
                return;
            }

            if (cliente.getTelefone().Equals(""))
            {
                Erro.setMsg("O telefone é de preenchimento obrigatório!");
                return;
            }
            if (cliente.getSenha().Equals(""))
            {
                Erro.setMsg("A senha é de preenchimento obrigatório!");
                return;
            }

            ClienteDAL.verificaCpfExistente(cliente);
            ClienteDAL.cadastraCliente(cliente);
            ClienteDAL.criaConta(cliente);
        }

        public static string GetHash(string senha)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public static bool VerificarSenha(string senhaDigitada, string senha)
        {
            string senhaDigitadaCriptografada = GetHash(senhaDigitada);
            return senhaDigitadaCriptografada.Equals(senha);
        }

    }
}

