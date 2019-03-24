namespace Transformer
{
    partial class Decrypt
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
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.tbSourcePath = new System.Windows.Forms.TextBox();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.tlMain.ColumnCount = 6;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlMain.Controls.Add(this.btnDestination, 4, 3);
            this.tlMain.Controls.Add(this.tbDestination, 2, 3);
            this.tlMain.Controls.Add(this.label1, 1, 4);
            this.tlMain.Controls.Add(this.btnFolder, 4, 2);
            this.tlMain.Controls.Add(this.label27, 1, 2);
            this.tlMain.Controls.Add(this.label3, 1, 3);
            this.tlMain.Controls.Add(this.label10, 1, 1);
            this.tlMain.Controls.Add(this.passwordText, 2, 4);
            this.tlMain.Controls.Add(this.tbSourcePath, 2, 2);
            this.tlMain.Controls.Add(this.DecryptBtn, 3, 6);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 8;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.166667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlMain.Size = new System.Drawing.Size(638, 257);
            this.tlMain.TabIndex = 22;
            // 
            // btnFolder
            // 
            this.btnFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.ForeColor = System.Drawing.Color.White;
            this.btnFolder.Image = global::Transformer.Properties.Resources.icons8_folder_24;
            this.btnFolder.Location = new System.Drawing.Point(574, 54);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(27, 37);
            this.btnFolder.TabIndex = 57;
            this.btnFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(34, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(185, 28);
            this.label27.TabIndex = 8;
            this.label27.Text = "Source :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destination:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tlMain.SetColumnSpan(this.label10, 3);
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(34, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(535, 32);
            this.label10.TabIndex = 56;
            this.label10.Text = "Decryption";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordText
            // 
            this.tlMain.SetColumnSpan(this.passwordText, 2);
            this.passwordText.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordText.Location = new System.Drawing.Point(225, 139);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(344, 26);
            this.passwordText.TabIndex = 3;
            // 
            // tbSourcePath
            // 
            this.tlMain.SetColumnSpan(this.tbSourcePath, 2);
            this.tbSourcePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSourcePath.Enabled = false;
            this.tbSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSourcePath.Location = new System.Drawing.Point(225, 55);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.ReadOnly = true;
            this.tbSourcePath.Size = new System.Drawing.Size(344, 26);
            this.tbSourcePath.TabIndex = 0;
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(110)))));
            this.DecryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DecryptBtn.FlatAppearance.BorderSize = 0;
            this.DecryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptBtn.ForeColor = System.Drawing.Color.White;
            this.DecryptBtn.Location = new System.Drawing.Point(415, 190);
            this.DecryptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(155, 37);
            this.DecryptBtn.TabIndex = 55;
            this.DecryptBtn.Text = "Done";
            this.DecryptBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DecryptBtn.UseVisualStyleBackColor = false;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Decryption Key:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbDestination
            // 
            this.tlMain.SetColumnSpan(this.tbDestination, 2);
            this.tbDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDestination.Enabled = false;
            this.tbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDestination.Location = new System.Drawing.Point(225, 97);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.ReadOnly = true;
            this.tbDestination.Size = new System.Drawing.Size(344, 26);
            this.tbDestination.TabIndex = 59;
            // 
            // btnDestination
            // 
            this.btnDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDestination.FlatAppearance.BorderSize = 0;
            this.btnDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestination.ForeColor = System.Drawing.Color.White;
            this.btnDestination.Image = global::Transformer.Properties.Resources.icons8_folder_24;
            this.btnDestination.Location = new System.Drawing.Point(574, 96);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(27, 37);
            this.btnDestination.TabIndex = 60;
            this.btnDestination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDestination.UseVisualStyleBackColor = false;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlMain);
            this.Name = "Decrypt";
            this.Size = new System.Drawing.Size(638, 257);
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox tbSourcePath;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label label1;
    }
}