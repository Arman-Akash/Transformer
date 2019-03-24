using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transformer.Forms;

namespace Transformer
{
    public partial class Decrypt : UserControl
    {
        private MainForm _MainForm;

        public Decrypt(MainForm _MainForm)
        {
            this._MainForm = _MainForm;
            InitializeComponent();
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (tbDestination.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Please select a destination folder!");

                return;
            }

            var password = passwordText.Text;
            var dir = tbSourcePath.Text;  // @"D:\docs\";
            var exportDir = Path.Combine(tbDestination.Text, "Decrypted Files"); //@"D:\export\";
            Directory.CreateDirectory(exportDir);

            foreach (string file in Directory.GetFiles(dir))
            {
                //decrypt images
                var fileName = Path.GetFileName(file);
                var ext = Path.GetExtension(fileName);
                var path = Path.Combine(exportDir, fileName);

                //if (ext.ToLower().Equals(".jpeg") || ext.ToLower().Equals(".jpg") || ext.ToLower().Equals(".png") || 
                //    ext.ToLower().Equals(".gif") || ext.ToLower().Equals(".tiff") || ext.ToLower().Equals(".bmp"))
                //{

                //    byte[] fileByte = File.ReadAllBytes(file);
                //    byte[] decyImg = RijndaelHelper.DecryptBytes(fileByte, password);
                //    MemoryStream ms = new MemoryStream(decyImg);
                //    Image img = Image.FromStream(ms);


                //    switch (ext.ToLower())
                //    {
                //        case ".jpeg":
                //            img.Save(path, ImageFormat.Jpeg);
                //            break;
                //        case ".jpg":
                //            img.Save(path, ImageFormat.Jpeg);
                //            break;
                //        case ".png":
                //            img.Save(path, ImageFormat.Png);
                //            break;
                //        case ".gif":
                //            img.Save(path, ImageFormat.Gif);
                //            break;
                //        case ".tiff":
                //            img.Save(path, ImageFormat.Tiff);
                //            break;
                //        case ".bmp":
                //            img.Save(path, ImageFormat.Bmp);
                //            break;
                //    }
                //}
                //else
                //{
                    byte[] content = File.ReadAllBytes(file);
                    byte[] encryptedbyte = RijndaelHelper.DecryptBytes(content, password);
                    File.WriteAllBytes(path, encryptedbyte);
                //}
            }

            //encrypt files
            foreach (var folder in Directory.GetDirectories(dir))
            {
                var folderName = Path.GetFileName(folder);
                Directory.CreateDirectory(Path.Combine(exportDir, folderName));
                foreach (var file in Directory.GetFiles(folder))
                {
                    var filename = Path.GetFileName(file);
                    byte[] content = File.ReadAllBytes(file);
                    byte[] encryptedbyte = RijndaelHelper.DecryptBytes(content, password);
                    var path = Path.Combine(exportDir, folderName, filename);
                    File.WriteAllBytes(path, encryptedbyte);
                }
            }

            MessageBox.Show("Your files are decrypeted in " + exportDir);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbSourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
