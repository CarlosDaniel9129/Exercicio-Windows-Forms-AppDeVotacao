
namespace Eleicao2020.Views
{
    partial class Resultado
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_Candidato = new System.Windows.Forms.TableLayoutPanel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.tbl_Vencedor = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado da Eleição";
            // 
            // tbl_Candidato
            // 
            this.tbl_Candidato.AutoScroll = true;
            this.tbl_Candidato.AutoSize = true;
            this.tbl_Candidato.ColumnCount = 2;
            this.tbl_Candidato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Candidato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Candidato.Location = new System.Drawing.Point(32, 107);
            this.tbl_Candidato.Name = "tbl_Candidato";
            this.tbl_Candidato.RowCount = 1;
            this.tbl_Candidato.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Candidato.Size = new System.Drawing.Size(227, 119);
            this.tbl_Candidato.TabIndex = 1;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(347, 107);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(104, 53);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar Para Tela Inicial";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // tbl_Vencedor
            // 
            this.tbl_Vencedor.AutoScroll = true;
            this.tbl_Vencedor.AutoSize = true;
            this.tbl_Vencedor.ColumnCount = 2;
            this.tbl_Vencedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Vencedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Vencedor.Location = new System.Drawing.Point(289, 184);
            this.tbl_Vencedor.Name = "tbl_Vencedor";
            this.tbl_Vencedor.RowCount = 1;
            this.tbl_Vencedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_Vencedor.Size = new System.Drawing.Size(174, 42);
            this.tbl_Vencedor.TabIndex = 2;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(475, 304);
            this.Controls.Add(this.tbl_Vencedor);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.tbl_Candidato);
            this.Controls.Add(this.label1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tbl_Candidato;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TableLayoutPanel tbl_Vencedor;
    }
}