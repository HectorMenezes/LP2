namespace PVolume
{
    partial class Form1
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
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelRaio = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(35, 39);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(34, 13);
            this.labelAltura.TabIndex = 0;
            this.labelAltura.Text = "Altura";
            this.labelAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRaio
            // 
            this.labelRaio.AutoSize = true;
            this.labelRaio.Location = new System.Drawing.Point(35, 83);
            this.labelRaio.Name = "labelRaio";
            this.labelRaio.Size = new System.Drawing.Size(29, 13);
            this.labelRaio.TabIndex = 1;
            this.labelRaio.Text = "Raio";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(97, 39);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(182, 20);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(97, 80);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(182, 20);
            this.txtRaio.TabIndex = 3;
            this.txtRaio.TextChanged += new System.EventHandler(this.txtRaio_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(113, 134);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(166, 20);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(97, 180);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(74, 44);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(34, 137);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.labelRaio);
            this.Controls.Add(this.labelAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label labelResultado;
    }
}

