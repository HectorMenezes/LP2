﻿namespace P0030481921028
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
            this.btnVer = new System.Windows.Forms.Button();
            this.lbxDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(24, 12);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(151, 107);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Verificar";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lbxDados
            // 
            this.lbxDados.FormattingEnabled = true;
            this.lbxDados.ItemHeight = 16;
            this.lbxDados.Location = new System.Drawing.Point(442, 12);
            this.lbxDados.Name = "lbxDados";
            this.lbxDados.Size = new System.Drawing.Size(346, 420);
            this.lbxDados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxDados);
            this.Controls.Add(this.btnVer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ListBox lbxDados;
    }
}

