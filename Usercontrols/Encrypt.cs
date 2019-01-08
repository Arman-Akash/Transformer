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
using System.Drawing.Imaging;
using Transformer.Forms;

namespace Transformer
{
    public partial class Encrypt : UserControl
    {
        private readonly string dir = @"C:\doc_management\media";
        private List<string> selectedFiles = new List<string>();

        private string exportFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Document Management's Files");

        private MainForm _MainForm;

        public Encrypt(MainForm _MainForm)
        {
            this._MainForm = _MainForm;
            InitializeComponent();

            pathTextBox.Text = exportFolder;
        }

        public void SetValues(List<string> selectedFiles)
        {
            this.selectedFiles = selectedFiles;
        }

        private void checkEncyPassBtn_Click(object sender, EventArgs e)
        {
            if (selectedFiles.Count > 0)
            {
                var password = passwordText.Text;
                var retypePasswrod = rePasswordText.Text;
                if (!password.Equals(retypePasswrod))
                {
                    encyPassErrorLbl.Text = "Password doesn't match";
                }
                else
                {
                    //var dir = @"C:\doc_management\media";
                    foreach (string file in selectedFiles)
                    {
                        if(Path.GetDirectoryName(file) == dir)
                        {
                            //encrypt images
                            var fileName = Path.GetFileName(file);
                            //var nameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
                            var ext = Path.GetExtension(fileName);

                            //Image img = Image.FromFile(Path.Combine(dir, fileName));
                            Image img = Image.FromFile(file);

                            MemoryStream ms = new MemoryStream();
                            switch (ext.ToLower())
                            {
                                case ".jpeg":
                                    img.Save(ms, ImageFormat.Jpeg);
                                    break;
                                case ".jpg":
                                    img.Save(ms, ImageFormat.Jpeg);
                                    break;
                                case ".png":
                                    img.Save(ms, ImageFormat.Png);
                                    break;
                                case ".gif":
                                    img.Save(ms, ImageFormat.Gif);
                                    break;
                                case ".tiff":
                                    img.Save(ms, ImageFormat.Tiff);
                                    break;
                                case ".bmp":
                                    img.Save(ms, ImageFormat.Bmp);
                                    break;
                            }
                            byte[] byteImg = ms.ToArray();

                            //encrypt bytes with password and salt
                            byte[] encrypterbyteImg = RijndaelHelper.EncryptBytes(byteImg, password);
                            Directory.CreateDirectory(Path.Combine(exportFolder));
                            File.WriteAllBytes(Path.Combine(exportFolder, fileName), encrypterbyteImg);
                        }
                        else
                        {
                            //encrypt files
                            var folderName = Path.GetFileName(Path.GetDirectoryName(file));
                            Directory.CreateDirectory(Path.Combine(exportFolder, folderName));
                            var filename = Path.GetFileName(file);
                            byte[] content = File.ReadAllBytes(file);
                            byte[] encryptedbyte = RijndaelHelper.EncryptBytes(content, password);
                            var path = Path.Combine(exportFolder, folderName, filename);
                            File.WriteAllBytes(path, encryptedbyte);
                        }
                    }
                    MessageBox.Show("Done");
                }
            }
            else
            {
                MessageBox.Show("Please choose file first!");
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
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

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ChooseFile obj = new ChooseFile(this);
            obj.ShowDialog();
        }
    }
}
