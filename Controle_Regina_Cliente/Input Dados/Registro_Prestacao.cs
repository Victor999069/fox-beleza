using Controle_Regina_Cliente.Conexao_BD;
using Controle_Regina_Cliente.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Regina_Cliente.Input_Dados
{
    public partial class Registro_Prestacao : Form
    {
        public Registro_Prestacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu.Menu viajar = new Menu.Menu();
            viajar.Show();
            this.Hide();
        }

        private void Lbl_Input_Desconto_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Input_Desconto_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Registro_Desconto.Text, "[^0-9]"))
            {
                MessageBox.Show("Informe o Desconto Dado");
                if (Txt_Registro_Desconto.Text.Length> 0)
                {
                    Txt_Registro_Desconto.Text = Txt_Registro_Desconto.Text.Remove(Txt_Registro_Desconto.Text.Length-1);
                }
            }
        }

        private void Txt_Telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Registro_Prc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lista_de_Serviço_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbm_Lista_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao_Cliente conexao = new Conexao_Cliente();
                SqlConnection connection = conexao.CriarConexao();

                string sql = "SELECT [Nome Cliente] FROM Dados_Clientes";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Cbm_Lista_Cliente.DisplayMember = "[Nome Cliente]";
                    Cbm_Lista_Cliente.ValueMember = "[Nome Cliente]";
                    Cbm_Lista_Cliente.DataSource = table;
                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine(row["Nome Cliente"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar os dados na combo box: {ex.Message}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexao_Cliente conexao = new Conexao_Cliente();
            SqlConnection connection = conexao.CriarConexao();

            string sql = "SELECT [Nome Cliente] FROM Dados_Clientes";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["Nome Cliente"].ToString());
                    }
                }
            }
        }
    }
}
