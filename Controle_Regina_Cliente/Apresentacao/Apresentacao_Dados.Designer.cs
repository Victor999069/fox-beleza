namespace Controle_Regina_Cliente.Apresentacao
{
    partial class Apresentacao_Dados
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
            this.Dgv_Apresentacao_Dados = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prc_Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Apresentacao_Retorna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Apresentacao_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Apresentacao_Dados
            // 
            this.Dgv_Apresentacao_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Apresentacao_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Nome_Cliente,
            this.Bairro_Cliente,
            this.Tel_Cliente,
            this.Nome_Servico,
            this.Prc_Servico});
            this.Dgv_Apresentacao_Dados.Location = new System.Drawing.Point(34, 102);
            this.Dgv_Apresentacao_Dados.Name = "Dgv_Apresentacao_Dados";
            this.Dgv_Apresentacao_Dados.RowTemplate.Height = 25;
            this.Dgv_Apresentacao_Dados.Size = new System.Drawing.Size(700, 150);
            this.Dgv_Apresentacao_Dados.TabIndex = 0;
            this.Dgv_Apresentacao_Dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "Id_Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.HeaderText = "Nome Cliente";
            this.Nome_Cliente.Name = "Nome_Cliente";
            // 
            // Bairro_Cliente
            // 
            this.Bairro_Cliente.HeaderText = "Bairro Cliente";
            this.Bairro_Cliente.Name = "Bairro_Cliente";
            // 
            // Tel_Cliente
            // 
            this.Tel_Cliente.HeaderText = "Tel Cliente";
            this.Tel_Cliente.Name = "Tel_Cliente";
            // 
            // Nome_Servico
            // 
            this.Nome_Servico.HeaderText = "Nome do Serviço";
            this.Nome_Servico.Name = "Nome_Servico";
            // 
            // Prc_Servico
            // 
            this.Prc_Servico.HeaderText = "Prç Serviço";
            this.Prc_Servico.Name = "Prc_Servico";
            // 
            // Btn_Apresentacao_Retorna
            // 
            this.Btn_Apresentacao_Retorna.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Apresentacao_Retorna.Location = new System.Drawing.Point(24, 338);
            this.Btn_Apresentacao_Retorna.Name = "Btn_Apresentacao_Retorna";
            this.Btn_Apresentacao_Retorna.Size = new System.Drawing.Size(89, 36);
            this.Btn_Apresentacao_Retorna.TabIndex = 1;
            this.Btn_Apresentacao_Retorna.Text = "Retorna";
            this.Btn_Apresentacao_Retorna.UseVisualStyleBackColor = true;
            this.Btn_Apresentacao_Retorna.Click += new System.EventHandler(this.Btn_Apresentacao_Retorna_Click);
            // 
            // Apresentacao_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.Btn_Apresentacao_Retorna);
            this.Controls.Add(this.Dgv_Apresentacao_Dados);
            this.Name = "Apresentacao_Dados";
            this.Text = "Apresentacao_Dados";
            this.Load += new System.EventHandler(this.Apresentacao_Dados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Apresentacao_Dados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Dgv_Apresentacao_Dados;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Nome_Cliente;
        private DataGridViewTextBoxColumn Bairro_Cliente;
        private DataGridViewTextBoxColumn Tel_Cliente;
        private DataGridViewTextBoxColumn Nome_Servico;
        private DataGridViewTextBoxColumn Prc_Servico;
        private Button Btn_Apresentacao_Retorna;
    }
}