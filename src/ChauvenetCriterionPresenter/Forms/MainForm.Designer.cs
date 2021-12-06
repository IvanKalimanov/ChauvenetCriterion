
namespace ChauvenetCriterionPresenter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.InitialSampleBox = new System.Windows.Forms.ListBox();
            this.ProcessedSampleBox = new System.Windows.Forms.ListBox();
            this.excludeOutliersButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oneOutlierCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(33, 462);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(200, 72);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Открыть";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // InitialSampleBox
            // 
            this.InitialSampleBox.FormattingEnabled = true;
            this.InitialSampleBox.ItemHeight = 25;
            this.InitialSampleBox.Location = new System.Drawing.Point(33, 17);
            this.InitialSampleBox.Name = "InitialSampleBox";
            this.InitialSampleBox.Size = new System.Drawing.Size(200, 379);
            this.InitialSampleBox.TabIndex = 1;
            // 
            // ProcessedSampleBox
            // 
            this.ProcessedSampleBox.FormattingEnabled = true;
            this.ProcessedSampleBox.ItemHeight = 25;
            this.ProcessedSampleBox.Location = new System.Drawing.Point(588, 17);
            this.ProcessedSampleBox.Name = "ProcessedSampleBox";
            this.ProcessedSampleBox.Size = new System.Drawing.Size(200, 379);
            this.ProcessedSampleBox.TabIndex = 2;
            // 
            // excludeOutliersButton
            // 
            this.excludeOutliersButton.Location = new System.Drawing.Point(259, 462);
            this.excludeOutliersButton.Name = "excludeOutliersButton";
            this.excludeOutliersButton.Size = new System.Drawing.Size(200, 72);
            this.excludeOutliersButton.TabIndex = 3;
            this.excludeOutliersButton.Text = "Исключить выбросы";
            this.excludeOutliersButton.UseVisualStyleBackColor = true;
            this.excludeOutliersButton.Click += new System.EventHandler(this.excludeOutliersButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(304, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Применение критрерия Шовене";
            this.label1.Visible = false;
            // 
            // oneOutlierCheckBox
            // 
            this.oneOutlierCheckBox.AutoSize = true;
            this.oneOutlierCheckBox.Location = new System.Drawing.Point(33, 404);
            this.oneOutlierCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oneOutlierCheckBox.Name = "oneOutlierCheckBox";
            this.oneOutlierCheckBox.Size = new System.Drawing.Size(245, 54);
            this.oneOutlierCheckBox.TabIndex = 6;
            this.oneOutlierCheckBox.Text = "Исключить только 1\r\nгрубое измерение";
            this.oneOutlierCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Xср";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "SD";
            this.label5.Visible = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(33, 564);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.LegendText = "Выборка";
            series3.Name = "CurrentSample";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.LegendText = "Исключённые значения";
            series4.Name = "ExcludedValues";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(725, 321);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(487, 462);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(198, 72);
            this.reportButton.TabIndex = 16;
            this.reportButton.Text = "Отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 929);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.excludeOutliersButton);
            this.Controls.Add(this.ProcessedSampleBox);
            this.Controls.Add(this.InitialSampleBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.oneOutlierCheckBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ListBox InitialSampleBox;
        private System.Windows.Forms.ListBox ProcessedSampleBox;
        private System.Windows.Forms.Button excludeOutliersButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox oneOutlierCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button reportButton;
    }
}

