using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPIXoo.Controller
{
    internal class BancoCentral
    {
        string cpforigin;
        string cpfdestino;
        string bancoorigin;
        string bancodestino;
        float valor;

        public int Transferir(string cpforigin, string cpfdestino, string bancoorigin, string bancodestino, float valor)
        {
            ClienteB2 banco2 = new ClienteB2();
            banco2.saldo += valor;
            
           
            
            return 0;
        }
    }
}
