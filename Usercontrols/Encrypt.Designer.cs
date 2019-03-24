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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.encyPassErrorLbl = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.rePasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkEncyPassBtn = new System.Windows.Forms.Button();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.tlMain.SetColumnSpan(this.pathTextBox, 2);
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pathTextBox.Location = new System.Drawing.Point(224, 54);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(342, 26);
            this.pathTextBox.TabIndex = 0;
            // 
            // passwordText
            // 
            this.tlMain.SetColumnSpan(this.passwordText, 2);
            this.passwordText.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordText.Location = new System.Drawing.Point(224, 95);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(342, 26);
            this.passwordText.TabIndex = 3;
            // 
            // encyPassErrorLbl
            // 
            this.encyPassErrorLbl.AutoSize = true;
            this.encyPassErrorLbl.Location = new System.Drawing.Point(215, 159);
            this.encyPassErrorLbl.Name = "encyPassErrorLbl";
            this.encyPassErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.encyPassErrorLbl.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(34, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(184, 28);
            this.label27.TabIndex = 8;
            this.label27.Text = "Export Location :";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.tlMain.Controls.Add(this.btnChooseFile, 2, 6);
            this.tlMain.Controls.Add(this.btnFolder, 4, 2);
            this.tlMain.Controls.Add(this.rePasswordText, 2, 4);
            this.tlMain.Controls.Add(this.label1, 1, 4);
            this.tlMain.Controls.Add(this.label27, 1, 2);
            this.tlMain.Controls.Add(this.label3, 1, 3);
            this.tlMain.Controls.Add(this.label10, 1, 1);
            this.tlMain.Controls.Add(this.passwordText, 2, 3);
            this.tlMain.Controls.Add(this.pathTextBox, 2, 2);
            this.tlMain.Controls.Add(this.checkEncyPassBtn, 3, 6);
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
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tlMain.Size = new System.Drawing.Size(635, 249);
            this.tlMain.TabIndex = 21;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(151)))));
            this.btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChooseFile.FlatAppearance.BorderSize = 0;
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseFile.Location = new System.Drawing.Point(223, 186);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(186, 37);
            this.btnChooseFile.TabIndex = 60;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChooseFile.UseVisualStyleBackColor = false;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
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
            this.btnFolder.Location = new System.Drawing.Point(571, 53);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(27, 37);
            this.btnFolder.TabIndex = 59;
            this.btnFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // rePasswordText
            // 
            this.tlMain.SetColumnSpan(this.rePasswordText, 2);
            this.rePasswordText.Dock = System.Windows.Forms.DockStyle.Top;
            this.rePasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rePasswordText.Location = new System.Drawing.Point(224, 136);
            this.rePasswordText.Name = "rePasswordText";
            this.rePasswordText.PasswordChar = '*';
            this.rePasswordText.Size = new System.Drawing.Size(342, 26);
            this.rePasswordText.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "Retype Key :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encryption Key:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tlMain.SetColumnSpan(this.label10, 3);
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(34, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(532, 32);
            this.label10.TabIndex = 56;
            this.label10.Text = "Encryption";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkEncyPassBtn
            // 
            this.checkEncyPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(110)))));
            this.checkEncyPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEncyPassBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkEncyPassBtn.FlatAppearance.BorderSize = 0;
            this.checkEncyPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEncyPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEncyPassBtn.ForeColor = System.Drawing.Color.White;
            this.checkEncyPassBtn.Location = new System.Drawing.Point(413, 186);
            this.checkEncyPassBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkEncyPassBtn.Name = "checkEncyPassBtn";
            this.checkEncyPassBtn.Size = new System.Drawing.Size(154, 37);
            this.checkEncyPassBtn.TabIndex = 55;
            this.checkEncyPassBtn.Text = "Done";
            this.checkEncyPassBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkEncyPassBtn.UseVisualStyleBackColor = false;
            this.checkEncyPassBtn.Click += new System.EventHandler(this.checkEncyPassBtn_Click);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlMain);
            this.Controls.Add(this.encyPassErrorLbl);
            this.Name = "Encrypt";
            this.Size = new System.Drawing.Size(635, 249);
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label encyPassErrorLbl;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button checkEncyPassBtn;
        private System.Windows.Forms.TextBox rePasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnChooseFile;
    }
}