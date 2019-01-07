using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer.Forms
{
    public partial class MainForm : Form
    {
        UserControl objUserControl = new UserControl();
        Color hoverColor = Color.FromArgb(249, 209, 82);

        public static string dataPath = AppDomain.CurrentDomain.BaseDirectory;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Activate();
            OpenUserControl(new Encrypt(this));
        }

        private void OpenUserControl(UserControl obj)
        {
            Loadcontroller.Controls.Clear();

            obj.Height = Loadcontroller.Height;
            obj.Width = Loadcontroller.Width;
            objUserControl = obj;

            Loadcontroller.Controls.Add(obj);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            OpenUserControl(new Encrypt(this));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            OpenUserControl(new Decrypt(this));
        }

        private void Loadcontroller_Resize(object sender, EventArgs e)
        {
            objUserControl.Height = Loadcontroller.Height;
            objUserControl.Width = Loadcontroller.Width;
        }

        private void btnEncrypt_MouseHover(object sender, EventArgs e)
        {
            btnEncrypt.ForeColor = hoverColor;
        }

        private void btnEncrypt_MouseLeave(object sender, EventArgs e)
        {
            btnEncrypt.ForeColor = Color.White;
        }

        private void btnDecrypt_MouseHover(object sender, EventArgs e)
        {
            btnDecrypt.ForeColor = hoverColor;
        }

        private void btnDecrypt_MouseLeave(object sender, EventArgs e)
        {
            btnDecrypt.ForeColor = Color.White;
        }
    }
}

