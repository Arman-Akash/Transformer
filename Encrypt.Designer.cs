namespace Transformer
{
    partial class Encrypt
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
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rePasswordText = new System.Windows.Forms.TextBox();
            this.checkEncyPassBtn = new System.Windows.Forms.Button();
            this.encyPassErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(122, 28);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(296, 20);
            this.passwordText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retype Password";
            // 
            // rePasswordText
            // 
            this.rePasswordText.Location = new System.Drawing.Point(122, 78);
            this.rePasswordText.Name = "rePasswordText";
            this.rePasswordText.PasswordChar = '*';
            this.rePasswordText.Size = new System.Drawing.Size(296, 20);
            this.rePasswordText.TabIndex = 3;
            // 
            // checkEncyPassBtn
            // 
            this.checkEncyPassBtn.Location = new System.Drawing.Point(122, 118);
            this.checkEncyPassBtn.Name = "checkEncyPassBtn";
            this.checkEncyPassBtn.Size = new System.Drawing.Size(75, 23);
            this.checkEncyPassBtn.TabIndex = 4;
            this.checkEncyPassBtn.Text = "Done";
            this.checkEncyPassBtn.UseVisualStyleBackColor = true;
            this.checkEncyPassBtn.Click += new System.EventHandler(this.checkEncyPassBtn_Click);
            // 
            // encyPassErrorLbl
            // 
            this.encyPassErrorLbl.AutoSize = true;
            this.encyPassErrorLbl.Location = new System.Drawing.Point(215, 159);
            this.encyPassErrorLbl.Name = "encyPassErrorLbl";
            this.encyPassErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.encyPassErrorLbl.TabIndex = 5;
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 196);
            this.Controls.Add(this.encyPassErrorLbl);
            this.Controls.Add(this.checkEncyPassBtn);
            this.Controls.Add(this.rePasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Encrypt";
            this.Text = "EncryptPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rePasswordText;
        private System.Windows.Forms.Button checkEncyPassBtn;
        private System.Windows.Forms.Label encyPassErrorLbl;
    }
}