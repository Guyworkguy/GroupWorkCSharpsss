namespace MrsMcave
{
    partial class Child_Form_11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMilestone = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTwin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartmonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMilestone
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMilestone.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartMilestone.Legends.Add(legend4);
            this.chartMilestone.Location = new System.Drawing.Point(12, 27);
            this.chartMilestone.Name = "chartMilestone";
            this.chartMilestone.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Milestone";
            this.chartMilestone.Series.Add(series4);
            this.chartMilestone.Size = new System.Drawing.Size(378, 223);
            this.chartMilestone.TabIndex = 0;
            this.chartMilestone.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Children\'s Mildstones";
            this.chartMilestone.Titles.Add(title4);
            this.chartMilestone.Click += new System.EventHandler(this.chartMilestone_Click);
            // 
            // chartTwin
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTwin.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartTwin.Legends.Add(legend5);
            this.chartTwin.Location = new System.Drawing.Point(410, 27);
            this.chartTwin.Name = "chartTwin";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "twinchart";
            this.chartTwin.Series.Add(series5);
            this.chartTwin.Size = new System.Drawing.Size(296, 223);
            this.chartTwin.TabIndex = 1;
            this.chartTwin.Text = "twinchart";
            title5.Name = "Title1";
            title5.Text = "Twin Chart";
            this.chartTwin.Titles.Add(title5);
            this.chartTwin.Click += new System.EventHandler(this.chartTwin_Click);
            // 
            // chartmonth
            // 
            chartArea6.Name = "ChartArea1";
            this.chartmonth.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartmonth.Legends.Add(legend6);
            this.chartmonth.Location = new System.Drawing.Point(12, 256);
            this.chartmonth.Name = "chartmonth";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            series6.Legend = "Legend1";
            series6.Name = "monthchart";
            this.chartmonth.Series.Add(series6);
            this.chartmonth.Size = new System.Drawing.Size(694, 385);
            this.chartmonth.TabIndex = 2;
            this.chartmonth.Text = "monthchart";
            title6.Name = "Title1";
            title6.Text = "Number of Children born in a Month";
            this.chartmonth.Titles.Add(title6);
            // 
            // Child_Form_11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(718, 647);
            this.Controls.Add(this.chartmonth);
            this.Controls.Add(this.chartTwin);
            this.Controls.Add(this.chartMilestone);
            this.Name = "Child_Form_11";
            this.Text = "Useful Graphs";
            this.Load += new System.EventHandler(this.Child_Form_11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMilestone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTwin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmonth;
    }
}