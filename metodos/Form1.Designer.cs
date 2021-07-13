
namespace metodos
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
            this.botao1 = new System.Windows.Forms.Button();
            this.caixatex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(492, 178);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(359, 96);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "executa";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // caixatex
            // 
            this.caixatex.AutoSize = true;
            this.caixatex.Location = new System.Drawing.Point(194, 139);
            this.caixatex.Margin = new System.Windows.Forms.Padding(5, 8, 6, 0);
            this.caixatex.MaximumSize = new System.Drawing.Size(550, 700);
            this.caixatex.MinimumSize = new System.Drawing.Size(550, 0);
            this.caixatex.Name = "caixatex";
            this.caixatex.Size = new System.Drawing.Size(550, 17);
            this.caixatex.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(852, 273);
            this.Controls.Add(this.caixatex);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label caixa_txt;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label caixatex;
    }
}

