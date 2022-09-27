namespace Vistas
{
    partial class FrmMiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaludo = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(110, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi nombre es ";
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(247, 256);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(284, 115);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Accion";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(364, 102);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 34);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmMiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaludo);
            this.Name = "FrmMiForm";
            this.Text = "Mi primer formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btnSaludo;
        private TextBox textName;
    }
}