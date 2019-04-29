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
    public partial class SenderNaturalImageSelection : Form
    {
        public SenderNaturalImageSelection()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = ofd.Filter = "Jpeg Images(*.jpg)|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    orginalpic.ImageLocation = ofd.FileName;
                    orginalpic.BackgroundImageLayout = ImageLayout.Stretch;
                    orginalpic.Dock = DockStyle.Fill;
                    orginalpic.Image=Image.FromFile(ofd.FileName);
                   
                    Program.carrier1path = ofd.FileName;
                   // label8.Text = ofd.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error....");
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {

            try
            {
                System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Jpeg Images(*.jpg)|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    targetpic.ImageLocation = ofd.FileName;
                    targetpic.BackgroundImageLayout = ImageLayout.Stretch;
                    targetpic.Image=Image.FromFile(ofd.FileName);
                 
                    targetpic.Dock = DockStyle.Fill;
                    //label7.Visible = true;
                    //label9.Visible = true;
                    Program.carrier2path = ofd.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error....");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SenderEmbeddingImage obj = new SenderEmbeddingImage();
            ActiveForm.Hide();
            obj.Show();
        }
    }
}
