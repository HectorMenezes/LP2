﻿namespace Aula9
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
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.btnEx4 = new System.Windows.Forms.Button();
            this.btnEx5 = new System.Windows.Forms.Button();
            this.btnEx6 = new System.Windows.Forms.Button();
            this.btnEx7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(12, 12);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(139, 71);
            this.btnEx1.TabIndex = 0;
            this.btnEx1.Text = "Ler 20 números";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx1_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(157, 12);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(139, 71);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "Usando Reverse";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(302, 12);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(139, 71);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Mercadorias";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // btnEx4
            // 
            this.btnEx4.Location = new System.Drawing.Point(10, 89);
            this.btnEx4.Name = "btnEx4";
            this.btnEx4.Size = new System.Drawing.Size(141, 71);
            this.btnEx4.TabIndex = 3;
            this.btnEx4.Text = "Variável Total";
            this.btnEx4.UseVisualStyleBackColor = true;
            this.btnEx4.Click += new System.EventHandler(this.btnEx4_Click);
            // 
            // btnEx5
            // 
            this.btnEx5.Location = new System.Drawing.Point(157, 89);
            this.btnEx5.Name = "btnEx5";
            this.btnEx5.Size = new System.Drawing.Size(139, 71);
            this.btnEx5.TabIndex = 4;
            this.btnEx5.Text = "Uso ArrayList";
            this.btnEx5.UseVisualStyleBackColor = true;
            this.btnEx5.Click += new System.EventHandler(this.btnEx5_Click);
            // 
            // btnEx6
            // 
            this.btnEx6.Location = new System.Drawing.Point(302, 89);
            this.btnEx6.Name = "btnEx6";
            this.btnEx6.Size = new System.Drawing.Size(139, 71);
            this.btnEx6.TabIndex = 5;
            this.btnEx6.Text = "Média 20 alunos em 3 disciplinas";
            this.btnEx6.UseVisualStyleBackColor = true;
            this.btnEx6.Click += new System.EventHandler(this.btnEx6_Click);
            // 
            // btnEx7
            // 
            this.btnEx7.Location = new System.Drawing.Point(10, 166);
            this.btnEx7.Name = "btnEx7";
            this.btnEx7.Size = new System.Drawing.Size(139, 71);
            this.btnEx7.TabIndex = 6;
            this.btnEx7.Text = "Número de pessoas";
            this.btnEx7.UseVisualStyleBackColor = true;
            this.btnEx7.Click += new System.EventHandler(this.btnEx7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEx7);
            this.Controls.Add(this.btnEx6);
            this.Controls.Add(this.btnEx5);
            this.Controls.Add(this.btnEx4);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.btnEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Button btnEx4;
        private System.Windows.Forms.Button btnEx5;
        private System.Windows.Forms.Button btnEx6;
        private System.Windows.Forms.Button btnEx7;
    }
}

