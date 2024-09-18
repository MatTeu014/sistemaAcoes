namespace sistemaAcoes.View
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            texto_tipo = new ComboBox();
            texto_ativo = new TextBox();
            numerico_quantidade = new NumericUpDown();
            data = new DateTimePicker();
            texto_custos = new TextBox();
            texto_preco = new TextBox();
            texto_total = new Label();
            botao_cancelar = new Button();
            botao_Salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)numerico_quantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 22);
            label1.Name = "label1";
            label1.Size = new Size(282, 40);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Transação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(149, 127);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Ativo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(149, 182);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Ativo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 241);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Data da Compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(439, 192);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "Preço em R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(439, 127);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 5;
            label6.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(439, 241);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 6;
            label7.Text = "Outros Custos";
            label7.Click += label7_Click;
            // 
            // texto_tipo
            // 
            texto_tipo.FormattingEnabled = true;
            texto_tipo.Items.AddRange(new object[] { "Ações", "Fundos de Investimentos", "FIIS", "Criptmoedas", "Stock", "Reit", "BDRS", "ETFS", "ETFS Internacionais", "Tesouro Direto", "Renda Fixa", "Outros" });
            texto_tipo.Location = new Point(149, 151);
            texto_tipo.Name = "texto_tipo";
            texto_tipo.Size = new Size(187, 23);
            texto_tipo.TabIndex = 7;
            texto_tipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // texto_ativo
            // 
            texto_ativo.Location = new Point(149, 205);
            texto_ativo.Name = "texto_ativo";
            texto_ativo.Size = new Size(187, 23);
            texto_ativo.TabIndex = 8;
            // 
            // numerico_quantidade
            // 
            numerico_quantidade.Location = new Point(439, 152);
            numerico_quantidade.Name = "numerico_quantidade";
            numerico_quantidade.Size = new Size(187, 23);
            numerico_quantidade.TabIndex = 9;
            numerico_quantidade.ValueChanged += calculartotal;
            // 
            // data
            // 
            data.Location = new Point(149, 264);
            data.Name = "data";
            data.Size = new Size(187, 23);
            data.TabIndex = 11;
            // 
            // texto_custos
            // 
            texto_custos.Location = new Point(439, 264);
            texto_custos.Name = "texto_custos";
            texto_custos.Size = new Size(187, 23);
            texto_custos.TabIndex = 12;
            texto_custos.TextChanged += calculartotal;
            // 
            // texto_preco
            // 
            texto_preco.Location = new Point(439, 215);
            texto_preco.Name = "texto_preco";
            texto_preco.Size = new Size(187, 23);
            texto_preco.TabIndex = 13;
            texto_preco.Text = "0,00";
            texto_preco.TextChanged += calculartotal;
            // 
            // texto_total
            // 
            texto_total.BackColor = SystemColors.ActiveCaption;
            texto_total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto_total.Location = new Point(216, 323);
            texto_total.Name = "texto_total";
            texto_total.Size = new Size(334, 48);
            texto_total.TabIndex = 14;
            texto_total.Text = "Valor Total:";
            texto_total.TextAlign = ContentAlignment.MiddleCenter;
            texto_total.TextChanged += botao_calcular_Click;
            texto_total.Click += label8_Click;
            // 
            // botao_cancelar
            // 
            botao_cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao_cancelar.Location = new Point(174, 395);
            botao_cancelar.Name = "botao_cancelar";
            botao_cancelar.Size = new Size(129, 32);
            botao_cancelar.TabIndex = 15;
            botao_cancelar.Text = "Cancelar";
            botao_cancelar.UseVisualStyleBackColor = true;
            // 
            // botao_Salvar
            // 
            botao_Salvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao_Salvar.Location = new Point(469, 395);
            botao_Salvar.Name = "botao_Salvar";
            botao_Salvar.Size = new Size(129, 32);
            botao_Salvar.TabIndex = 16;
            botao_Salvar.Text = "Salvar";
            botao_Salvar.UseVisualStyleBackColor = true;
            botao_Salvar.Click += botao_Salvar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(botao_Salvar);
            Controls.Add(botao_cancelar);
            Controls.Add(texto_total);
            Controls.Add(texto_preco);
            Controls.Add(texto_custos);
            Controls.Add(data);
            Controls.Add(numerico_quantidade);
            Controls.Add(texto_ativo);
            Controls.Add(texto_tipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)numerico_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox texto_tipo;
        private TextBox texto_ativo;
        private NumericUpDown numerico_quantidade;
        private DateTimePicker data;
        private TextBox texto_custos;
        private TextBox texto_preco;
        private Label texto_total;
        private Button botao_cancelar;
        private Button botao_Salvar;
    }
}