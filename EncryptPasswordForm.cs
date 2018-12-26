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

namespace Transformer
{
    public partial class EncryptPasswordForm : Form
    {
        public EncryptPasswordForm()
        {
            InitializeComponent();
        }

        private void checkEncyPassBtn_Click(object sender, EventArgs e)
        {
            var password = passwordText.Text;
            var retypePasswrod = rePasswordText.Text;
            if(!password.Equals(retypePasswrod))
            {
                encyPassErrorLbl.Text = "Password doesn't match";
            }
            else
            {
                var dir = @"C:\doc_management\media";
                var rootFolder = @"D:\docs\";
                foreach (string file in Directory.GetFiles(dir))
                {
                    //encrypt images
                    var fileName = Path.GetFileName(file);
                    //var nameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
                    var ext = Path.GetExtension(fileName);

                    Console.WriteLine(file);
                    Image img = Image.FromFile(Path.Combine(dir, fileName));

                    MemoryStream ms = new MemoryStream();
                    switch(ext.ToLower())
                    {
                        case "jpeg":
                            img.Save(ms, ImageFormat.Jpeg);
                            break;
                        case "jpg":
                            img.Save(ms, ImageFormat.Jpeg);
                            break;
                        case "png":
                            img.Save(ms, ImageFormat.Png);
                            break;
                        case "gif":
                            img.Save(ms, ImageFormat.Gif);
                            break;
                        case "tiff":
                            img.Save(ms, ImageFormat.Tiff);
                            break;
                        case "bmp":
                            img.Save(ms, ImageFormat.Bmp);
                            break;
                    }
                    byte[] byteImg = ms.ToArray();

                    //encrypt bytes with password and salt
                    byte[] encrypterbyteImg = RijndaelHelper.EncryptBytes(byteImg, password);
                    File.WriteAllBytes(rootFolder + fileName, encrypterbyteImg);
                }
                
                //encrypt files
                foreach(var folder in Directory.GetDirectories(dir))
                {
                    var folderName = Path.GetFileName(folder);
                    Directory.CreateDirectory(Path.Combine(rootFolder, folderName));
                    foreach(var file in Directory.GetFiles(folder))
                    {
                        var filename = Path.GetFileName(file);
                        byte[] content = File.ReadAllBytes(file);
                        byte[] encryptedbyte = RijndaelHelper.EncryptBytes(content, password);
                        var path = Path.Combine(rootFolder, folderName, filename);
                        File.WriteAllBytes(path, encryptedbyte);
                    }
                }

                this.Close();
            }
        }
    }
}
