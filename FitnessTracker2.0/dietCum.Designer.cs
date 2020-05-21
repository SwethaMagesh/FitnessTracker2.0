namespace FitnessTracker2._0
{
    partial class dietCum
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yrboxdiet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxdiet = new System.Windows.Forms.ComboBox();
            this.dietchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dietchart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 495);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calorie Graph";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yrboxdiet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxdiet);
            this.panel1.Controls.Add(this.dietchart);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 448);
            this.panel1.TabIndex = 1;
            // 
            // yrboxdiet
            // 
            this.yrboxdiet.Location = new System.Drawing.Point(105, 86);
            this.yrboxdiet.Name = "yrboxdiet";
            this.yrboxdiet.Size = new System.Drawing.Size(73, 29);
            this.yrboxdiet.TabIndex = 9;
            this.yrboxdiet.Text = "2020";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(3, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter Year";
            // 
            // comboBoxdiet
            // 
            this.comboBoxdiet.FormattingEnabled = true;
            this.comboBoxdiet.Items.AddRange(new object[] {
            "--Select--",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxdiet.Location = new System.Drawing.Point(193, 86);
            this.comboBoxdiet.Name = "comboBoxdiet";
            this.comboBoxdiet.Size = new System.Drawing.Size(127, 31);
            this.comboBoxdiet.TabIndex = 6;
            this.comboBoxdiet.SelectedIndexChanged += new System.EventHandler(this.comboBoxdiet_SelectedIndexChanged_1);
            // 
            // dietchart
            // 
            chartArea9.Area3DStyle.Inclination = 20;
            chartArea9.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea9.Area3DStyle.PointDepth = 200;
            chartArea9.Area3DStyle.PointGapDepth = 200;
            chartArea9.Area3DStyle.WallWidth = 0;
            chartArea9.Name = "ChartArea1";
            this.dietchart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.dietchart.Legends.Add(legend9);
            this.dietchart.Location = new System.Drawing.Point(3, 133);
            this.dietchart.Name = "dietchart";
            series9.ChartArea = "ChartArea1";
            series9.EmptyPointStyle.AxisLabel = "Days of Month";
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series9.IsValueShownAsLabel = true;
            series9.IsVisibleInLegend = false;
            series9.IsXValueIndexed = true;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.dietchart.Series.Add(series9);
            this.dietchart.Size = new System.Drawing.Size(393, 242);
            this.dietchart.TabIndex = 5;
            this.dietchart.Text = "dietchart";
            title5.Name = "Avg. Duration of Workout";
            this.dietchart.Titles.Add(title5);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(436, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 495);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Junk VS Healthy";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(8, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 448);
            this.panel2.TabIndex = 2;
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(3, 128);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.CustomProperties = "CollectedSliceExploded=True, PieDrawingStyle=SoftEdge, PieLabelStyle=Outside";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(414, 254);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chartJunk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Choose Time Period";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "--select--",
            "Today",
            "Last 7 days",
            "Last 30 days",
            "All Time"});
            this.comboBox2.Location = new System.Drawing.Point(179, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 31);
            this.comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Here\'s what numbers tell about you!";
            // 
            // dietCum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(885, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "dietCum";
            this.Text = "dietCum";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dietchart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox yrboxdiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxdiet;
        private System.Windows.Forms.DataVisualization.Charting.Chart dietchart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}