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
    public partial class ExtracterLoadImages : Form
    {
        public static string sorgfilepath = "",sorgfilepath2="";

        public ExtracterLoadImages()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExtractorRetrieveShares obj = new ExtractorRetrieveShares(orginalpic.ImageLocation, targetpic.ImageLocation,sorgfilepath,sorgfilepath2);
            ActiveForm.Hide();
            obj.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Application.StartupPath;
          
            openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                orginalpic.ImageLocation = openFileDialog1.FileName;
                orginalpic.BackgroundImageLayout = ImageLayout.Stretch;
                orginalpic.Dock = DockStyle.Fill;
                sorgfilepath = openFileDialog1.SafeFileName;
                
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Application.StartupPath;

            openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                targetpic.ImageLocation = openFileDialog1.FileName;
                targetpic.BackgroundImageLayout = ImageLayout.Stretch;
                targetpic.Dock = DockStyle.Fill;
                sorgfilepath2 = openFileDialog1.SafeFileName;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
