namespace TEST
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.download_file = new System.Windows.Forms.Button();
            this.unrar_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(882, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // download_file
            // 
            this.download_file.Location = new System.Drawing.Point(49, 428);
            this.download_file.Name = "download_file";
            this.download_file.Size = new System.Drawing.Size(176, 38);
            this.download_file.TabIndex = 1;
            this.download_file.Text = "Down load file";
            this.download_file.UseVisualStyleBackColor = true;
            this.download_file.Click += new System.EventHandler(this.download_file_Click);
            // 
            // unrar_file
            // 
            this.unrar_file.Location = new System.Drawing.Point(303, 428);
            this.unrar_file.Name = "unrar_file";
            this.unrar_file.Size = new System.Drawing.Size(164, 38);
            this.unrar_file.TabIndex = 2;
            this.unrar_file.Text = "Unrar file";
            this.unrar_file.UseVisualStyleBackColor = true;
            this.unrar_file.Click += new System.EventHandler(this.unrar_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 628);
            this.Controls.Add(this.unrar_file);
            this.Controls.Add(this.download_file);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button download_file;
        private System.Windows.Forms.Button unrar_file;
    }
}

