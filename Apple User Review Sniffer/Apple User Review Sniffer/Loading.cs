using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple_User_Review_Sniffer
{
    public partial class Loading : Form
    {
        public Loading()
        {
            
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.ImageLocation = @"C:\Users\nisha\Documents\Visual Studio 2015\Projects\Apple User Review Sniffer\Apple User Review Sniffer\Images\load.gif";
        }
        public string TextBoxValue
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
