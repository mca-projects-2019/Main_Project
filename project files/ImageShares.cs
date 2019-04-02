using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VisualCryptographyProject
{
    public partial class ImageShares : Form
    {
        private Bitmap[] m_EncryptedImages;
        public static string s = "";
        private const int GENERATE_IMAGE_COUNT = 2;
        public ImageShares()
        {
            InitializeComponent();
        }

        private void ImageShares_Load(object sender, EventArgs e)
        {
            picOrginal.Image = (Image)Program.grayimage;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //////////////////////////to draw png////////////////////////////

            //////Bitmap bmp = new Bitmap(300, 300);
            //////Graphics g = Graphics.FromImage(bmp);

            //////g.Clear(Color.Transparent);
            //////g.FillRectangle(Brushes.Red, 100, 100, 100, 100);

            //////g.Flush();
            //////bmp.Save("test.png", System.Drawing.Imaging.ImageFormat.Png);


            /////////////////////////////////copy ////////////////////////////////


            //Bitmap original = new Bitmap(picOrginal.Image.Width,picOrginal.Image.Height);
            //Bitmap copy = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            //Bitmap copy1 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            //int count = 0;
            //using (Graphics graphics = Graphics.FromImage(copy))
            //{
            //    if (count % 2 == 0)
            //    {

            //        Rectangle imageRectangle = new Rectangle(0, 0, copy.Width, copy.Height);
            //        graphics.DrawImage(original, imageRectangle, imageRectangle, GraphicsUnit.Pixel);
            //    }
            //    else
            //    {
            //        Rectangle imageRectangle = new Rectangle(0, 0, copy.Width, copy.Height);
            //        graphics.DrawImage(original, imageRectangle, imageRectangle, GraphicsUnit.Pixel);
            //    }
            //}


            /////////////////////////////////////method2/////////////////////////////////////////

            //Bitmap org = Program.grayimage;
            //Bitmap result = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            //Bitmap result1 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            //Bitmap result2 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            //int height = picOrginal.Image.Height;
            //int width = picOrginal.Image.Width;
            //int count = 0;

            //for (int x = 0; x < width; x++)
            //{
            //    for (int y = 0; y < height; y++)
            //    {
            //        int preint = -1;

            //        Color currentPixel = org.GetPixel(x, y); ;
            //        Random r = new Random();

            //        int k = r.Next(100);
            //        int n = (x *y+(x+y*y)) % 3;
            //        if (n == 0)
            //        {
            //            result.SetPixel(x, y, currentPixel);
            //            result1.SetPixel(x, y, Color.Empty);
            //            result2.SetPixel(x, y, Color.Empty);
            //        }
            //        else if (n == 1)
            //        {
            //            result1.SetPixel(x, y, currentPixel);
            //            result.SetPixel(x, y, Color.Empty);
            //            result2.SetPixel(x, y, Color.Empty);
            //        }
            //        else
            //        {
            //            result2.SetPixel(x, y, currentPixel);
            //            result.SetPixel(x, y, Color.Empty);
            //            result1.SetPixel(x, y, Color.Empty);
            //        }
            //        preint = n;
            //    }







            //    }




            //pictureBox1.Image = (Image)result;
            //pictureBox2.Image = (Image)result1;
            //pictureBox3.Image = (Image)result2;


            //result.Save("test1.png", System.Drawing.Imaging.ImageFormat.Png);
            //result1.Save("test2.png", System.Drawing.Imaging.ImageFormat.Png);
            //result2.Save("test3.png", System.Drawing.Imaging.ImageFormat.Png);



            //////////////////////////////////////method3/////////////////////////////////////////////


           
            //Bitmap org = (Bitmap)Image.FromFile(Program.orgfilepath);

            Bitmap org = Program.grayimage;
            Bitmap result1 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            Bitmap result2 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            Bitmap result3 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            Bitmap result4 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            Bitmap result5 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
            Bitmap result6 = new Bitmap(picOrginal.Image.Width, picOrginal.Image.Height);
           
            int height = picOrginal.Image.Height;
            int width = picOrginal.Image.Width;
            progressBar1.Maximum = width;
            progressBar1.Value = 0;
            Bitmap tempImage = new Bitmap(width, height);
            int index;
            string colorc = "";
            Random rand = new Random();
            for (int x = 0; x < org.Width-1; x += 1)
            {
                progressBar1.Value++;
                for (int y = 0; y <org.Height; y += 1)
                {
                    Color currentPixel = org.GetPixel(x, y);
                    colorc=colorc + currentPixel.ToKnownColor().ToString();
                    index = rand.Next(6);
                    if (currentPixel.ToArgb() == Color.Empty.ToArgb() || currentPixel.ToArgb() == Color.White.ToArgb())
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            if (index == 0)
                            {
                                if (i == 0)
                                {
                                    result1.SetPixel(x , y,currentPixel);
                                    result1.SetPixel(x  + 1, y, Color.Empty);
                                }
                                else if(i==1)
                                {
                                    result2.SetPixel(x, y, currentPixel);
                                    result2.SetPixel(x  + 1, y, Color.Empty);
                                }
                                else if (i == 2)
                                {
                                    result3.SetPixel(x, y, currentPixel);
                                    result3.SetPixel(x  + 1, y, Color.Empty);
                                }
                                else if(i==3)
                                {
                                    result4.SetPixel(x, y, currentPixel);
                                    result4.SetPixel(x  + 1, y, Color.Empty);
                                }
                                else if (i == 4)
                                {
                                    result5.SetPixel(x, y, currentPixel);
                                    result5.SetPixel(x + 1, y, Color.Empty);
                                }
                                else if (i == 5)
                                {
                                    result6.SetPixel(x, y, currentPixel);
                                    result6.SetPixel(x + 1, y, Color.Empty);
                                }
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    result1.SetPixel(x, y, Color.Empty);
                                    result1.SetPixel(x + 1, y, currentPixel);
                                }
                                else if(i==1)
                                {
                                    result2.SetPixel(x , y, Color.Empty);
                                    result2.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 2)
                                {
                                    result3.SetPixel(x, y, Color.Empty);
                                    result3.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 3)
                                {
                                    result4.SetPixel(x, y, Color.Empty);
                                    result4.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 4)
                                {
                                    result5.SetPixel(x, y, Color.Empty);
                                    result5.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 5)
                                {
                                    result6.SetPixel(x, y, Color.Empty);
                                    result6.SetPixel(x + 1, y, currentPixel);
                                }

                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i <6; i++)
                        {
                            if ((index + i) % 6 == 0)
                            {
                                if (i == 0)
                                {
                                    result1.SetPixel(x, y, currentPixel);
                                    result1.SetPixel(x  + 1, y, Color.Empty);
                                }
                                else if(i==1)
                                {
                                    result2.SetPixel(x, y, currentPixel);
                                    result2.SetPixel(x  + 1, y, Color.Empty);
                                }
                                else if (i == 2)
                                {
                                    result3.SetPixel(x, y, currentPixel);
                                    result3.SetPixel(x + 1, y, Color.Empty);
                                }
                                else if (i == 3)
                                {
                                    result4.SetPixel(x, y, currentPixel);
                                    result4.SetPixel(x + 1, y, Color.Empty);
                                }
                                else if (i == 4)
                                {
                                    result5.SetPixel(x, y, currentPixel);
                                    result5.SetPixel(x + 1, y, Color.Empty);
                                }
                                else if (i == 5)
                                {
                                    result6.SetPixel(x, y, currentPixel);
                                    result6.SetPixel(x + 1, y, Color.Empty);
                                }
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    result1.SetPixel(x , y, Color.Empty);
                                    result1.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 1)
                                {
                                    result2.SetPixel(x, y, Color.Empty);
                                    result2.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 2)
                                {
                                    result3.SetPixel(x, y, Color.Empty);
                                    result3.SetPixel(x + 1, y, currentPixel);

                                }
                                else if (i == 3)
                                {
                                    result4.SetPixel(x, y, Color.Empty);
                                    result4.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 4)
                                {
                                    result5.SetPixel(x, y, Color.Empty);
                                    result5.SetPixel(x + 1, y, currentPixel);
                                }
                                else if (i == 5)
                                {
                                    result6.SetPixel(x, y, Color.Empty);
                                    result6.SetPixel(x + 1, y, currentPixel);
                                }
                            }
                        }
                    }
                }


                pictureBox1.Image = (Image)result1;

                pictureBox2.Image = (Image)result2;
                pictureBox3.Image = (Image)result3;

                pictureBox4.Image = (Image)result4;
                pictureBox5.Image = (Image)result5;
                pictureBox6.Image = (Image)result6;

                result1.Save(Application.StartupPath + "\\Shares\\Share1.png", System.Drawing.Imaging.ImageFormat.Png);
                result2.Save(Application.StartupPath + "\\Shares\\Share2.png", System.Drawing.Imaging.ImageFormat.Png);
                result3.Save(Application.StartupPath + "\\Shares\\Share3.png", System.Drawing.Imaging.ImageFormat.Png);
                result4.Save(Application.StartupPath + "\\Shares\\Share4.png", System.Drawing.Imaging.ImageFormat.Png);
                result5.Save(Application.StartupPath + "\\Shares\\Share5.png", System.Drawing.Imaging.ImageFormat.Png);
                result6.Save(Application.StartupPath + "\\Shares\\Share6.png", System.Drawing.Imaging.ImageFormat.Png);

            }
            button1.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            ImageEmbedding em = new ImageEmbedding();
            em.Show();
        }

       



    }
}
