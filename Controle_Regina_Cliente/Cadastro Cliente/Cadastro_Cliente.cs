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

        private void Btn_Retornar_Menu_Click(object sender, EventArgs e)
        {
            Menu_Cliente viajar = new Menu_Cliente();
            viajar.Show();
            this.Hide();
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Cliente_DDD_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Cliente_DDD.Text, "[^0-9]"))
            {
                MessageBox.Show("Digite somente o DDD");
                if (Txt_Cliente_DDD.Text.Length > 0)
                {
                    Txt_Cliente_DDD.Text = Txt_Cliente_DDD.Text.Remove(Txt_Cliente_DDD.Text.Length - 1);
                }
            };
        }

        private void Txt_Cliente_Tel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Cliente_Tel.Text, "[^0-9]"))
            {
                MessageBox.Show("Digite somente telefone");
                if (Txt_Cliente_Tel.Text.Length > 0)
                {
                    Txt_Cliente_Tel.Text = Txt_Cliente_Tel.Text.Remove(Txt_Cliente_Tel.Text.Length- 1);
                }
            }
        }

        private void Btn_Salvar_Cliente_Click(object sender, EventArgs e)
        {
            string nome = Txt_Cliente_Cadastro.Text;
            string bairro = Txt_Cliente_Bairro.Text;
            string DDD = Txt_Cliente_DDD.Text;
            string telefone = Txt_Cliente_Tel.Text;


            Conexao_Cliente connection = new Conexao_Cliente();

            var cone = connection.CriarConexao();
            
            string comando = "INSERT INTO Dados_Clientes([Nome Cliente], [Bairro Cliente], [DDD Telefone], [Telefone Cliente]) VALUES ('" + nome + "', '" + bairro + "', '" + DDD + "', '" + telefone + "')";

            try
            {
                SqlCommand command = new SqlCommand(comando, connection.CriarConexao());

                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro Realizado");

                this.Hide();

                Menu_Cliente viaja= new Menu_Cliente();
                viaja.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente" + ex.Message);
            }
            
        }
    }
}
