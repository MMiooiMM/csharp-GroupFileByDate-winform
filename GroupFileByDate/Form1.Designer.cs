
namespace GroupFileByDate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.button_folder_select = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_file_count = new System.Windows.Forms.Label();
            this.button_group_file = new System.Windows.Forms.Button();
            this.label_file_count_content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(40, 127);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(78, 35);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Path:";
            // 
            // button_folder_select
            // 
            this.button_folder_select.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_folder_select.Location = new System.Drawing.Point(81, 45);
            this.button_folder_select.Name = "button_folder_select";
            this.button_folder_select.Size = new System.Drawing.Size(153, 58);
            this.button_folder_select.TabIndex = 2;
            this.button_folder_select.Text = "Select Folder";
            this.button_folder_select.UseVisualStyleBackColor = true;
            this.button_folder_select.Click += new System.EventHandler(this.SelectFolder);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_path.Location = new System.Drawing.Point(124, 127);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(0, 35);
            this.label_path.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 377);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(642, 29);
            this.progressBar1.TabIndex = 4;
            // 
            // label_file_count
            // 
            this.label_file_count.AutoSize = true;
            this.label_file_count.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_file_count.Location = new System.Drawing.Point(40, 180);
            this.label_file_count.Name = "label_file_count";
            this.label_file_count.Size = new System.Drawing.Size(148, 35);
            this.label_file_count.TabIndex = 5;
            this.label_file_count.Text = "File Count:";
            // 
            // button_group_file
            // 
            this.button_group_file.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_group_file.Location = new System.Drawing.Point(288, 45);
            this.button_group_file.Name = "button_group_file";
            this.button_group_file.Size = new System.Drawing.Size(153, 58);
            this.button_group_file.TabIndex = 6;
            this.button_group_file.Text = "Group FIle";
            this.button_group_file.UseVisualStyleBackColor = true;
            this.button_group_file.Click += new System.EventHandler(this.GroupFile);
            // 
            // label_file_count_content
            // 
            this.label_file_count_content.AutoSize = true;
            this.label_file_count_content.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_file_count_content.Location = new System.Drawing.Point(194, 180);
            this.label_file_count_content.Name = "label_file_count_content";
            this.label_file_count_content.Size = new System.Drawing.Size(0, 35);
            this.label_file_count_content.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_file_count_content);
            this.Controls.Add(this.button_group_file);
            this.Controls.Add(this.label_file_count);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_folder_select);
            this.Controls.Add(this.label_title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_folder_select;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_file_count;
        private System.Windows.Forms.Button button_group_file;
        private System.Windows.Forms.Label label_file_count_content;
    }
}

