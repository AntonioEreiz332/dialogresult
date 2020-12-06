namespace MessageBox
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
            this.btnOtvori = new System.Windows.Forms.Button();
            this.txtboxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(321, 97);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(171, 24);
            this.btnOtvori.TabIndex = 0;
            this.btnOtvori.Text = "Otvorite MessageBox";
            this.btnOtvori.UseVisualStyleBackColor = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // txtboxRezultat
            // 
            this.txtboxRezultat.Location = new System.Drawing.Point(292, 146);
            this.txtboxRezultat.Multiline = true;
            this.txtboxRezultat.Name = "txtboxRezultat";
            this.txtboxRezultat.Size = new System.Drawing.Size(231, 117);
            this.txtboxRezultat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 443);
            this.Controls.Add(this.txtboxRezultat);
            this.Controls.Add(this.btnOtvori);
            this.Name = "Form1";
            this.Text = "Upotreba DialogResult enumeracije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.TextBox txtboxRezultat;
    }
}

