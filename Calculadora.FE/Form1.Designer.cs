﻿namespace Calculadora.FE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOper1 = new System.Windows.Forms.TextBox();
            this.txtOper2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btSumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOper1
            // 
            this.txtOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOper1.Location = new System.Drawing.Point(50, 32);
            this.txtOper1.Name = "txtOper1";
            this.txtOper1.Size = new System.Drawing.Size(157, 32);
            this.txtOper1.TabIndex = 0;
            // 
            // txtOper2
            // 
            this.txtOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOper2.Location = new System.Drawing.Point(306, 32);
            this.txtOper2.Name = "txtOper2";
            this.txtOper2.Size = new System.Drawing.Size(157, 32);
            this.txtOper2.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(50, 117);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(157, 32);
            this.txtResultado.TabIndex = 3;
            // 
            // btSumar
            // 
            this.btSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSumar.Location = new System.Drawing.Point(230, 32);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(54, 48);
            this.btSumar.TabIndex = 4;
            this.btSumar.Text = "+";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operador 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.ForeColor = System.Drawing.Color.Red;
            this.btMultiplicar.Location = new System.Drawing.Point(382, 101);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(81, 48);
            this.btMultiplicar.TabIndex = 8;
            this.btMultiplicar.Text = "Prueba";
            this.btMultiplicar.UseVisualStyleBackColor = false;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtOper2);
            this.Controls.Add(this.txtOper1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOper1;
        private System.Windows.Forms.TextBox txtOper2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btMultiplicar;
    }
}

