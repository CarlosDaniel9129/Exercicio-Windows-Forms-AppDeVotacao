
namespace Eleicao2020.Views
{
    partial class Votacao
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
            this.btn_votar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Candidato = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_votar
            // 
            this.btn_votar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_votar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_votar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_votar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_votar.Location = new System.Drawing.Point(319, 186);
            this.btn_votar.Name = "btn_votar";
            this.btn_votar.Size = new System.Drawing.Size(104, 53);
            this.btn_votar.TabIndex = 0;
            this.btn_votar.Text = "Votar";
            this.btn_votar.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(319, 87);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(104, 53);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar para Tela Inicial";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Votação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Candidato:";
            // 
            // cmb_Candidato
            // 
            this.cmb_Candidato.FormattingEnabled = true;
            this.cmb_Candidato.Items.AddRange(new object[] {
            "aaaaaa"});
            this.cmb_Candidato.Location = new System.Drawing.Point(87, 130);
            this.cmb_Candidato.Name = "cmb_Candidato";
            this.cmb_Candidato.Size = new System.Drawing.Size(121, 21);
            this.cmb_Candidato.TabIndex = 4;
            // 
            // Votacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 304);
            this.Controls.Add(this.cmb_Candidato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_votar);
            this.Name = "Votacao";
            this.Text = "Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_votar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Candidato;
    }
}