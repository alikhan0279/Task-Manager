namespace WindowsFormsApplication1
{
    partial class Performance
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarcpu = new System.Windows.Forms.ProgressBar();
            this.progressBarram = new System.Windows.Forms.ProgressBar();
            this._cpu = new System.Windows.Forms.Label();
            this._ram = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // CPU
            // 
            this.CPU.CategoryName = "processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RAM";
            // 
            // progressBarcpu
            // 
            this.progressBarcpu.Location = new System.Drawing.Point(72, 27);
            this.progressBarcpu.Name = "progressBarcpu";
            this.progressBarcpu.Size = new System.Drawing.Size(428, 23);
            this.progressBarcpu.TabIndex = 6;
            // 
            // progressBarram
            // 
            this.progressBarram.Location = new System.Drawing.Point(72, 56);
            this.progressBarram.Name = "progressBarram";
            this.progressBarram.Size = new System.Drawing.Size(428, 23);
            this.progressBarram.TabIndex = 7;
            // 
            // _cpu
            // 
            this._cpu.AutoSize = true;
            this._cpu.Location = new System.Drawing.Point(527, 27);
            this._cpu.Name = "_cpu";
            this._cpu.Size = new System.Drawing.Size(24, 13);
            this._cpu.TabIndex = 8;
            this._cpu.Text = "0 %";
            // 
            // _ram
            // 
            this._ram.AutoSize = true;
            this._ram.Location = new System.Drawing.Point(527, 56);
            this._ram.Name = "_ram";
            this._ram.Size = new System.Drawing.Size(24, 13);
            this._ram.TabIndex = 9;
            this._ram.Text = "0 %";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 85);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "RAM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CPU";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(562, 300);
            this.chart1.TabIndex = 10;
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 403);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this._ram);
            this.Controls.Add(this._cpu);
            this.Controls.Add(this.progressBarram);
            this.Controls.Add(this.progressBarcpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Performance";
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.Performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarcpu;
        private System.Windows.Forms.ProgressBar progressBarram;
        private System.Windows.Forms.Label _cpu;
        private System.Windows.Forms.Label _ram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}