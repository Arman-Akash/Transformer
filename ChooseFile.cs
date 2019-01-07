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
        private readonly string dir = @"C:\doc_management\media";
        private string exportFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Document Management's Files");

        public ChooseFile()
        {
            InitializeComponent();
            pathTextBox.Text = exportFolder;
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
                exportFolder = foldername;
            }
        }

        private void PopulateFileDataGridView()
        {
            fileDataGridView.ColumnCount = 2;

            //fileDataGridView.Columns[0].Name = "Select";
            fileDataGridView.Columns[0].Name = "File Name";
            fileDataGridView.Columns[1].Name = "Date";

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
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.FillWeight = 10;
            fileDataGridView.Columns.Add(checkBoxColumn);
        }

        private void fileDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var fileName = fileDataGridView.CurrentRow.Cells["File Name"].Value.ToString();
            pictureBox.Image = Image.FromFile(Path.Combine(dir, fileName));
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            var checkedRows = (from DataGridViewRow r in fileDataGridView.Rows
                              where Convert.ToBoolean(r.Cells[2].Value) == true
                              select r).ToList();
            List<string> selectedFiles = new List<string>();
            foreach (var row in checkedRows)
            {
                var fileName = Path.Combine(dir, row.Cells["File Name"].Value.ToString());
                selectedFiles.Add(fileName);
            }

            new Encrypt(selectedFiles, exportFolder).ShowDialog();
        }
    }
}
