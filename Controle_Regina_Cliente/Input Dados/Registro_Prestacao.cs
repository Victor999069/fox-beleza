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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Cliente viajar = new Menu_Cliente();
            viajar.Show();
            this.Hide();
        }

        private void Lbl_Input_Desconto_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Input_Tel_TextChanged(object sender, EventArgs e)
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
    }
}
