namespace Perfomans_monitor
{
    partial class DisksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisksForm));
            this.label1 = new System.Windows.Forms.Label();
            this.HDDNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TotalMemoryLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartitionsLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pHDD = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHDD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Имя Диска:";
            // 
            // HDDNameLabel
            // 
            this.HDDNameLabel.AutoSize = true;
            this.HDDNameLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.HDDNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.HDDNameLabel.Location = new System.Drawing.Point(306, 25);
            this.HDDNameLabel.Name = "HDDNameLabel";
            this.HDDNameLabel.Size = new System.Drawing.Size(131, 23);
            this.HDDNameLabel.TabIndex = 17;
            this.HDDNameLabel.Text = "HDDNameLabel";
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
            // UsedLabel
            // 
            this.UsedLabel.AutoSize = true;
            this.UsedLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.UsedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedLabel.Location = new System.Drawing.Point(711, 439);
            this.UsedLabel.Name = "UsedLabel";
            this.UsedLabel.Size = new System.Drawing.Size(89, 23);
            this.UsedLabel.TabIndex = 60;
            this.UsedLabel.Text = "UsedLabel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(578, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 59;
            this.label11.Text = "Используется:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VersionLabel.Location = new System.Drawing.Point(214, 538);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(108, 23);
            this.VersionLabel.TabIndex = 56;
            this.VersionLabel.Text = "VersionLabel";
            // 
            // TotalMemoryLabel
            // 
            this.TotalMemoryLabel.AutoSize = true;
            this.TotalMemoryLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.TotalMemoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalMemoryLabel.Location = new System.Drawing.Point(214, 439);
            this.TotalMemoryLabel.Name = "TotalMemoryLabel";
            this.TotalMemoryLabel.Size = new System.Drawing.Size(152, 23);
            this.TotalMemoryLabel.TabIndex = 55;
            this.TotalMemoryLabel.Text = "TotalMemoryLabel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(578, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(55, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Серийный номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(55, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ёмкость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(577, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "Датчики:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(55, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 48;
            this.label3.Text = "Характеристики:";
            // 
            // PartitionsLabel
            // 
            this.PartitionsLabel.AutoSize = true;
            this.PartitionsLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.PartitionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PartitionsLabel.Location = new System.Drawing.Point(214, 506);
            this.PartitionsLabel.Name = "PartitionsLabel";
            this.PartitionsLabel.Size = new System.Drawing.Size(126, 23);
            this.PartitionsLabel.TabIndex = 62;
            this.PartitionsLabel.Text = "PartitionsLabel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(56, 506);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 23);
            this.label13.TabIndex = 61;
            this.label13.Text = "Разделы:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-4, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "HDD";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1101, 328);
            this.chart1.TabIndex = 65;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.SerialNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SerialNumberLabel.Location = new System.Drawing.Point(214, 471);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(155, 23);
            this.SerialNumberLabel.TabIndex = 66;
            this.SerialNumberLabel.Text = "SerialNumberLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(56, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Тип подключение:";
            // 
            // pHDD
            // 
            this.pHDD.CategoryName = "PhysicalDisk";
            this.pHDD.CounterName = "% Disk Time";
            this.pHDD.InstanceName = "_Total";
            // 
            // DisksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PartitionsLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UsedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TotalMemoryLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HDDNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(630, 250);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "DisksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Диски";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HDDNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsedLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label TotalMemoryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PartitionsLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label label7;
        private System.Diagnostics.PerformanceCounter pHDD;
    }
}