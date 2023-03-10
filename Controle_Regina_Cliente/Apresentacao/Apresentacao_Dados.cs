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

namespace Controle_Regina_Cliente.Apresentacao
{
    public partial class Apresentacao_Dados : Form
    {
        public Apresentacao_Dados()
        {
            InitializeComponent();
        }

        private void Apresentacao_Dados_Load(object sender, EventArgs e)
        {

        }
        //dados a apresentar em tabela
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //inicia o retorno a tela menu
        private void retornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu.Menu viajar = new Menu.Menu();
            viajar.Show();
            this.Close();
        }
    }
}
