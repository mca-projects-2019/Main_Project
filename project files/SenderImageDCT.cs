using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigitalImageSharing
{
    public partial class SenderImageDCT : Form
    {
        public Bitmap bmp;
        FastDCT2D ImgDCT;
        public int rec_width, rec_height;
        public int scale = 25; // Scaling percentage
        public int WindowSize = 256;  // Dimension of Image Selection Window
        double[,] DCTCoefficients; //DCT Coefficient matrix
        public SenderImageDCT()
        {
            InitializeComponent();
            orginalpic.Image = Image.FromFile(Program.orgfilepath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orgDct();
        }
        public void orgDct()
        {
            int x, y, width, height;
            Bitmap InputImage = new Bitmap(Image.FromFile(Program.orgfilepath));
            Bitmap temp = (Bitmap)InputImage.Clone();
            int iheight = orginalpic.Image.Height;
            int iwidth = orginalpic.Image.Width;
            if (iheight < iwidth)
            {
                WindowSize = iheight;
            }
            else
            {
                WindowSize = iwidth;
            }

            width = height = (int)(WindowSize * Convert.ToInt32(100) / 100);
            bmp = new Bitmap(width, height, InputImage.PixelFormat);
            rec_width = rec_height = (int)(512 * ((float)100 / 100));
            x = (int)((float)0 * (100 / Convert.ToDouble(100)));
            y = (int)((float)0 * (100 / Convert.ToDouble(100)));
            width = height = (int)(rec_width * (100 / (float)scale));
            if (width > WindowSize)
            {
                width = height = WindowSize;
            }

            Rectangle area = new Rectangle(x, y, width, height);


            bmp = (Bitmap)InputImage.Clone(area, InputImage.PixelFormat);

            ImgDCT = new FastDCT2D(bmp, WindowSize);
            ImgDCT.FastDCT();// Finding 2D DCT of Image

            orginaldct.Image = (Image)ImgDCT.DCTMap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SenderImageSharez obj = new SenderImageSharez(orginaldct.Image);
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
