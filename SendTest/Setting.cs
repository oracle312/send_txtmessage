using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendTest
{
    public partial class Setting : Form
    {
        
        string location = "";
        public Setting()
        {
            InitializeComponent();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                location = fbd.SelectedPath;
                txtbox_loc.Text = location;              
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
