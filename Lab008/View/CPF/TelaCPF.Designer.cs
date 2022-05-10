
namespace Lab008.View.CPF
{
    partial class lblCpf
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCpf = new System.Windows.Forms.TextBox();
            this.btnCpf = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validar o Número do CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // tbxCpf
            // 
            this.tbxCpf.Location = new System.Drawing.Point(94, 157);
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(237, 23);
            this.tbxCpf.TabIndex = 2;
            this.tbxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCpf
            // 
            this.btnCpf.Location = new System.Drawing.Point(353, 157);
            this.btnCpf.Name = "btnCpf";
            this.btnCpf.Size = new System.Drawing.Size(75, 23);
            this.btnCpf.TabIndex = 3;
            this.btnCpf.Text = "Validar";
            this.btnCpf.UseVisualStyleBackColor = true;
            this.btnCpf.Click += new System.EventHandler(this.btnCpf_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultado.Location = new System.Drawing.Point(50, 211);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(367, 98);
            this.lblResultado.TabIndex = 4;
            // 
            // lblCpf
            // 
            this.AcceptButton = this.btnCpf;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCpf);
            this.Controls.Add(this.tbxCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lblCpf";
            this.Text = "Sistema de CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCpf;
        private System.Windows.Forms.Button btnCpf;
        private System.Windows.Forms.Label lblResultado;
    }
}