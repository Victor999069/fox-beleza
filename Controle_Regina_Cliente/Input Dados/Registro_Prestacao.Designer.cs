namespace Controle_Regina_Cliente.Input_Dados
{
    partial class Registro_Prestacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lbl_Input_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Input_Servico = new System.Windows.Forms.Label();
            this.Lbl_Input_Tel = new System.Windows.Forms.Label();
            this.Lbl_Input_Preco = new System.Windows.Forms.Label();
            this.Txt_Registro_Prc = new System.Windows.Forms.TextBox();
            this.Lbl_Input_Desconto = new System.Windows.Forms.Label();
            this.Txt_Registro_Desconto = new System.Windows.Forms.TextBox();
            this.Btn_Prestacao_Retorna = new System.Windows.Forms.Button();
            this.Lbl_Prestacao_Inicial = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Lista_de_Serviço = new System.Windows.Forms.ListBox();
            this.conexaoClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cbm_Lista_Cliente = new System.Windows.Forms.ComboBox();
            this.cadastroClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.conexaoClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Input_Cliente
            // 
            this.Lbl_Input_Cliente.AutoSize = true;
            this.Lbl_Input_Cliente.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Cliente.Location = new System.Drawing.Point(12, 126);
            this.Lbl_Input_Cliente.Name = "Lbl_Input_Cliente";
            this.Lbl_Input_Cliente.Size = new System.Drawing.Size(103, 29);
            this.Lbl_Input_Cliente.TabIndex = 1;
            this.Lbl_Input_Cliente.Text = "Nome Cliente";
            this.Lbl_Input_Cliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Input_Servico
            // 
            this.Lbl_Input_Servico.AutoSize = true;
            this.Lbl_Input_Servico.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Servico.Location = new System.Drawing.Point(280, 126);
            this.Lbl_Input_Servico.Name = "Lbl_Input_Servico";
            this.Lbl_Input_Servico.Size = new System.Drawing.Size(122, 29);
            this.Lbl_Input_Servico.TabIndex = 3;
            this.Lbl_Input_Servico.Text = "Serviço Prestado";
            // 
            // Lbl_Input_Tel
            // 
            this.Lbl_Input_Tel.AutoSize = true;
            this.Lbl_Input_Tel.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Tel.Location = new System.Drawing.Point(2, 189);
            this.Lbl_Input_Tel.Name = "Lbl_Input_Tel";
            this.Lbl_Input_Tel.Size = new System.Drawing.Size(121, 29);
            this.Lbl_Input_Tel.TabIndex = 6;
            this.Lbl_Input_Tel.Text = "Telefone Cliente";
            // 
            // Lbl_Input_Preco
            // 
            this.Lbl_Input_Preco.AutoSize = true;
            this.Lbl_Input_Preco.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Preco.Location = new System.Drawing.Point(449, 189);
            this.Lbl_Input_Preco.Name = "Lbl_Input_Preco";
            this.Lbl_Input_Preco.Size = new System.Drawing.Size(50, 29);
            this.Lbl_Input_Preco.TabIndex = 8;
            this.Lbl_Input_Preco.Text = "Preço";
            // 
            // Txt_Registro_Prc
            // 
            this.Txt_Registro_Prc.Location = new System.Drawing.Point(500, 189);
            this.Txt_Registro_Prc.Name = "Txt_Registro_Prc";
            this.Txt_Registro_Prc.Size = new System.Drawing.Size(69, 23);
            this.Txt_Registro_Prc.TabIndex = 7;
            this.Txt_Registro_Prc.TextChanged += new System.EventHandler(this.Txt_Registro_Prc_TextChanged);
            // 
            // Lbl_Input_Desconto
            // 
            this.Lbl_Input_Desconto.AutoSize = true;
            this.Lbl_Input_Desconto.Font = new System.Drawing.Font("Javanese Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Input_Desconto.Location = new System.Drawing.Point(287, 189);
            this.Lbl_Input_Desconto.Name = "Lbl_Input_Desconto";
            this.Lbl_Input_Desconto.Size = new System.Drawing.Size(74, 29);
            this.Lbl_Input_Desconto.TabIndex = 10;
            this.Lbl_Input_Desconto.Text = "Desconto";
            this.Lbl_Input_Desconto.Click += new System.EventHandler(this.Lbl_Input_Desconto_Click);
            // 
            // Txt_Registro_Desconto
            // 
            this.Txt_Registro_Desconto.Location = new System.Drawing.Point(363, 189);
            this.Txt_Registro_Desconto.Name = "Txt_Registro_Desconto";
            this.Txt_Registro_Desconto.Size = new System.Drawing.Size(75, 23);
            this.Txt_Registro_Desconto.TabIndex = 9;
            this.Txt_Registro_Desconto.TextChanged += new System.EventHandler(this.Txt_Input_Desconto_TextChanged);
            // 
            // Btn_Prestacao_Retorna
            // 
            this.Btn_Prestacao_Retorna.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Prestacao_Retorna.Location = new System.Drawing.Point(12, 252);
            this.Btn_Prestacao_Retorna.Name = "Btn_Prestacao_Retorna";
            this.Btn_Prestacao_Retorna.Size = new System.Drawing.Size(86, 33);
            this.Btn_Prestacao_Retorna.TabIndex = 11;
            this.Btn_Prestacao_Retorna.Text = "Retorna";
            this.Btn_Prestacao_Retorna.UseVisualStyleBackColor = true;
            this.Btn_Prestacao_Retorna.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Prestacao_Inicial
            // 
            this.Lbl_Prestacao_Inicial.AutoSize = true;
            this.Lbl_Prestacao_Inicial.Font = new System.Drawing.Font("Javanese Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lbl_Prestacao_Inicial.Location = new System.Drawing.Point(123, 13);
            this.Lbl_Prestacao_Inicial.Name = "Lbl_Prestacao_Inicial";
            this.Lbl_Prestacao_Inicial.Size = new System.Drawing.Size(365, 43);
            this.Lbl_Prestacao_Inicial.TabIndex = 12;
            this.Lbl_Prestacao_Inicial.Text = "Informe os dados do seu atendimento";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(123, 190);
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(148, 23);
            this.Txt_Telefone.TabIndex = 14;
            this.Txt_Telefone.TextChanged += new System.EventHandler(this.Txt_Telefone_TextChanged);
            // 
            // Lista_de_Serviço
            // 
            this.Lista_de_Serviço.DataSource = this.conexaoClienteBindingSource1;
            this.Lista_de_Serviço.FormattingEnabled = true;
            this.Lista_de_Serviço.ItemHeight = 15;
            this.Lista_de_Serviço.Location = new System.Drawing.Point(423, 126);
            this.Lista_de_Serviço.Name = "Lista_de_Serviço";
            this.Lista_de_Serviço.Size = new System.Drawing.Size(160, 19);
            this.Lista_de_Serviço.TabIndex = 15;
            this.Lista_de_Serviço.SelectedIndexChanged += new System.EventHandler(this.Lista_de_Serviço_SelectedIndexChanged);
            // 
            // conexaoClienteBindingSource1
            // 
            this.conexaoClienteBindingSource1.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // conexaoClienteBindingSource
            // 
            this.conexaoClienteBindingSource.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // Cbm_Lista_Cliente
            // 
            this.Cbm_Lista_Cliente.DataSource = this.cadastroClienteBindingSource;
            this.Cbm_Lista_Cliente.FormattingEnabled = true;
            this.Cbm_Lista_Cliente.Location = new System.Drawing.Point(121, 126);
            this.Cbm_Lista_Cliente.Name = "Cbm_Lista_Cliente";
            this.Cbm_Lista_Cliente.Size = new System.Drawing.Size(138, 23);
            this.Cbm_Lista_Cliente.TabIndex = 16;
            this.Cbm_Lista_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cbm_Lista_Cliente_SelectedIndexChanged);
            // 
            // cadastroClienteBindingSource
            // 
            this.cadastroClienteBindingSource.DataSource = typeof(Controle_Regina_Cliente.Cliente.Cadastro_Cliente);
            // 
            // conexaoClienteBindingSource4
            // 
            this.conexaoClienteBindingSource4.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // conexaoClienteBindingSource2
            // 
            this.conexaoClienteBindingSource2.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // conexaoClienteBindingSource3
            // 
            this.conexaoClienteBindingSource3.DataSource = typeof(Controle_Regina_Cliente.Conexao_BD.Conexao_Cliente);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(313, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 94);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Registro_Prestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 306);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cbm_Lista_Cliente);
            this.Controls.Add(this.Lista_de_Serviço);
            this.Controls.Add(this.Txt_Telefone);
            this.Controls.Add(this.Lbl_Prestacao_Inicial);
            this.Controls.Add(this.Btn_Prestacao_Retorna);
            this.Controls.Add(this.Lbl_Input_Desconto);
            this.Controls.Add(this.Txt_Registro_Desconto);
            this.Controls.Add(this.Lbl_Input_Preco);
            this.Controls.Add(this.Txt_Registro_Prc);
            this.Controls.Add(this.Lbl_Input_Tel);
            this.Controls.Add(this.Lbl_Input_Servico);
            this.Controls.Add(this.Lbl_Input_Cliente);
            this.Name = "Registro_Prestacao";
            this.Text = "Input_Dados";
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoClienteBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Lbl_Input_Cliente;
        private Label Lbl_Input_Servico;
        private Label Lbl_Input_Tel;
        private Label Lbl_Input_Preco;
        private TextBox Txt_Registro_Prc;
        private Label Lbl_Input_Desconto;
        private TextBox Txt_Registro_Desconto;
        private Button Btn_Prestacao_Retorna;
        private Label Lbl_Prestacao_Inicial;
        private TextBox Txt_Telefone;
        private ListBox Lista_de_Serviço;
        private BindingSource conexaoClienteBindingSource1;
        private BindingSource conexaoClienteBindingSource;
        private ComboBox Cbm_Lista_Cliente;
        private BindingSource conexaoClienteBindingSource2;
        private BindingSource conexaoClienteBindingSource4;
        private BindingSource conexaoClienteBindingSource3;
        private BindingSource cadastroClienteBindingSource;
        private ListBox listBox1;
    }
}