using System;
using System.Data;
using System.IO;
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

        private void GroupFile(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(this.label_path.Text);
            var files = di.GetFiles();
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = files.Length;
            this.progressBar1.Value = 1;
            this.progressBar1.Step = 1;
            foreach (var group in files.GroupBy(file => file.LastWriteTime.ToShortDateString()))
            {
                var basePath = String.Join("_", group.Key.Split("/").Select(x => x.PadLeft(2, '0')));
                di.CreateSubdirectory(basePath);
                foreach (var file in group)
                {
                    File.Move(file.FullName, Path.Combine(this.label_path.Text, basePath, file.Name));
                    this.progressBar1.PerformStep();
                }
            }
        }
    }
}