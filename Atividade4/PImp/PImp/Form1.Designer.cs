namespace PImp
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
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblAliqIRPF = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.DescIRPF = new System.Windows.Forms.Label();
            this.SalFami = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cbCasado = new System.Windows.Forms.CheckBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.mTxtNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mTxtNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mTxtAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mTxtAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalFam = new System.Windows.Forms.MaskedTextBox();
            this.mTxtSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDados = new System.Windows.Forms.MaskedTextBox();
            this.bntVeri = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(32, 26);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(139, 17);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome do funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(32, 68);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(90, 17);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(32, 98);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(115, 17);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(38, 246);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(49, 17);
            this.lblDados.TabIndex = 3;
            this.lblDados.Text = "Dados";
            this.lblDados.Click += new System.EventHandler(this.lblDados_Click);
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Location = new System.Drawing.Point(59, 292);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(94, 17);
            this.lblAliqINSS.TabIndex = 4;
            this.lblAliqINSS.Text = "Alíquota INSS";
            this.lblAliqINSS.Click += new System.EventHandler(this.lblAliqINSS_Click);
            // 
            // lblAliqIRPF
            // 
            this.lblAliqIRPF.AutoSize = true;
            this.lblAliqIRPF.Location = new System.Drawing.Point(59, 333);
            this.lblAliqIRPF.Name = "lblAliqIRPF";
            this.lblAliqIRPF.Size = new System.Drawing.Size(93, 17);
            this.lblAliqIRPF.TabIndex = 5;
            this.lblAliqIRPF.Text = "Alíquota IRPF";
            this.lblAliqIRPF.Click += new System.EventHandler(this.lblAliqIRPF_Click);
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(59, 459);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(102, 17);
            this.lblSalLiq.TabIndex = 6;
            this.lblSalLiq.Text = "Salário Líquido";
            this.lblSalLiq.Click += new System.EventHandler(this.lblSalLiq_Click);
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(316, 292);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(103, 17);
            this.lblDescINSS.TabIndex = 7;
            this.lblDescINSS.Text = "Desconto INSS";
            this.lblDescINSS.Click += new System.EventHandler(this.lblDescINSS_Click);
            // 
            // DescIRPF
            // 
            this.DescIRPF.AutoSize = true;
            this.DescIRPF.Location = new System.Drawing.Point(316, 336);
            this.DescIRPF.Name = "DescIRPF";
            this.DescIRPF.Size = new System.Drawing.Size(102, 17);
            this.DescIRPF.TabIndex = 8;
            this.DescIRPF.Text = "Desconto IRPF";
            this.DescIRPF.Click += new System.EventHandler(this.DescIRPF_Click);
            // 
            // SalFami
            // 
            this.SalFami.AutoSize = true;
            this.SalFami.Location = new System.Drawing.Point(59, 400);
            this.SalFami.Name = "SalFami";
            this.SalFami.Size = new System.Drawing.Size(100, 17);
            this.SalFami.TabIndex = 10;
            this.SalFami.Text = "Salario Família";
            this.SalFami.Click += new System.EventHandler(this.SalFami_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbF);
            this.gbSexo.Controls.Add(this.rbM);
            this.gbSexo.Location = new System.Drawing.Point(395, 21);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 100);
            this.gbSexo.TabIndex = 11;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // cbCasado
            // 
            this.cbCasado.AutoSize = true;
            this.cbCasado.Location = new System.Drawing.Point(395, 132);
            this.cbCasado.Name = "cbCasado";
            this.cbCasado.Size = new System.Drawing.Size(78, 21);
            this.cbCasado.TabIndex = 12;
            this.cbCasado.Text = "Casado";
            this.cbCasado.UseVisualStyleBackColor = true;
            this.cbCasado.CheckedChanged += new System.EventHandler(this.cbCasado_CheckedChanged);
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(15, 21);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(37, 21);
            this.rbF.TabIndex = 13;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(15, 63);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(40, 21);
            this.rbM.TabIndex = 14;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // mTxtNomeFunc
            // 
            this.mTxtNomeFunc.Location = new System.Drawing.Point(261, 21);
            this.mTxtNomeFunc.Name = "mTxtNomeFunc";
            this.mTxtNomeFunc.Size = new System.Drawing.Size(100, 22);
            this.mTxtNomeFunc.TabIndex = 13;
            // 
            // mTxtSalBruto
            // 
            this.mTxtSalBruto.Location = new System.Drawing.Point(261, 52);
            this.mTxtSalBruto.Mask = "9999.99";
            this.mTxtSalBruto.Name = "mTxtSalBruto";
            this.mTxtSalBruto.Size = new System.Drawing.Size(100, 22);
            this.mTxtSalBruto.TabIndex = 14;
            // 
            // mTxtNumFilhos
            // 
            this.mTxtNumFilhos.Location = new System.Drawing.Point(261, 93);
            this.mTxtNumFilhos.Mask = "##";
            this.mTxtNumFilhos.Name = "mTxtNumFilhos";
            this.mTxtNumFilhos.Size = new System.Drawing.Size(100, 22);
            this.mTxtNumFilhos.TabIndex = 15;
            // 
            // mTxtAliqINSS
            // 
            this.mTxtAliqINSS.Enabled = false;
            this.mTxtAliqINSS.Location = new System.Drawing.Point(210, 287);
            this.mTxtAliqINSS.Name = "mTxtAliqINSS";
            this.mTxtAliqINSS.Size = new System.Drawing.Size(100, 22);
            this.mTxtAliqINSS.TabIndex = 17;
            this.mTxtAliqINSS.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtAliqINSS_MaskInputRejected);
            // 
            // mTxtDescINSS
            // 
            this.mTxtDescINSS.Enabled = false;
            this.mTxtDescINSS.Location = new System.Drawing.Point(434, 289);
            this.mTxtDescINSS.Name = "mTxtDescINSS";
            this.mTxtDescINSS.Size = new System.Drawing.Size(100, 22);
            this.mTxtDescINSS.TabIndex = 18;
            this.mTxtDescINSS.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtDescINSS_MaskInputRejected);
            // 
            // mTxtAliqIRPF
            // 
            this.mTxtAliqIRPF.Enabled = false;
            this.mTxtAliqIRPF.Location = new System.Drawing.Point(210, 333);
            this.mTxtAliqIRPF.Name = "mTxtAliqIRPF";
            this.mTxtAliqIRPF.Size = new System.Drawing.Size(100, 22);
            this.mTxtAliqIRPF.TabIndex = 19;
            this.mTxtAliqIRPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtAliqIRPF_MaskInputRejected);
            // 
            // mTxtDescIRPF
            // 
            this.mTxtDescIRPF.Enabled = false;
            this.mTxtDescIRPF.Location = new System.Drawing.Point(434, 333);
            this.mTxtDescIRPF.Name = "mTxtDescIRPF";
            this.mTxtDescIRPF.Size = new System.Drawing.Size(100, 22);
            this.mTxtDescIRPF.TabIndex = 20;
            this.mTxtDescIRPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtDescIRPF_MaskInputRejected);
            // 
            // mTxtSalFam
            // 
            this.mTxtSalFam.Enabled = false;
            this.mTxtSalFam.Location = new System.Drawing.Point(210, 397);
            this.mTxtSalFam.Name = "mTxtSalFam";
            this.mTxtSalFam.Size = new System.Drawing.Size(100, 22);
            this.mTxtSalFam.TabIndex = 21;
            this.mTxtSalFam.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtSalFam_MaskInputRejected);
            // 
            // mTxtSalLiq
            // 
            this.mTxtSalLiq.Enabled = false;
            this.mTxtSalLiq.Location = new System.Drawing.Point(210, 454);
            this.mTxtSalLiq.Name = "mTxtSalLiq";
            this.mTxtSalLiq.Size = new System.Drawing.Size(100, 22);
            this.mTxtSalLiq.TabIndex = 22;
            this.mTxtSalLiq.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtSalLiq_MaskInputRejected);
            // 
            // mTxtDados
            // 
            this.mTxtDados.Enabled = false;
            this.mTxtDados.Location = new System.Drawing.Point(111, 241);
            this.mTxtDados.Name = "mTxtDados";
            this.mTxtDados.Size = new System.Drawing.Size(423, 22);
            this.mTxtDados.TabIndex = 23;
            this.mTxtDados.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtDados_MaskInputRejected);
            // 
            // bntVeri
            // 
            this.bntVeri.Location = new System.Drawing.Point(35, 166);
            this.bntVeri.Name = "bntVeri";
            this.bntVeri.Size = new System.Drawing.Size(173, 23);
            this.bntVeri.TabIndex = 24;
            this.bntVeri.Text = "Verificar Descontos";
            this.bntVeri.UseVisualStyleBackColor = true;
            this.bntVeri.Click += new System.EventHandler(this.bntVeri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 598);
            this.Controls.Add(this.bntVeri);
            this.Controls.Add(this.mTxtDados);
            this.Controls.Add(this.mTxtSalLiq);
            this.Controls.Add(this.mTxtSalFam);
            this.Controls.Add(this.mTxtDescIRPF);
            this.Controls.Add(this.mTxtAliqIRPF);
            this.Controls.Add(this.mTxtDescINSS);
            this.Controls.Add(this.mTxtAliqINSS);
            this.Controls.Add(this.mTxtNumFilhos);
            this.Controls.Add(this.mTxtSalBruto);
            this.Controls.Add(this.mTxtNomeFunc);
            this.Controls.Add(this.cbCasado);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.SalFami);
            this.Controls.Add(this.DescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblAliqIRPF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblAliqIRPF;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label DescIRPF;
        private System.Windows.Forms.Label SalFami;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.CheckBox cbCasado;
        private System.Windows.Forms.MaskedTextBox mTxtNomeFunc;
        private System.Windows.Forms.MaskedTextBox mTxtSalBruto;
        private System.Windows.Forms.MaskedTextBox mTxtNumFilhos;
        private System.Windows.Forms.MaskedTextBox mTxtAliqINSS;
        private System.Windows.Forms.MaskedTextBox mTxtDescINSS;
        private System.Windows.Forms.MaskedTextBox mTxtAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mTxtDescIRPF;
        private System.Windows.Forms.MaskedTextBox mTxtSalFam;
        private System.Windows.Forms.MaskedTextBox mTxtSalLiq;
        private System.Windows.Forms.MaskedTextBox mTxtDados;
        private System.Windows.Forms.Button bntVeri;
    }
}

