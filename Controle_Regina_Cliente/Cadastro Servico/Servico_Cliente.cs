using Controle_Regina_Cliente.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Regina_Cliente.Servico
{
    public partial class Servico_Cliente : Form
    {
        public Servico_Cliente()
        {
            InitializeComponent();
        }

        private void Lbl_Servico_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Retornar_Menu_Click(object sender, EventArgs e)
        {
            Menu_Cliente viajar = new Menu_Cliente();
            viajar.Show();
            this.Hide();
        }
    }
}
