using BancoEnviarPIXoo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoEnviarPIXoo.View
{
    public partial class TelaPix : Form
    {
        public TelaPix()
        {
            InitializeComponent();
        }

        ClienteB1 cliente1 = new ClienteB1();
        ClienteB2 cliente2 = new ClienteB2();
        private void TelaPix_Load(object sender, EventArgs e)
        {
            lbl_nomeOrigin.Text = cliente1.nome;
            lbl_cpfOrigin.Text = cliente1.cpf;
            lbl_saldoOrigin.Text = cliente1.saldo.ToString();

            lbl_nomeDestino.Text = cliente2.nome;
            lbl_cpfDestino.Text = cliente2.cpf;
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            string bancoorigin = "banco1";
            string bancodestino = "banco2";
            float valor = Convert.ToInt16(txt_valor.Text);
            BancoCentral banco = new BancoCentral();
            banco.Transferir(cliente1.cpf, cliente2.cpf, bancoorigin, bancodestino, valor);

            cliente2.saldo += valor;
            MessageBox.Show("Dados Transferidos com Sucesso." + cliente2.saldo);
        }
    }
}
