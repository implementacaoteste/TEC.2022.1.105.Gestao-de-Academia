using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoAcademia
{
    public partial class FormQrCode : Form
    {
        public FormQrCode()
        {
            InitializeComponent();
        }

        private void FormQrCode_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Imagens\\QrCode.png"))
                pictureBoxQrCode.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\QrCode.png";
        }
    }
}
