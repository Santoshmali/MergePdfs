using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergePdfs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder filenames = new StringBuilder();

                foreach(var filename in openFileDialog1.FileNames)
                {
                    filenames.AppendLine(Path.GetFileName(filename));
                }

                txtFiles.Text = filenames.ToString();
            }

        }

        private void btnMergeFiles_Click(object sender, EventArgs e)
        {

        }
    }
}
