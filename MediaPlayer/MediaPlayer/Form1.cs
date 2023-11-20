using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDateiOeffnen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string file = openFileDialog1.FileName;
            labelNoFile.Text = file;
            WindowsMP.URL = file;
            
        }
    }
}
