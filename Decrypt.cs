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

namespace Transformer
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            var password = passwordText.Text;
            var dir = @"D:\docs\";
            var exportDir = @"D:\export\";

            foreach (string file in Directory.GetFiles(dir))
            {
                //decrypt images
                var fileName = Path.GetFileName(file);
                var ext = Path.GetExtension(fileName);
                var path = exportDir + fileName;

                byte[] fileByte = File.ReadAllBytes(file);
                byte[] decyImg = RijndaelHelper.DecryptBytes(fileByte, password);
                MemoryStream ms = new MemoryStream(decyImg);
                Image img = Image.FromStream(ms);


                switch (ext.ToLower())
                {
                    case ".jpeg":
                        img.Save(path, ImageFormat.Jpeg);
                        break;
                    case ".jpg":
                        img.Save(path, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        img.Save(path, ImageFormat.Png);
                        break;
                    case ".gif":
                        img.Save(path, ImageFormat.Gif);
                        break;
                    case ".tiff":
                        img.Save(path, ImageFormat.Tiff);
                        break;
                    case ".bmp":
                        img.Save(path, ImageFormat.Bmp);
                        break;
                }
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

            this.Close();
        }
    }
}
