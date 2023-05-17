using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Conta
    {
        private string nConta;
        private string saldo;
        private string dataAbertura;

        public void setnConta(string _nConta)
        {
            nConta = _nConta;
        }

        public void setSaldo(string _saldo)
        {
            saldo = _saldo;
        }

        public void setDataAbertura(string _dataAbertura)
        {
            dataAbertura = _dataAbertura;
        }

        public string getnConta() 
        {
            return nConta;
        }
        public string getSaldo()
        {
            return saldo;
        }
        public string getDataAbertura()
        {
            return dataAbertura;
        }
    }
}
