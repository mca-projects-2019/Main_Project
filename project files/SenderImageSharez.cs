using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace DigitalImageSharing
{
     
    public partial class SenderImageSharez : Form
    {
        private const int GENERATE_IMAGE_COUNT = 2;
        private Bitmap[] m_EncryptedImages;


        public SenderImageSharez(Image dctimage)
        {
            InitializeComponent();
            pictureBox1.Image = dctimage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //m_EncryptedImages = GenerateImage(Program.binaryimage);
            //pictureBox2.Image = (Image)m_EncryptedImages[0];
            //pictureBox3.Image = (Image)m_EncryptedImages[1];
            //Program.Share1 = m_EncryptedImages[0];
            //Program.Share2 = m_EncryptedImages[1];
            m_EncryptedImages[0].Save(Application.StartupPath + "\\Shares\\Share1.png", System.Drawing.Imaging.ImageFormat.Png);
            m_EncryptedImages[1].Save(Application.StartupPath + "\\Shares\\Share2.png", System.Drawing.Imaging.ImageFormat.Png);
        }
        private Bitmap[] GenerateImage(Bitmap source)
        {
            int sourceWidth = source.Width;
            int sourceHeight = source.Height;

            Bitmap tempImage = new Bitmap(sourceWidth / 2, sourceHeight);
            Bitmap[] image = new Bitmap[GENERATE_IMAGE_COUNT];

            Random rand = new Random();
            SolidBrush brush = new SolidBrush(Color.Black);
            Point mid = new Point(sourceWidth / 2, sourceHeight / 2);

            Graphics gtemp = Graphics.FromImage(tempImage);

            Color foreColor;

            gtemp.DrawImage(source, 0, 0, tempImage.Width, tempImage.Height);


            for (int i = 0; i < image.Length; i++)
            {
                image[i] = new Bitmap(sourceWidth, sourceHeight);
            }


            int index = -1;
            int width = tempImage.Width;
            int height = tempImage.Height;
            for (int x = 0; x < width; x += 1)
            {
                for (int y = 0; y < height; y += 1)
                {
                    foreColor = tempImage.GetPixel(x, y);
                    index = rand.Next(image.Length);
                    if (foreColor.ToArgb() == Color.Empty.ToArgb() || foreColor.ToArgb() == Color.White.ToArgb())
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            if (index == 0)
                            {
                                image[i].SetPixel(x * 2, y, Color.Black);
                                image[i].SetPixel(x * 2 + 1, y, Color.Empty);
                            }
                            else
                            {
                                image[i].SetPixel(x * 2, y, Color.Empty);
                                image[i].SetPixel(x * 2 + 1, y, Color.Black);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            if ((index + i) % image.Length == 0)
                            {
                                image[i].SetPixel(x * 2, y, Color.Black);
                                image[i].SetPixel(x * 2 + 1, y, Color.Empty);
                            }
                            else
                            {
                                image[i].SetPixel(x * 2, y, Color.Empty);
                                image[i].SetPixel(x * 2 + 1, y, Color.Black);
                            }
                        }
                    }
                }
            }

            brush.Dispose();
            tempImage.Dispose();

            return image;
        }
        private void SenderImageSharez_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = (Image)Program.binaryimage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SenderNaturalImageSelection obj = new SenderNaturalImageSelection();
            ActiveForm.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap org = (Bitmap)pictureBox1.Image;
            Bitmap result1 = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap result2 = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);

            for (int x = 0; x < org.Width - 1; x += 1)
            {

                for (int y = 0; y < org.Height; y += 1)
                {
                    Color currentPixel = org.GetPixel(x, y);
                    if (y % 2 == 0)
                    {
                        result1.SetPixel(x, y, currentPixel);
                        if (x + 1 < org.Width)
                        {
                            result1.SetPixel(x + 1, y, Color.Empty);

                        }
                    }
                    else
                    {
                        result2.SetPixel(x, y, currentPixel);
                        if (x + 1 < org.Width)
                        {
                            result2.SetPixel(x + 1, y, Color.Empty);
                        }
                    }
                }
            }
            pictureBox2.Image = (Image)result1;
            pictureBox3.Image = (Image)result2;
            Program.Share1 = result1;
            Program.Share2 = result2;
            pictureBox2.Image.Save(Application.StartupPath + "\\Shares\\Share1.png", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox3.Image.Save(Application.StartupPath + "\\Shares\\Share2.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
