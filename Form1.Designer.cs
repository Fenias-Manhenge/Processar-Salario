namespace Processar_Salario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnFemenino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstCodigo = new System.Windows.Forms.ListBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.lstContacto = new System.Windows.Forms.ListBox();
            this.lstSexo = new System.Windows.Forms.ListBox();
            this.lstDiasTrab = new System.Windows.Forms.ListBox();
            this.lblContacto1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstSalario = new System.Windows.Forms.ListBox();
            this.lstSalMensal = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DADOS DO FUNCIONARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONTACTO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(118, 137);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(144, 20);
            this.txtContacto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DIAS TRABALHADOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SALARIO DIARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SEXO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnFemenino);
            this.panel1.Controls.Add(this.rbnMasculino);
            this.panel1.Location = new System.Drawing.Point(347, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 55);
            this.panel1.TabIndex = 10;
            // 
            // rbnFemenino
            // 
            this.rbnFemenino.AutoSize = true;
            this.rbnFemenino.Location = new System.Drawing.Point(118, 18);
            this.rbnFemenino.Name = "rbnFemenino";
            this.rbnFemenino.Size = new System.Drawing.Size(81, 17);
            this.rbnFemenino.TabIndex = 1;
            this.rbnFemenino.TabStop = true;
            this.rbnFemenino.Text = "FEMENINO";
            this.rbnFemenino.UseVisualStyleBackColor = true;
            this.rbnFemenino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(9, 18);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(88, 17);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "MASCULINO";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 181);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(465, 61);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 13;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(465, 99);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.btnProcessar);
            this.panel2.Location = new System.Drawing.Point(643, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 126);
            this.panel2.TabIndex = 15;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(10, 22);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(83, 33);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(10, 75);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(83, 34);
            this.btnProcessar.TabIndex = 17;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "OPERACOES";
            // 
            // lstCodigo
            // 
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(35, 292);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(88, 134);
            this.lstCodigo.TabIndex = 19;
            this.lstCodigo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.Location = new System.Drawing.Point(137, 292);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(93, 134);
            this.lstNome.TabIndex = 20;
            // 
            // lstContacto
            // 
            this.lstContacto.FormattingEnabled = true;
            this.lstContacto.Location = new System.Drawing.Point(246, 292);
            this.lstContacto.Name = "lstContacto";
            this.lstContacto.Size = new System.Drawing.Size(90, 134);
            this.lstContacto.TabIndex = 21;
            this.lstContacto.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // lstSexo
            // 
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.Location = new System.Drawing.Point(347, 292);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(90, 134);
            this.lstSexo.TabIndex = 22;
            // 
            // lstDiasTrab
            // 
            this.lstDiasTrab.FormattingEnabled = true;
            this.lstDiasTrab.Location = new System.Drawing.Point(452, 292);
            this.lstDiasTrab.Name = "lstDiasTrab";
            this.lstDiasTrab.Size = new System.Drawing.Size(94, 134);
            this.lstDiasTrab.TabIndex = 23;
            // 
            // lblContacto1
            // 
            this.lblContacto1.AutoSize = true;
            this.lblContacto1.Location = new System.Drawing.Point(243, 264);
            this.lblContacto1.Name = "lblContacto1";
            this.lblContacto1.Size = new System.Drawing.Size(50, 13);
            this.lblContacto1.TabIndex = 24;
            this.lblContacto1.Text = "Contacto";
            this.lblContacto1.Click += new System.EventHandler(this.lblContacto1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Sexo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(32, 264);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo1.TabIndex = 26;
            this.lblCodigo1.Text = "Codigo";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(134, 264);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(35, 13);
            this.lblNome1.TabIndex = 27;
            this.lblNome1.Text = "Nome";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(449, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "DIASTRAB";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lstSalario
            // 
            this.lstSalario.FormattingEnabled = true;
            this.lstSalario.Location = new System.Drawing.Point(562, 292);
            this.lstSalario.Name = "lstSalario";
            this.lstSalario.Size = new System.Drawing.Size(85, 134);
            this.lstSalario.TabIndex = 29;
            // 
            // lstSalMensal
            // 
            this.lstSalMensal.FormattingEnabled = true;
            this.lstSalMensal.Location = new System.Drawing.Point(668, 292);
            this.lstSalMensal.Name = "lstSalMensal";
            this.lstSalMensal.Size = new System.Drawing.Size(81, 134);
            this.lstSalMensal.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "SALARIO.DIA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(665, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "SALARIO.MENSAL";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstSalMensal);
            this.Controls.Add(this.lstSalario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblCodigo1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblContacto1);
            this.Controls.Add(this.lstDiasTrab);
            this.Controls.Add(this.lstSexo);
            this.Controls.Add(this.lstContacto);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.lstCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnFemenino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstCodigo;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.ListBox lstContacto;
        private System.Windows.Forms.ListBox lstSexo;
        private System.Windows.Forms.ListBox lstDiasTrab;
        private System.Windows.Forms.Label lblContacto1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstSalario;
        private System.Windows.Forms.ListBox lstSalMensal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

