using Controle_Regina_Cliente.Apresentacao;
using Controle_Regina_Cliente.Cliente;
using Controle_Regina_Cliente.Input_Dados;
using Controle_Regina_Cliente.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Regina_Cliente.Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Stm_CadastroCliente_Menu_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente viajar = new Cadastro_Cliente();
            viajar.Show();
            this.Hide();
        }

        private void Stm_CadastroServico_Menu_Click(object sender, EventArgs e)
        {
            Servico_Cliente viajar = new Servico_Cliente();
            viajar.Show();
            this.Hide();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Prestacao viajar = new Registro_Prestacao();
            viajar.Show();
            this.Hide();
        }

        private void dadosAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apresentacao_Dados viajar = new Apresentacao_Dados();
            viajar.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
