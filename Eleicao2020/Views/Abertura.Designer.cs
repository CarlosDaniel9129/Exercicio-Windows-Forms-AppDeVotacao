
namespace Eleicao2020.Views
{
    partial class Abertura
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
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_iniciarVoto = new System.Windows.Forms.Button();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.Location = new System.Drawing.Point(12, 154);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(129, 95);
            this.btn_cadastro.TabIndex = 0;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_iniciarVoto
            // 
            this.btn_iniciarVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarVoto.Location = new System.Drawing.Point(162, 154);
            this.btn_iniciarVoto.Name = "btn_iniciarVoto";
            this.btn_iniciarVoto.Size = new System.Drawing.Size(136, 95);
            this.btn_iniciarVoto.TabIndex = 1;
            this.btn_iniciarVoto.Text = "Iniciar Votação";
            this.btn_iniciarVoto.UseVisualStyleBackColor = true;
            // 
            // btn_resultado
            // 
            this.btn_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resultado.Location = new System.Drawing.Point(320, 154);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(143, 95);
            this.btn_resultado.TabIndex = 2;
            this.btn_resultado.Text = "Ver Resultados";
            this.btn_resultado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eleições 2020";
            // 
            // Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.btn_iniciarVoto);
            this.Controls.Add(this.btn_cadastro);
            this.Name = "Abertura";
            this.Text = "Abertura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_iniciarVoto;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label label1;
    }
}