using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualCryptographyProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ImageUpload obj = new ImageUpload();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TextShares obj = new TextShares();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
