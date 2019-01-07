namespace Transformer.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.tlHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loadcontroller = new System.Windows.Forms.TableLayoutPanel();
            this.tlFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tlMain.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.tlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(61)))), ((int)(((byte)(80)))));
            this.tlMain.ColumnCount = 3;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlMain.Controls.Add(this.panel_logo, 1, 1);
            this.tlMain.Controls.Add(this.Loadcontroller, 1, 2);
            this.tlMain.Controls.Add(this.tlFooter, 1, 3);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 5;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlMain.Size = new System.Drawing.Size(737, 391);
            this.tlMain.TabIndex = 20;
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.tlHeader);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_logo.Location = new System.Drawing.Point(39, 30);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(657, 44);
            this.panel_logo.TabIndex = 4;
            // 
            // tlHeader
            // 
            this.tlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.tlHeader.ColumnCount = 4;
            this.tlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlHeader.Controls.Add(this.btnEncrypt, 1, 0);
            this.tlHeader.Controls.Add(this.pictureBox1, 0, 0);
            this.tlHeader.Controls.Add(this.btnDecrypt, 2, 0);
            this.tlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlHeader.Location = new System.Drawing.Point(0, 0);
            this.tlHeader.Name = "tlHeader";
            this.tlHeader.RowCount = 1;
            this.tlHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlHeader.Size = new System.Drawing.Size(657, 44);
            this.tlHeader.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // Loadcontroller
            // 
            this.Loadcontroller.ColumnCount = 1;
            this.Loadcontroller.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Loadcontroller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loadcontroller.Location = new System.Drawing.Point(36, 77);
            this.Loadcontroller.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Loadcontroller.Name = "Loadcontroller";
            this.Loadcontroller.RowCount = 1;
            this.Loadcontroller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Loadcontroller.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.Loadcontroller.Size = new System.Drawing.Size(663, 234);
            this.Loadcontroller.TabIndex = 22;
            this.Loadcontroller.Resize += new System.EventHandler(this.Loadcontroller_Resize);
            // 
            // tlFooter
            // 
            this.tlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.tlFooter.ColumnCount = 3;
            this.tlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tlFooter.Controls.Add(this.pictureBox2, 1, 0);
            this.tlFooter.Controls.Add(this.label1, 0, 0);
            this.tlFooter.Controls.Add(this.label2, 2, 0);
            this.tlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlFooter.Location = new System.Drawing.Point(39, 314);
            this.tlFooter.Name = "tlFooter";
            this.tlFooter.RowCount = 1;
            this.tlFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlFooter.Size = new System.Drawing.Size(657, 44);
            this.tlFooter.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(333, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright © 2018 |";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(370, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bangladesh Army";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(151)))));
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(201, 5);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(121, 34);
            this.btnDecrypt.TabIndex = 61;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            this.btnDecrypt.MouseLeave += new System.EventHandler(this.btnDecrypt_MouseLeave);
            this.btnDecrypt.MouseHover += new System.EventHandler(this.btnDecrypt_MouseHover);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(151)))));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(70, 5);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(121, 34);
            this.btnEncrypt.TabIndex = 62;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.btnEncrypt.MouseLeave += new System.EventHandler(this.btnEncrypt_MouseLeave);
            this.btnEncrypt.MouseHover += new System.EventHandler(this.btnEncrypt_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 391);
            this.Controls.Add(this.tlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encription and Decription";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlMain.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.tlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlFooter.ResumeLayout(false);
            this.tlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.TableLayoutPanel tlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel Loadcontroller;
        private System.Windows.Forms.TableLayoutPanel tlFooter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}