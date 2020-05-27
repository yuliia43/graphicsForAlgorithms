namespace CursachGraphics
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.frankChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.geneticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avgChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.annealChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.timeButton = new System.Windows.Forms.Button();
            this.accuracyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numOfIterations = new System.Windows.Forms.NumericUpDown();
            this.amountIntervalStart = new System.Windows.Forms.NumericUpDown();
            this.amountIntervalEnd = new System.Windows.Forms.NumericUpDown();
            this.sumIntervalEnd = new System.Windows.Forms.NumericUpDown();
            this.sumIntervalStart = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frankChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneticChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annealChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountIntervalStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountIntervalEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIntervalEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIntervalStart)).BeginInit();
            this.SuspendLayout();
            // 
            // frankChart
            // 
            chartArea1.Name = "ChartArea1";
            this.frankChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frankChart.Legends.Add(legend1);
            this.frankChart.Location = new System.Drawing.Point(4, 211);
            this.frankChart.Name = "frankChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.frankChart.Series.Add(series1);
            this.frankChart.Size = new System.Drawing.Size(528, 266);
            this.frankChart.TabIndex = 3;
            this.frankChart.Text = "frankChart";
            // 
            // geneticChart
            // 
            chartArea2.Name = "ChartArea1";
            this.geneticChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.geneticChart.Legends.Add(legend2);
            this.geneticChart.Location = new System.Drawing.Point(572, 211);
            this.geneticChart.Name = "geneticChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.geneticChart.Series.Add(series2);
            this.geneticChart.Size = new System.Drawing.Size(541, 266);
            this.geneticChart.TabIndex = 4;
            this.geneticChart.Text = "geneticChart";
            // 
            // avgChart
            // 
            chartArea3.Name = "ChartArea1";
            this.avgChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.avgChart.Legends.Add(legend3);
            this.avgChart.Location = new System.Drawing.Point(572, 502);
            this.avgChart.Name = "avgChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series3";
            this.avgChart.Series.Add(series3);
            this.avgChart.Series.Add(series4);
            this.avgChart.Series.Add(series5);
            this.avgChart.Size = new System.Drawing.Size(541, 256);
            this.avgChart.TabIndex = 5;
            this.avgChart.Text = "avgChart";
            // 
            // annealChart
            // 
            chartArea4.Name = "ChartArea1";
            this.annealChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.annealChart.Legends.Add(legend4);
            this.annealChart.Location = new System.Drawing.Point(4, 502);
            this.annealChart.Name = "annealChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.annealChart.Series.Add(series6);
            this.annealChart.Size = new System.Drawing.Size(528, 256);
            this.annealChart.TabIndex = 6;
            this.annealChart.Text = "annealChart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Статистичні графіки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(656, 53);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(416, 62);
            this.timeButton.TabIndex = 8;
            this.timeButton.Text = "Графіки залежності часу виконання алгоритмів від кількості продуктів у партії";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.Click += new System.EventHandler(this.timeButton_Click);
            // 
            // accuracyButton
            // 
            this.accuracyButton.Location = new System.Drawing.Point(656, 128);
            this.accuracyButton.Name = "accuracyButton";
            this.accuracyButton.Size = new System.Drawing.Size(416, 58);
            this.accuracyButton.TabIndex = 9;
            this.accuracyButton.Text = "Графіки залежності точності алгоритмів від кількості продуктів у партії";
            this.accuracyButton.UseVisualStyleBackColor = true;
            this.accuracyButton.Click += new System.EventHandler(this.accuracyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Інтервал сум партії:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Інтервал розмірів партії:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Для кількостей продуктів у замовленні від 2 до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "(max 75)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "від";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "до";
            // 
            // numOfIterations
            // 
            this.numOfIterations.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numOfIterations.Location = new System.Drawing.Point(696, 14);
            this.numOfIterations.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numOfIterations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOfIterations.Name = "numOfIterations";
            this.numOfIterations.Size = new System.Drawing.Size(52, 26);
            this.numOfIterations.TabIndex = 28;
            this.numOfIterations.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // amountIntervalStart
            // 
            this.amountIntervalStart.Location = new System.Drawing.Point(273, 72);
            this.amountIntervalStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountIntervalStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountIntervalStart.Name = "amountIntervalStart";
            this.amountIntervalStart.Size = new System.Drawing.Size(108, 26);
            this.amountIntervalStart.TabIndex = 29;
            this.amountIntervalStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountIntervalEnd
            // 
            this.amountIntervalEnd.Location = new System.Drawing.Point(431, 72);
            this.amountIntervalEnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountIntervalEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountIntervalEnd.Name = "amountIntervalEnd";
            this.amountIntervalEnd.Size = new System.Drawing.Size(108, 26);
            this.amountIntervalEnd.TabIndex = 30;
            this.amountIntervalEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sumIntervalEnd
            // 
            this.sumIntervalEnd.Location = new System.Drawing.Point(431, 145);
            this.sumIntervalEnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sumIntervalEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumIntervalEnd.Name = "sumIntervalEnd";
            this.sumIntervalEnd.Size = new System.Drawing.Size(108, 26);
            this.sumIntervalEnd.TabIndex = 34;
            this.sumIntervalEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sumIntervalStart
            // 
            this.sumIntervalStart.Location = new System.Drawing.Point(273, 145);
            this.sumIntervalStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sumIntervalStart.Name = "sumIntervalStart";
            this.sumIntervalStart.Size = new System.Drawing.Size(108, 26);
            this.sumIntervalStart.TabIndex = 33;
            this.sumIntervalStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "від";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 770);
            this.Controls.Add(this.sumIntervalEnd);
            this.Controls.Add(this.sumIntervalStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.amountIntervalEnd);
            this.Controls.Add(this.amountIntervalStart);
            this.Controls.Add(this.numOfIterations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accuracyButton);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annealChart);
            this.Controls.Add(this.avgChart);
            this.Controls.Add(this.geneticChart);
            this.Controls.Add(this.frankChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frankChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geneticChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annealChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountIntervalStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountIntervalEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIntervalEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumIntervalStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart frankChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart geneticChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avgChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart annealChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Button accuracyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numOfIterations;
        private System.Windows.Forms.NumericUpDown amountIntervalStart;
        private System.Windows.Forms.NumericUpDown amountIntervalEnd;
        private System.Windows.Forms.NumericUpDown sumIntervalEnd;
        private System.Windows.Forms.NumericUpDown sumIntervalStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

