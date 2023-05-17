using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        public string email;
        private string telefone;
        private string senha;

        public void setNome(string _nome) 
        { 
            nome = _nome; 
        }

        public void setCpf(string _cpf)
        {
            cpf = _cpf;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }
        public void setTelefone(string _telefone)
        {
            telefone = _telefone;
        }
        public void setSenha(string _senha) 
        {
            senha = _senha;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = ClienteBLL.GetHash(_senha);
                senha = hash;
            }
        }
         public bool VerificarSenhaDigitada(string senhaDigitada)
            {
                return ClienteBLL.VerificarSenha(senhaDigitada, senha);
            }

        public string getNome()
        {
            return nome;
        }

        public string getCpf()
        {
            return cpf;
        }

        public string getEmail ()
        {
            return email;
        }

        public string getTelefone() 
        { 
            return telefone; 
        }

        public string getSenha() 
        { 
            return senha; 
        }

    }
}
