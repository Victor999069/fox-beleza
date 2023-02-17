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
    public partial class Menu_Cliente : Form
    {
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Registra_Cliente_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente viajar = new Cadastro_Cliente();
            viajar.Show();
            this.Hide();
        }

        

        private void Btn_Cadastrar_Serviço_Click(object sender, EventArgs e)
        {
            Servico_Cliente viajar = new Servico_Cliente();
            viajar.Show();
            this.Hide();
        }

        private void Btn_Menu_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Apresentacao_Click(object sender, EventArgs e)
        {
            Apresentacao_Dados viajar = new Apresentacao_Dados();
            viajar.Show();
            this.Hide();
        }

        private void Menu_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Menu_Input_Click(object sender, EventArgs e)
        {
            Registro_Prestacao viajar = new Registro_Prestacao();
            viajar.Show();
            this.Hide();
        }
    }
}
