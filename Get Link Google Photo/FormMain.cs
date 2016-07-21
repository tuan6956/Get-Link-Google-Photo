using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Get_Link_Google_Photo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            
            if (tbUrl.Text == "")
                MessageBox.Show("Please input Link!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!tbUrl.Text.Contains(@"https://photos.google.com/share"))
		        MessageBox.Show("Link error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!tbUrl.Text.Contains(@"/photo/") && rdPhoto.Checked )
                MessageBox.Show("Link error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (rdAlbum.Checked && tbUrl.Text.Contains(@"/photo/"))
                MessageBox.Show("Link error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GGPhoTo GG = new GGPhoTo();
                if (rdPhoto.Checked)
                {
                    tbOuput.Text = GG.InfoPicture(tbUrl.Text);
                    MessageBox.Show("Done!");
                }
                else if (rdAlbum.Checked)
                {
                    tbOuput.Text = GG.InfoAlbum(tbUrl.Text);
                    grbResult.Text = "Result( " + GG.count + ")";
                    MessageBox.Show("Done!");
                }
            }
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
        }

        private void rdPhoto_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
