using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Conta
    {
        private string saldo;


        public void setSaldo(string _saldo)
        {
            saldo = _saldo;
        }
      
        public string getSaldo()
        {
            return saldo;
        }
    }
}
