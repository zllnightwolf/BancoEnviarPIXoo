using BancoEnviarPIXoo.Controller;
using BancoEnviarPIXoo.Model;
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
    public partial class TelaBanco1 : Form
    {
        public TelaBanco1()
        {
            InitializeComponent();
        }

        ClienteB1 cliente1 = new ClienteB1();
        
        private void TelaBanco1_Load(object sender, EventArgs e)
        {
            lbl_nomeB1.Text = cliente1.nome;
            lbl_cpfB1.Text = cliente1.cpf;
        }

        private void lbl_saldoB1_Click(object sender, EventArgs e)
        {
            lbl_saldoB1.Text = cliente1.saldo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_saldoB1.Text = cliente1.saldo.ToString();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           TelaPix pix = new TelaPix();
            pix.Show();
        }
    }
}
