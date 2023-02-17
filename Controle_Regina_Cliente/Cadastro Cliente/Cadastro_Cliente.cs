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
    }
}
