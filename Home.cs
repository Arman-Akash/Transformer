using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            new ChooseFile().Show();
            //var passwordForm = new Encrypt();
            //passwordForm.ShowDialog();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            new Decrypt().ShowDialog();
        }
    }
}
