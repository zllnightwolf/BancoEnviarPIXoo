using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPIXoo.Controller
{
    internal class ClienteB1
    {
        public string nome = "Lucas";
        public string cpf = "123.456.789-12";
        public float saldo = 1000;

        public float VerSaldo()
        {
            return saldo;
        }
        
        public string EnviarPix(string cpf, float valor)
        {
            string msg = "";
            
            if(saldo >= valor)
            {
                this.saldo = valor - saldo;
                //Banco central aqui

                msg = "Pix enviado com sucesso";

            }
            else
            {
                msg = "saldo insuficiente";
            }
            
            return msg;
        }
    }
}
