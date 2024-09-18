namespace sistemaAcoes.View
{
    partial class TelaPesquisaPorCodigo
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
            groupBox1 = new GroupBox();
            data = new DateTimePicker();
            texto_quantidade = new TextBox();
            texto_preco = new TextBox();
            texto_ativo = new TextBox();
            texto_tipo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            texto_codigo = new TextBox();
            botao_pesquisar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(data);
            groupBox1.Controls.Add(texto_quantidade);
            groupBox1.Controls.Add(texto_preco);
            groupBox1.Controls.Add(texto_ativo);
            groupBox1.Controls.Add(texto_tipo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(45, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 242);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // data
            // 
            data.Location = new Point(186, 125);
            data.Name = "data";
            data.Size = new Size(257, 23);
            data.TabIndex = 9;
            data.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // texto_quantidade
            // 
            texto_quantidade.Location = new Point(532, 197);
            texto_quantidade.Name = "texto_quantidade";
            texto_quantidade.Size = new Size(152, 23);
            texto_quantidade.TabIndex = 8;
            // 
            // texto_preco
            // 
            texto_preco.Location = new Point(87, 199);
            texto_preco.Name = "texto_preco";
            texto_preco.Size = new Size(157, 23);
            texto_preco.TabIndex = 7;
            // 
            // texto_ativo
            // 
            texto_ativo.Location = new Point(127, 88);
            texto_ativo.Name = "texto_ativo";
            texto_ativo.Size = new Size(204, 23);
            texto_ativo.TabIndex = 6;
            // 
            // texto_tipo
            // 
            texto_tipo.Location = new Point(170, 38);
            texto_tipo.Name = "texto_tipo";
            texto_tipo.Size = new Size(161, 23);
            texto_tipo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(432, 197);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 4;
            label7.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(29, 197);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 3;
            label6.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(41, 125);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 2;
            label5.Text = "Data da Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(72, 86);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 1;
            label4.Text = "Ativo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 40);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 0;
            label3.Text = "Tipo de Ativo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 24);
            label1.Name = "label1";
            label1.Size = new Size(298, 40);
            label1.TabIndex = 0;
            label1.Text = "Pesquisa por Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(45, 108);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 2;
            label2.Text = "Digite o Código do Ativo:";
            // 
            // texto_codigo
            // 
            texto_codigo.Location = new Point(244, 110);
            texto_codigo.Name = "texto_codigo";
            texto_codigo.Size = new Size(213, 23);
            texto_codigo.TabIndex = 3;
            texto_codigo.TextChanged += texto_codigo_TextChanged;
            // 
            // botao_pesquisar
            // 
            botao_pesquisar.Location = new Point(504, 109);
            botao_pesquisar.Name = "botao_pesquisar";
            botao_pesquisar.Size = new Size(131, 23);
            botao_pesquisar.TabIndex = 4;
            botao_pesquisar.Text = "Pesquisar";
            botao_pesquisar.UseVisualStyleBackColor = true;
            botao_pesquisar.Click += botao_pesquisar_Click;
            // 
            // TelaPesquisaPorCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(botao_pesquisar);
            Controls.Add(texto_codigo);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TelaPesquisaPorCodigo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private DateTimePicker data;
        private TextBox texto_quantidade;
        private TextBox texto_preco;
        private TextBox texto_ativo;
        private TextBox texto_tipo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox texto_codigo;
        private Button botao_pesquisar;
    }
}