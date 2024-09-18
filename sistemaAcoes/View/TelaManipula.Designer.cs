namespace sistemaAcoes.View
{
    partial class TelaManipula
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
            texto_codigo = new TextBox();
            label2 = new Label();
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
            botao_alterar = new Button();
            botao_excluir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // botao_pesquisar
            // 
            botao_pesquisar.Location = new Point(537, 117);
            botao_pesquisar.Name = "botao_pesquisar";
            botao_pesquisar.Size = new Size(117, 23);
            botao_pesquisar.TabIndex = 9;
            botao_pesquisar.Text = "Pesquisar";
            botao_pesquisar.UseVisualStyleBackColor = true;
            botao_pesquisar.Click += botao_pesquisar_Click;
            // 
            // texto_codigo
            // 
            texto_codigo.Location = new Point(248, 117);
            texto_codigo.Name = "texto_codigo";
            texto_codigo.Size = new Size(263, 23);
            texto_codigo.TabIndex = 8;
            texto_codigo.TextChanged += texto_codigo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(49, 115);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 7;
            label2.Text = "Digite o Código da Ação:";
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
            groupBox1.Location = new Point(49, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 215);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // data
            // 
            data.Location = new Point(168, 116);
            data.Name = "data";
            data.Size = new Size(200, 23);
            data.TabIndex = 9;
            // 
            // texto_quantidade
            // 
            texto_quantidade.Location = new Point(512, 172);
            texto_quantidade.Name = "texto_quantidade";
            texto_quantidade.Size = new Size(146, 23);
            texto_quantidade.TabIndex = 8;
            // 
            // texto_preco
            // 
            texto_preco.Location = new Point(115, 174);
            texto_preco.Name = "texto_preco";
            texto_preco.Size = new Size(155, 23);
            texto_preco.TabIndex = 7;
            // 
            // texto_ativo
            // 
            texto_ativo.Location = new Point(127, 80);
            texto_ativo.Name = "texto_ativo";
            texto_ativo.Size = new Size(188, 23);
            texto_ativo.TabIndex = 6;
            // 
            // texto_tipo
            // 
            texto_tipo.Location = new Point(159, 50);
            texto_tipo.Name = "texto_tipo";
            texto_tipo.Size = new Size(188, 23);
            texto_tipo.TabIndex = 5;
            texto_tipo.TextChanged += texto_tipo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(412, 172);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 4;
            label7.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(57, 172);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 3;
            label6.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(39, 117);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 2;
            label5.Text = "Data da Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(72, 78);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 1;
            label4.Text = "Ativo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(49, 48);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 0;
            label3.Text = "Tipo de Ativo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 29);
            label1.Name = "label1";
            label1.Size = new Size(363, 40);
            label1.TabIndex = 5;
            label1.Text = "Gerenciamento de Ativos";
            // 
            // botao_alterar
            // 
            botao_alterar.Location = new Point(109, 410);
            botao_alterar.Name = "botao_alterar";
            botao_alterar.Size = new Size(93, 28);
            botao_alterar.TabIndex = 10;
            botao_alterar.Text = "Alterar";
            botao_alterar.UseVisualStyleBackColor = true;
            botao_alterar.Click += botao_alterar_Click;
            // 
            // botao_excluir
            // 
            botao_excluir.Location = new Point(600, 410);
            botao_excluir.Name = "botao_excluir";
            botao_excluir.Size = new Size(91, 28);
            botao_excluir.TabIndex = 11;
            botao_excluir.Text = "Excluir";
            botao_excluir.UseVisualStyleBackColor = true;
            botao_excluir.Click += botao_excluir_Click;
            // 
            // TelaManipula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(botao_excluir);
            Controls.Add(botao_alterar);
            Controls.Add(botao_pesquisar);
            Controls.Add(texto_codigo);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TelaManipula";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_pesquisar;
        private TextBox texto_codigo;
        private Label label2;
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
        private Button botao_alterar;
        private Button botao_excluir;
    }
}