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
using System.Globalization;
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
        private void Txt_Input_Desconto_LostFocus(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Txt_Registro_Desconto.Text, "[^0-9]"))
            {
                MessageBox.Show("Informe o Desconto Dado");
                if (Txt_Registro_Desconto.Text.Length> 0)
                {
                    Txt_Registro_Desconto.Text = Txt_Registro_Desconto.Text.Remove(Txt_Registro_Desconto.Text.Length-1);
                }
            }
            CalculoPrc();
        }


        //retorna lista de serviço
        private void Lista_de_Serviço_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        //retorna lista de cliente
        private void Cbm_Lista_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Cbm_Lista_Cliente.SelectedIndex;

            if (index >  0)
            {
                var nomeCliente = Cbm_Lista_Cliente.Text;

                //carregar telefone
                var telefoneCliente = CarregaTelCliente(nomeCliente);
                Mtb_Registro_Tel.Text = telefoneCliente;
                
            }
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
            string nome = Cbm_Lista_Cliente.Text;
            string servico = Cbm_Lista_Servico.Text;
            string tel = Mtb_Registro_Tel.Text;
            string prc = Mtb_Registro_Servico.Text;
            string desconto = Txt_Registro_Desconto.Text;
            string prcFinal = Txt_Input_PrcFinal.Text;

            Conexao_Cliente connection = new Conexao_Cliente();

            var cone = connection.CriarConexao();

            string comando = "INSERT INTO Dados_Venda([Nome Cliente], [Servico Prestado], [Telefone Cliente], [Preco Servico], Desconto, [Preco Final]) VALUES ('" + nome + "', '" + servico + "', '" + tel + "', '" + prc + "', '" + desconto + "', '" + prcFinal + "')";

            try
            {
                SqlCommand command = new SqlCommand(comando, connection.CriarConexao());

                command.ExecuteNonQuery();

                MessageBox.Show("Serviço Cadastrado");

                this.Hide();

                Menu.Menu viaja = new Menu.Menu();
                viaja.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar serviço." + ex.Message);
            }
        }

        private void CarregarCliente()
        {
            try
            {
                Conexao_Cliente conexao = new Conexao_Cliente();
                SqlConnection connection = conexao.CriarConexao();

                string sql = "SELECT * FROM (SELECT 'SELECIONE' [Nome Cliente], 0 ORDEM UNION SELECT [Nome Cliente], 1 AS ORDEM FROM DADOS_CLIENTES) A ORDER BY ORDEM";
                
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    Cbm_Lista_Cliente.DropDownStyle = ComboBoxStyle.DropDownList;
                    Cbm_Lista_Cliente.FormattingEnabled = true;

                    DataView dataView = new DataView(table);
                    string displayMember = "[Nome Cliente]";

                    Cbm_Lista_Cliente.DisplayMember = "Nome Cliente";
                    Cbm_Lista_Cliente.ValueMember = "Id Cliente";
                    Cbm_Lista_Cliente.DataSource = table;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar os dados na combo box: {ex.Message}");
            }
        }

        private void Registro_Prestacao_Load(object sender, EventArgs e)
        {
            CarregarCliente();
            CarregarServico();
        }

        private void CarregarServico()
        {
            try
            {
                Conexao_Cliente conexao = new Conexao_Cliente();
                SqlConnection connection = conexao.CriarConexao();

                string sql = "SELECT * FROM (SELECT 'SELECIONE' [Nome Servico], 0 ORDEM UNION SELECT [Nome Servico], 1 AS ORDEM FROM DADOS_SERVICO) A ORDER BY ORDEM";

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    Cbm_Lista_Servico.DropDownStyle = ComboBoxStyle.DropDownList;
                    Cbm_Lista_Servico.FormattingEnabled = true;

                    DataView dataView = new DataView();
                    string displayMember = "[Nome Servico]";

                    Cbm_Lista_Servico.DisplayMember = "Nome Servico";
                    Cbm_Lista_Servico.ValueMember = "Id Servico";
                    Cbm_Lista_Servico.DataSource = table;

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

                var index = Cbm_Lista_Servico.SelectedIndex;

                if (index > 0)
                {
                    var nomeServico = Cbm_Lista_Servico.Text;
                    var precoServico = CarregarPreco(nomeServico);
                    if (precoServico != null)
                    {
                        Mtb_Registro_Servico.Text = precoServico.Value.ToString("C");
                    }
                    else
                    {
                        Mtb_Registro_Servico.Text = "";
                    }
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

        private decimal? CarregarPreco(string nomeServico)
        {
            try
            {
                Conexao_Cliente conexao = new Conexao_Cliente();
                using (SqlConnection connection = conexao.CriarConexao())
                {
                    string sql = $"SELECT [Preco Servico] FROM Dados_Servico WHERE [Nome Servico] = '{nomeServico}'";
                    
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            float preco = (float)result;
                            return (decimal)preco;
                        }
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar obter o preço do serviço: {ex.Message}");
            }

            return null;
        }

        private void Txt_Input_PrcFinal_TextChanged(object sender, EventArgs e)
        {
            CalculoPrc();
        }

        private void CalculoPrc()
        {
            if (!double.TryParse(Txt_Registro_Desconto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out double desconto) ||
                !double.TryParse(Mtb_Registro_Servico.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out double preco))
            {
                MessageBox.Show("Valor inválido");
                return;
            }

            double precoFinal = preco - desconto;
            Txt_Input_PrcFinal.Text = precoFinal.ToString("C", CultureInfo.CurrentCulture);
        }

        private void Mtb_Registro_Servico_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            CalculoPrc();
        }

        //private string carregaId(string carregaId)
        //{
            //desenvolver o retorno do id do cliente para auxiliar na analise de dados.
        //}
    }
}
