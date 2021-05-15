using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GroupFileByDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            var path = new FolderBrowserDialog();
            path.ShowDialog();
            this.label_path.Text = path.SelectedPath;
        }
    }
}