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
    public partial class TelaBanco2 : Form
    {
        public TelaBanco2()
        {
            InitializeComponent();
        }

        ClienteB2 cliente = new ClienteB2();
        private void TelaBanco2_Load(object sender, EventArgs e)
        {
            lbl_nomeB2.Text = cliente.nome;
            lbl_cpfB2.Text = cliente.cpf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_saldoB2.Text = cliente.saldo.ToString();
        }

        private void lbl_saldoB2_Click(object sender, EventArgs e)
        {
            lbl_saldoB2.Text = cliente.saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPix pix= new TelaPix(); 
            pix.Show();
        }
    }
}
