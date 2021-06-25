namespace Perfomans_monitor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.total_info_button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpu_button2 = new System.Windows.Forms.Button();
            this.ram_button3 = new System.Windows.Forms.Button();
            this.disks_button5 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.gpu_button_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // total_info_button1
            // 
            this.total_info_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.total_info_button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.total_info_button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.total_info_button1.Location = new System.Drawing.Point(65, 67);
            this.total_info_button1.Name = "total_info_button1";
            this.total_info_button1.Size = new System.Drawing.Size(225, 36);
            this.total_info_button1.TabIndex = 0;
            this.total_info_button1.Text = "Общая информация";
            this.total_info_button1.UseVisualStyleBackColor = true;
            this.total_info_button1.Click += new System.EventHandler(this.total_info_button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(65, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 215);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // cpu_button2
            // 
            this.cpu_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpu_button2.Font = new System.Drawing.Font("Calibri", 12F);
            this.cpu_button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cpu_button2.Location = new System.Drawing.Point(65, 109);
            this.cpu_button2.Name = "cpu_button2";
            this.cpu_button2.Size = new System.Drawing.Size(225, 36);
            this.cpu_button2.TabIndex = 8;
            this.cpu_button2.Text = "ЦП";
            this.cpu_button2.UseVisualStyleBackColor = true;
            this.cpu_button2.Click += new System.EventHandler(this.cpu_button2_Click);
            // 
            // ram_button3
            // 
            this.ram_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ram_button3.Font = new System.Drawing.Font("Calibri", 12F);
            this.ram_button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ram_button3.Location = new System.Drawing.Point(65, 151);
            this.ram_button3.Name = "ram_button3";
            this.ram_button3.Size = new System.Drawing.Size(225, 36);
            this.ram_button3.TabIndex = 9;
            this.ram_button3.Text = "ОЗУ";
            this.ram_button3.UseVisualStyleBackColor = true;
            this.ram_button3.Click += new System.EventHandler(this.ram_button3_Click);
            // 
            // disks_button5
            // 
            this.disks_button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disks_button5.Font = new System.Drawing.Font("Calibri", 12F);
            this.disks_button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.disks_button5.Location = new System.Drawing.Point(65, 238);
            this.disks_button5.Name = "disks_button5";
            this.disks_button5.Size = new System.Drawing.Size(225, 36);
            this.disks_button5.TabIndex = 11;
            this.disks_button5.Text = "Диски";
            this.disks_button5.UseVisualStyleBackColor = true;
            this.disks_button5.Click += new System.EventHandler(this.disks_button5_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(270, 83);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 13;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // gpu_button_2
            // 
            this.gpu_button_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpu_button_2.Font = new System.Drawing.Font("Calibri", 12F);
            this.gpu_button_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpu_button_2.Location = new System.Drawing.Point(65, 196);
            this.gpu_button_2.Name = "gpu_button_2";
            this.gpu_button_2.Size = new System.Drawing.Size(225, 36);
            this.gpu_button_2.TabIndex = 14;
            this.gpu_button_2.Text = "ГП дискретная";
            this.gpu_button_2.UseVisualStyleBackColor = true;
            this.gpu_button_2.Click += new System.EventHandler(this.gpu_button_2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(364, 581);
            this.Controls.Add(this.gpu_button_2);
            this.Controls.Add(this.disks_button5);
            this.Controls.Add(this.ram_button3);
            this.Controls.Add(this.cpu_button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.total_info_button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(250, 250);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 620);
            this.MinimumSize = new System.Drawing.Size(380, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Монитор ресурсов компьютера";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button total_info_button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button cpu_button2;
        private System.Windows.Forms.Button ram_button3;
        private System.Windows.Forms.Button disks_button5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button gpu_button_2;
    }
}

