using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_ARC_1
{
    public partial class Loading : MetroForm
    {
        public Loading()
        {
            InitializeComponent();
            //pictureBox1.Image = System.Drawing.Image.FromFile("../../Images/load.gif");
        }

        public string TextBoxValue
        {
            get { return messageLabel.Text; }
            set { messageLabel.Text = value; }
        }
    }
}
