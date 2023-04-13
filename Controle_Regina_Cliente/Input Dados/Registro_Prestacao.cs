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

        private void Lbl_Input_Desconto_Click(object sender, EventArgs e)
        {

        }
        //comando passado na textbox para condições numericas
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


        //retorna lista de serviço
        private void Lista_de_Serviço_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //retorna lista de cliente
        private void Cbm_Lista_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarCliente();
        }
        //retorna ao menu
        private void retornarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu.Menu viajar = new Menu.Menu();
            viajar.Show();
            this.Hide();
        }
        //comando para salvar os dados passados na textbox
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Input_PrcFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void carregarCliente()
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

                    Cbm_Lista_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;
                    Cbm_Lista_Cliente.FormattingEnabled = true;

                    DataView dataView = new DataView(table);
                    string displayMember = "[Nome Cliente]";
                    dataView.RowFilter = string.Format("{0} = '{1}'", displayMember, Cbm_Lista_Cliente.Text);

                    Cbm_Lista_Cliente.DisplayMember = "[Nome Cliente]";
                    Cbm_Lista_Cliente.ValueMember = "[Nome Cliente]";
                    Cbm_Lista_Cliente.DataSource = dataView;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar os dados na combo box: {ex.Message}");
            }
        }

        private void Cbm_Lista_Servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se o indice é maior que zero (selecione)
            //calcular preço de acordo com o serviço

            var index = Cbm_Lista_Cliente.SelectedIndex;

            if (index > 0)
            {
                var nomeServico = Cbm_Lista_Cliente.Text;
                var precoServico = CarregarPreco(nomeServico);
                Txt_Registro_Prc.Text = precoServico.ToString("C");

            }
        }

        private string CarregaTelCliente(string nomeCliente)
        {
            try
            {
                Conexao_Cliente conexao = new Conexao_Cliente();
                SqlConnection connection = conexao.CriarConexao();

                string sql = $"SELECT [Telefone Cliente] FROM Dados_Clientes WHERE [Nome Cliente] = '{nomeCliente}'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    string telefoneCliente = Convert.ToString(command.ExecuteScalar());

                    connection.Close();

                    return telefoneCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar o telefone do cliente: {ex.Message}");
                return string.Empty;
            }
        }

        private decimal CarregarPreco(string nomeServico)
        {
            try
            {
                Conexao_Cliente conexao = new Conexao_Cliente();
                using (SqlConnection connection = conexao.CriarConexao())
                {
                    string sql = $"SELECT [PRECO] FROM [DADOS_SERVICO] WHERE [NOME_SERVICO] = '{nomeServico}'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            decimal preco = (decimal)result;
                            return preco;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar obter o preço do serviço: {ex.Message}");
        }

    }
}
