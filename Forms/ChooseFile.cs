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
using Transformer.Forms;

namespace Transformer
{
    public partial class ChooseFile : Form
    {
        private Encrypt _Encrypt;

        private readonly string dir = @"C:\doc_management\media";
        //private string exportFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Document Management's Files");

        public ChooseFile(Encrypt _Encrypt)
        {
            this._Encrypt = _Encrypt;
            InitializeComponent();
            PopulateFileDataGridView();
        }

        private void changePathBtn_Click(object sender, EventArgs e)
        {

        }

        private void PopulateFileDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Select";
            checkBoxColumn.Width = 60;
            checkBoxColumn.ReadOnly = false;
            checkBoxColumn.FillWeight = 10;

            fileDataGridView.DataSource = null;
            fileDataGridView.ColumnCount = 3;

            fileDataGridView.Columns[0].Name = "File Name";
            fileDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fileDataGridView.Columns[0].FillWeight = 50;
            fileDataGridView.Columns[0].DividerWidth = 1;
            fileDataGridView.Columns[0].ReadOnly = true;

            fileDataGridView.Columns[1].Name = "Date";
            fileDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fileDataGridView.Columns[1].FillWeight = 40;
            fileDataGridView.Columns[1].DividerWidth = 1;
            fileDataGridView.Columns[1].ReadOnly = true;
            fileDataGridView.Columns[1].Width = 80;

            fileDataGridView.Columns[2].Name = "Path";
            fileDataGridView.Columns[2].Visible = false;

            fileDataGridView.RowHeadersVisible = false;

            fileDataGridView.Columns.Add(checkBoxColumn);

            foreach (string file in Directory.GetFiles(dir))
            {
                var fileName = Path.GetFileName(file);
                fileDataGridView.Rows.Add(fileName, File.GetLastWriteTime(file), dir);
            }

            foreach (var folder in Directory.GetDirectories(dir))
            {
                var folderName = Path.GetFileName(folder);
                foreach (var file in Directory.GetFiles(folder))
                {
                    var fileName = Path.GetFileName(file);
                    fileDataGridView.Rows.Add(fileName, File.GetLastWriteTime(file), folder);
                }
            }

            fileDataGridView.Sort(fileDataGridView.Columns["Date"], ListSortDirection.Descending);
            fileDataGridView.DefaultCellStyle.Format = "dd-MMM-yy";
        }

        private void fileDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var fileName = fileDataGridView.CurrentRow.Cells["File Name"].Value.ToString();
            var filePath = fileDataGridView.CurrentRow.Cells["Path"].Value.ToString();
            if (filePath != dir)
            {
                //System.Diagnostics.Process.Start(Path.Combine(filePath, fileName));
            }
            else
            {
                pictureBox.Image = Image.FromFile(Path.Combine(dir, fileName));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            var checkedRows = (from DataGridViewRow r in fileDataGridView.Rows
                              where Convert.ToBoolean(r.Cells["Select"].Value) == true
                              select r).ToList();
            List<string> selectedFiles = new List<string>();
            foreach (var row in checkedRows)
            {
                var fileName = Path.Combine(row.Cells["Path"].Value.ToString(), row.Cells["File Name"].Value.ToString());
                selectedFiles.Add(fileName);
            }

            _Encrypt.SetValues(selectedFiles);

            this.Close();
        }

        private void metroGrid1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.FromArgb(217, 247, 255);
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(205, 235, 255);
            }
        }
    }
}
