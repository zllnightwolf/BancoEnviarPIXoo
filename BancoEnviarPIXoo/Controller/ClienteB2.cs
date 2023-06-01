using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEnviarPIXoo.Controller
{
    internal class ClienteB2
    {
        public string nome = "Bianca";
        public string cpf = "432.456.789-11";
        public float saldo = 5000;

        public float VerSaldo()
        {
            return saldo;
        }

        public string EnviarPix(string cpf, float valor)
        {
            string msg = "";

            if (saldo >= valor)
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
