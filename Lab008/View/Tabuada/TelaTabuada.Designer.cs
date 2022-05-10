
namespace Lab008.View.Tabuada
{
    partial class TelaTabuada
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
            this.tbxTabuada = new System.Windows.Forms.TextBox();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular a Tabuada";
            // 
            // tbxTabuada
            // 
            this.tbxTabuada.Location = new System.Drawing.Point(165, 100);
            this.tbxTabuada.Name = "tbxTabuada";
            this.tbxTabuada.Size = new System.Drawing.Size(220, 23);
            this.tbxTabuada.TabIndex = 3;
            // 
            // lbxResultado
            // 
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 15;
            this.lbxResultado.Location = new System.Drawing.Point(105, 154);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(361, 274);
            this.lbxResultado.TabIndex = 5;
            // 
            // TelaTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 444);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.tbxTabuada);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "TelaTabuada";
            this.ShowIcon = false;
            this.Text = "Sistema de Tabuada";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaTabuada_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTabuada;
        private System.Windows.Forms.ListBox lbxResultado;
    }
}