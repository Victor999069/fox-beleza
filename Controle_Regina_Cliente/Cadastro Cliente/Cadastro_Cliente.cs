using Controle_Regina_Cliente.Menu;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_Regina_Cliente.Conexao_BD;

namespace Controle_Regina_Cliente.Cliente
{
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Lbl_Text_Client_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }


        //envia o usuario para o menu
        private void retornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu.Menu viajar = new Menu.Menu();
            viajar.Show();
            this.Hide();
        }
        //transmite os dados informados nas textbox para o banco de dados local
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nome = Txt_Cliente_Cadastro.Text;
            string bairro = Txt_Cliente_Bairro.Text;
            string telefone = Mtb_Cliente_Tel.Text;
            string nascimento = Dtp_Cliente_Nascimento.Text;

            string alergia = "";
            if (Rbn_Cliente_Urticaria.Checked)
            {
                alergia = "Urticaria";
            }
            else if (Rbn_Cliente_Dermatite.Checked)
            {
                alergia = "Dermatite de Contato";
            }
            else if (Rbn_Cliente_Atopica.Checked)
            {
                alergia = "Dermatite Atópica";
            }
            else if (Rbn_Cliente_Exantema.Checked)
            {
                alergia = "Exantema";
            }
            else if (Rbn_Cliente_Nenhuma.Checked)
            {
                alergia = "Nenhuma";
            }


            Conexao_Cliente connection = new Conexao_Cliente();

            var cone = connection.CriarConexao();

            string comando = "INSERT INTO Dados_Clientes([Nome Cliente], [Bairro Cliente], [Telefone Cliente], [Data de Nascimento], Alergia) VALUES ('" + nome + "', '" + bairro + "', '" + telefone + "', '" + nascimento + "', '" + alergia + "')";

            try
            {
                SqlCommand command = new SqlCommand(comando, connection.CriarConexao());

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado");

                this.Hide();

                Menu.Menu viaja = new Menu.Menu();
                viaja.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente" + ex.Message);
            }
        }
        
        private void Mtb_Cliente_Tel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Dtp_Cliente_Nascimento_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Rbn_Cliente_Exantema_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rbn_Cliente_Urticaria_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rbn_Cliente_Dermatite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rbn_Cliente_Atopica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rbn_Cliente_Nenhuma_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
