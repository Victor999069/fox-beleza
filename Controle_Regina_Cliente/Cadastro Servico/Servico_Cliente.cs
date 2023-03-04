using Controle_Regina_Cliente.Conexao_BD;
using Controle_Regina_Cliente.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void Btn_Salvar_Servico_Click(object sender, EventArgs e)
        {
            string servico = Txt_Nome_Servico.Text;
            string prcServico = Txt_Preco_Servico.Text;
            string descServico = Rtb_Descricao_Servico.Text;

            Conexao_Cliente connection = new Conexao_Cliente();

            var cone = connection.CriarConexao();

            string comando = "INSERT INTO Dados_Servico([Nome Servico], [Preco Servico], [Descricao Servico]) VALUES ('" + servico + "', '" + prcServico+ "', '" + descServico + "')";


            try
            {
                SqlCommand command = new SqlCommand(comando, connection.CriarConexao());

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado");

                this.Hide();

                Menu_Cliente viaja = new Menu_Cliente();
                viaja.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Depuração não acionada" + ex);
            }
        }
    }
}
