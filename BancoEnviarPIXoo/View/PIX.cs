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
    public partial class PIX : Form
    {
        ClienteB1 cliente1= new ClienteB1();
        ClienteB2 cliente2= new ClienteB2();
        public PIX()
        {
            InitializeComponent();
            lbl_nomeB1.Text = cliente1.nome;
            lbl_cpfB1.Text= cliente1.cpf;
            lbl_nomeDestinoB1.Text = cliente2.nome;
            lbl_cpfDestinoB1.Text = cliente2.cpf;

            lbl_nomeB2.Text = cliente2.nome;
            lbl_cpfB2.Text = cliente2.cpf;
            lbl_nomeDestinhoB2.Text = cliente1.nome;
            lbl_cpfDestinoB2.Text = cliente1.cpf;
        }

        private void btn_versaldoB1_Click(object sender, EventArgs e)
        {
            lbl_saldoB1.Text = Convert.ToString(cliente1.saldo);
        }

        private void btn_versaldoB2_Click(object sender, EventArgs e)
        {
            lbl_saldoB2.Text = Convert.ToString(cliente2.saldo);    
        }

        private void btn_transferirB1_Click(object sender, EventArgs e)
        {
            cliente2.saldo += Convert.ToInt16(txt_valorB1.Text);
            cliente1.saldo -= Convert.ToInt16(txt_valorB1.Text);
        }

        private void btn_transferirB2_Click(object sender, EventArgs e)
        {
            cliente1.saldo += Convert.ToInt16(txt_valorB2.Text);
            cliente2.saldo -= Convert.ToInt16(txt_valorB1.Text);
        }
    }
}
