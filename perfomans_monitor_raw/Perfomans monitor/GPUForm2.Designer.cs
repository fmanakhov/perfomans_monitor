namespace Perfomans_monitor
{
    partial class GPUForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPUForm2));
            this.label1 = new System.Windows.Forms.Label();
            this.GPUNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TotalMemoryLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UsedMemoryLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GPULabel = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя ГП:";
            // 
            // GPUNameLabel
            // 
            this.GPUNameLabel.AutoSize = true;
            this.GPUNameLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.GPUNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GPUNameLabel.Location = new System.Drawing.Point(282, 25);
            this.GPUNameLabel.Name = "GPUNameLabel";
            this.GPUNameLabel.Size = new System.Drawing.Size(129, 23);
            this.GPUNameLabel.TabIndex = 16;
            this.GPUNameLabel.Text = "GPUNameLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(110, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Используется %";
            // 
            // UsedLabel
            // 
            this.UsedLabel.AutoSize = true;
            this.UsedLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.UsedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedLabel.Location = new System.Drawing.Point(754, 497);
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
            this.label11.Location = new System.Drawing.Point(562, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 46;
            this.label11.Text = "Используется:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.TemperatureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TemperatureLabel.Location = new System.Drawing.Point(754, 462);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(148, 23);
            this.TemperatureLabel.TabIndex = 45;
            this.TemperatureLabel.Text = "TemperatureLabel";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.FrequencyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FrequencyLabel.Location = new System.Drawing.Point(754, 430);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(131, 23);
            this.FrequencyLabel.TabIndex = 44;
            this.FrequencyLabel.Text = "FrequencyLabel";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VersionLabel.Location = new System.Drawing.Point(198, 462);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(108, 23);
            this.VersionLabel.TabIndex = 42;
            this.VersionLabel.Text = "VersionLabel";
            // 
            // TotalMemoryLabel
            // 
            this.TotalMemoryLabel.AutoSize = true;
            this.TotalMemoryLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.TotalMemoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalMemoryLabel.Location = new System.Drawing.Point(199, 430);
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
            this.label10.Location = new System.Drawing.Point(563, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(562, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 39;
            this.label9.Text = "Температура:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(562, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Частота:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(40, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Версия драйвера:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(40, 430);
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
            this.label4.Location = new System.Drawing.Point(562, 390);
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
            this.label3.Location = new System.Drawing.Point(40, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Характеристики:";
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
            series1.Name = "GPU";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1129, 328);
            this.chart1.TabIndex = 49;
            this.chart1.Text = "chart1";
            // 
            // UsedMemoryLabel
            // 
            this.UsedMemoryLabel.AutoSize = true;
            this.UsedMemoryLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.UsedMemoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedMemoryLabel.Location = new System.Drawing.Point(754, 529);
            this.UsedMemoryLabel.Name = "UsedMemoryLabel";
            this.UsedMemoryLabel.Size = new System.Drawing.Size(155, 23);
            this.UsedMemoryLabel.TabIndex = 52;
            this.UsedMemoryLabel.Text = "UsedMemoryLabel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(563, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Используется память:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(564, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.GPULabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GPULabel.Location = new System.Drawing.Point(282, 25);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(84, 23);
            this.GPULabel.TabIndex = 53;
            this.GPULabel.Text = "GPULabel";
            // 
            // GPUForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.UsedMemoryLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.UsedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TotalMemoryLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GPUNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GPULabel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(630, 250);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "GPUForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ГП дискретная";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GPUNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsedLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label TotalMemoryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label UsedMemoryLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GPULabel;
    }
}