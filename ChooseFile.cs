using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer
{
    public partial class ChooseFile : Form
    {
        public ChooseFile()
        {
            InitializeComponent();
            pathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            PopulateFileDataGridView();
        }

        private void changePathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string foldername = folderBrowserDialog.SelectedPath;
                pathTextBox.Text = foldername;
            }
        }

        private void PopulateFileDataGridView()
        {
            fileDataGridView.ColumnCount = 2;

            //fileDataGridView.Columns[0].Name = "Select";
            fileDataGridView.Columns[0].Name = "File Name";
            fileDataGridView.Columns[1].Name = "Date";

            var dir = @"C:\doc_management\media";
            //var index = 0;
            foreach (string file in Directory.GetFiles(dir))
            {
                var fileName = Path.GetFileName(file);
                fileDataGridView.Rows.Add(fileName, File.GetLastWriteTime(file));
            }
            fileDataGridView.Sort(fileDataGridView.Columns["Date"], ListSortDirection.Descending);
            fileDataGridView.DefaultCellStyle.Format = "dd-MMM-yy";
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Select";
            fileDataGridView.Columns.Add(checkBoxColumn);
        }
    }
}
