namespace sistemaAcoes.View
{
    partial class TelaPesquisaPorNome
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
            botao_pesquisar = new Button();
            texto_Ativo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            codigoAtivo = new DataGridViewTextBoxColumn();
            tipoAtivo = new DataGridViewTextBoxColumn();
            dataCompraAtivo = new DataGridViewTextBoxColumn();
            qtdAtivos = new DataGridViewTextBoxColumn();
            precoAtivo = new DataGridViewTextBoxColumn();
            custoAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botao_pesquisar
            // 
            botao_pesquisar.Location = new Point(524, 108);
            botao_pesquisar.Name = "botao_pesquisar";
            botao_pesquisar.Size = new Size(131, 23);
            botao_pesquisar.TabIndex = 8;
            botao_pesquisar.Text = "Pesquisar";
            botao_pesquisar.UseVisualStyleBackColor = true;
            botao_pesquisar.Click += botao_pesquisar_Click;
            // 
            // texto_Ativo
            // 
            texto_Ativo.Location = new Point(264, 109);
            texto_Ativo.Name = "texto_Ativo";
            texto_Ativo.Size = new Size(213, 23);
            texto_Ativo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(65, 107);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 6;
            label2.Text = "Digite o Nome do Ativo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 23);
            label1.Name = "label1";
            label1.Size = new Size(284, 40);
            label1.TabIndex = 5;
            label1.Text = "Pesquisa por Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigoAtivo, tipoAtivo, dataCompraAtivo, qtdAtivos, precoAtivo, custoAtivo });
            dataGridView1.Location = new Point(88, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(603, 252);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // codigoAtivo
            // 
            codigoAtivo.HeaderText = "Código";
            codigoAtivo.Name = "codigoAtivo";
            // 
            // tipoAtivo
            // 
            tipoAtivo.HeaderText = "Tipo";
            tipoAtivo.Name = "tipoAtivo";
            // 
            // dataCompraAtivo
            // 
            dataCompraAtivo.HeaderText = "Data da Compra";
            dataCompraAtivo.Name = "dataCompraAtivo";
            // 
            // qtdAtivos
            // 
            qtdAtivos.HeaderText = "Quantidade";
            qtdAtivos.Name = "qtdAtivos";
            // 
            // precoAtivo
            // 
            precoAtivo.HeaderText = "Preço";
            precoAtivo.Name = "precoAtivo";
            // 
            // custoAtivo
            // 
            custoAtivo.HeaderText = "Custo";
            custoAtivo.Name = "custoAtivo";
            // 
            // TelaPesquisaPorNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(botao_pesquisar);
            Controls.Add(texto_Ativo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaPesquisaPorNome";
            Text = "TelaPesquisaPorNome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_pesquisar;
        private TextBox texto_Ativo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigoAtivo;
        private DataGridViewTextBoxColumn tipoAtivo;
        private DataGridViewTextBoxColumn dataCompraAtivo;
        private DataGridViewTextBoxColumn qtdAtivos;
        private DataGridViewTextBoxColumn precoAtivo;
        private DataGridViewTextBoxColumn custoAtivo;
    }
}