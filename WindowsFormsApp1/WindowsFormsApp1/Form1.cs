using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var img = new Mat(new OpenCvSharp.Size(256, 256), MatType.CV_8UC3, new Scalar(35, 123, 254));

            Cv2.ImShow("Image", img);
        }
    }
}
