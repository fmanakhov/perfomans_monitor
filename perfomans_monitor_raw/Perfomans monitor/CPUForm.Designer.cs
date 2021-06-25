namespace Perfomans_monitor
{
    partial class CPUForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPUForm));
            this.CPUNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CoreLabel = new System.Windows.Forms.Label();
            this.ThreadLabel = new System.Windows.Forms.Label();
            this.CacheLabelL2 = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UsedLabel = new System.Windows.Forms.Label();
            this.CacheLabelL3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // CPUNameLabel
            // 
            this.CPUNameLabel.AutoSize = true;
            this.CPUNameLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.CPUNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CPUNameLabel.Location = new System.Drawing.Point(282, 25);
            this.CPUNameLabel.Name = "CPUNameLabel";
            this.CPUNameLabel.Size = new System.Drawing.Size(127, 23);
            this.CPUNameLabel.TabIndex = 13;
            this.CPUNameLabel.Text = "CPUNameLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя ЦП:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(70, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Используется %";
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
            series1.Name = "CPU";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1129, 328);
            this.chart1.TabIndex = 16;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(35, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Характеристики:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(557, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Датчики:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(35, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ядер:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(35, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Потоков:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(35, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "КЭШ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(557, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Частота:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(557, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Температура:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(558, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 24;
            // 
            // CoreLabel
            // 
            this.CoreLabel.AutoSize = true;
            this.CoreLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.CoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CoreLabel.Location = new System.Drawing.Point(123, 418);
            this.CoreLabel.Name = "CoreLabel";
            this.CoreLabel.Size = new System.Drawing.Size(86, 23);
            this.CoreLabel.TabIndex = 25;
            this.CoreLabel.Text = "CoreLabel";
            // 
            // ThreadLabel
            // 
            this.ThreadLabel.AutoSize = true;
            this.ThreadLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.ThreadLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ThreadLabel.Location = new System.Drawing.Point(123, 450);
            this.ThreadLabel.Name = "ThreadLabel";
            this.ThreadLabel.Size = new System.Drawing.Size(104, 23);
            this.ThreadLabel.TabIndex = 26;
            this.ThreadLabel.Text = "ThreadLabel";
            // 
            // CacheLabelL2
            // 
            this.CacheLabelL2.AutoSize = true;
            this.CacheLabelL2.Font = new System.Drawing.Font("Calibri", 14F);
            this.CacheLabelL2.ForeColor = System.Drawing.SystemColors.Control;
            this.CacheLabelL2.Location = new System.Drawing.Point(123, 485);
            this.CacheLabelL2.Name = "CacheLabelL2";
            this.CacheLabelL2.Size = new System.Drawing.Size(114, 23);
            this.CacheLabelL2.TabIndex = 27;
            this.CacheLabelL2.Text = "CacheLabelL2";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.FrequencyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FrequencyLabel.Location = new System.Drawing.Point(681, 418);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(131, 23);
            this.FrequencyLabel.TabIndex = 28;
            this.FrequencyLabel.Text = "FrequencyLabel";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.TemperatureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TemperatureLabel.Location = new System.Drawing.Point(681, 450);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(148, 23);
            this.TemperatureLabel.TabIndex = 29;
            this.TemperatureLabel.Text = "TemperatureLabel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(557, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Используется:";
            // 
            // UsedLabel
            // 
            this.UsedLabel.AutoSize = true;
            this.UsedLabel.Font = new System.Drawing.Font("Calibri", 14F);
            this.UsedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedLabel.Location = new System.Drawing.Point(681, 485);
            this.UsedLabel.Name = "UsedLabel";
            this.UsedLabel.Size = new System.Drawing.Size(89, 23);
            this.UsedLabel.TabIndex = 31;
            this.UsedLabel.Text = "UsedLabel";
            // 
            // CacheLabelL3
            // 
            this.CacheLabelL3.AutoSize = true;
            this.CacheLabelL3.Font = new System.Drawing.Font("Calibri", 14F);
            this.CacheLabelL3.ForeColor = System.Drawing.SystemColors.Control;
            this.CacheLabelL3.Location = new System.Drawing.Point(123, 517);
            this.CacheLabelL3.Name = "CacheLabelL3";
            this.CacheLabelL3.Size = new System.Drawing.Size(114, 23);
            this.CacheLabelL3.TabIndex = 32;
            this.CacheLabelL3.Text = "CacheLabelL3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // CPUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CacheLabelL3);
            this.Controls.Add(this.UsedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.CacheLabelL2);
            this.Controls.Add(this.ThreadLabel);
            this.Controls.Add(this.CoreLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPUNameLabel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(630, 250);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "CPUForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ЦП";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPUNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CoreLabel;
        private System.Windows.Forms.Label ThreadLabel;
        private System.Windows.Forms.Label CacheLabelL2;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label UsedLabel;
        private System.Windows.Forms.Label CacheLabelL3;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pCPU;
    }
}