namespace Transformer
{
    partial class ChooseFile
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
            this.changePathBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.fileDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // changePathBtn
            // 
            this.changePathBtn.Location = new System.Drawing.Point(415, 48);
            this.changePathBtn.Name = "changePathBtn";
            this.changePathBtn.Size = new System.Drawing.Size(124, 23);
            this.changePathBtn.TabIndex = 0;
            this.changePathBtn.Text = "Change Location";
            this.changePathBtn.UseVisualStyleBackColor = true;
            this.changePathBtn.Click += new System.EventHandler(this.changePathBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Export Location";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(169, 48);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(225, 20);
            this.pathTextBox.TabIndex = 2;
            // 
            // fileDataGridView
            // 
            this.fileDataGridView.AllowUserToAddRows = false;
            this.fileDataGridView.AllowUserToDeleteRows = false;
            this.fileDataGridView.AllowUserToResizeRows = false;
            this.fileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGridView.Location = new System.Drawing.Point(12, 153);
            this.fileDataGridView.Name = "fileDataGridView";
            this.fileDataGridView.ReadOnly = true;
            this.fileDataGridView.Size = new System.Drawing.Size(382, 274);
            this.fileDataGridView.TabIndex = 3;
            // 
            // ChooseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileDataGridView);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePathBtn);
            this.Name = "ChooseFile";
            this.Text = "ChooseFile";
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changePathBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.DataGridView fileDataGridView;
    }
}