namespace Perfomans_monitor
{
    partial class RAMForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RAMForm));
            this.label1 = new System.Windows.Forms.Label();
            this.RAMNameLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.UsedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TotalMemoryLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.ChanelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя ОЗУ:";
            // 
            // RAMNameLabel
            // 
            this.RAMNameLabel.AutoSize = true;
            this.RAMNameLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.RAMNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RAMNameLabel.Location = new System.Drawing.Point(282, 25);
            this.RAMNameLabel.Name = "RAMNameLabel";
            this.RAMNameLabel.Size = new System.Drawing.Size(132, 23);
            this.RAMNameLabel.TabIndex = 16;
            this.RAMNameLabel.Text = "RAMNameLabel";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-19, 47);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1129, 328);
            this.chart1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(110, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Используется %";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.SpeedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SpeedLabel.Location = new System.Drawing.Point(166, 496);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(97, 23);
            this.SpeedLabel.TabIndex = 48;
            this.SpeedLabel.Text = "SpeedLabel";
            // 
            // UsedLabel
            // 
            this.UsedLabel.AutoSize = true;
            this.UsedLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.UsedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedLabel.Location = new System.Drawing.Point(693, 429);
            this.UsedLabel.Name = "UsedLabel";
            this.UsedLabel.Size = new System.Drawing.Size(89, 23);
            this.UsedLabel.TabIndex = 47;
            this.UsedLabel.Text = "UsedLabel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(562, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 46;
            this.label11.Text = "Используется:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TypeLabel.Location = new System.Drawing.Point(166, 461);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(86, 23);
            this.TypeLabel.TabIndex = 42;
            this.TypeLabel.Text = "TypeLabel";
            // 
            // TotalMemoryLabel
            // 
            this.TotalMemoryLabel.AutoSize = true;
            this.TotalMemoryLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.TotalMemoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalMemoryLabel.Location = new System.Drawing.Point(166, 429);
            this.TotalMemoryLabel.Name = "TotalMemoryLabel";
            this.TotalMemoryLabel.Size = new System.Drawing.Size(152, 23);
            this.TotalMemoryLabel.TabIndex = 41;
            this.TotalMemoryLabel.Text = "TotalMemoryLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(563, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(39, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Тип памяти:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(39, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Всего памяти:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(561, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Датчики:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(39, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Характеристики:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(40, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 49;
            this.label12.Text = "Скорость:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(40, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Каналов:";
            // 
            // ChanelLabel
            // 
            this.ChanelLabel.AutoSize = true;
            this.ChanelLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.ChanelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChanelLabel.Location = new System.Drawing.Point(166, 532);
            this.ChanelLabel.Name = "ChanelLabel";
            this.ChanelLabel.Size = new System.Drawing.Size(102, 23);
            this.ChanelLabel.TabIndex = 51;
            this.ChanelLabel.Text = "ChanelLabel";
            // 
            // RAMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.ChanelLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.UsedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TotalMemoryLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.RAMNameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(630, 250);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "RAMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ОЗУ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RAMNameLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label UsedLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TotalMemoryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ChanelLabel;
    }
}