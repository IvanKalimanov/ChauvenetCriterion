using ChauvenetCriterionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChauvenetCriterionPresenter
{
    public partial class MainForm : Form
    {
        private  ChauvenetCriterion chauvenetCriterion;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            List<double> sample;

            try
            {
                sample = Functions.ReadSampleFromFile(filename);
            }
            catch
            {
                MessageBox.Show("Тестовый файл должен содержать вещественные числа!\n" +
                    "Разделитель - запятая", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            InitialSampleBox.Items.Clear();
            ProcessedSampleBox.Items.Clear();
            InitialSampleBox.Items.AddRange(sample.Select(x => x.ToString()).ToArray());


            chauvenetCriterion = new ChauvenetCriterion(sample);
            RefreshChart();

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


            double mean = chauvenetCriterion.GetCurrentMean();
            double sd = chauvenetCriterion.GetCurrentStandardDeviation();

            label3.Text = String.Format("{0:F4}", mean);
            label4.Text = String.Format("{0:F4}", sd);

            double criticalValue = chauvenetCriterion.GetCriticalValue();
        }



        private void excludeOutliersButton_Click(object sender, EventArgs e)
        {
            if (InitialSampleBox.Items.Count == 0)
            {
                MessageBox.Show("Choose file with initial sample");
                return;
            }

            bool wasExcluded = false;

            if (oneOutlierCheckBox.Checked)
            {
                wasExcluded = chauvenetCriterion.ExcludeDoubtfulValue();
            }
            else
            {
                wasExcluded = chauvenetCriterion.ExcludeAllDoubtfulValues();
            }

            if (wasExcluded)
            {
                ProcessedSampleBox.Items.Clear();
                ProcessedSampleBox.Items.AddRange(chauvenetCriterion.CurrentSample.Select(x => x.ToString()).ToArray());
                RefreshChart();              
            }

            pictureBox1.Image = Image.FromFile("../../images/arrow_right.png");
            pictureBox1.Visible = true;
            label1.Visible = true;
        }

        private void RefreshChart()
        {
            chart1.Series["ExcludedValues"].Points.Clear();
            chart1.Series["CurrentSample"].Points.Clear();

            for (int i = 0; i < chauvenetCriterion.InitialSample.Count; i++)
            {
                bool isExcluded = false;

                for (int j = 0; j < chauvenetCriterion.ExcludedValues.Count; j++)
                {
                    if (Math.Abs(chauvenetCriterion.ExcludedValues[j] - chauvenetCriterion.InitialSample[i]) < 0.00001)
                    {
                        isExcluded = true;
                        break;
                    }
                }

                if (isExcluded)
                {
                    chart1.Series["ExcludedValues"].Points.AddXY(i, chauvenetCriterion.InitialSample[i]);
                }
                else
                {
                    chart1.Series["CurrentSample"].Points.AddXY(i, chauvenetCriterion.InitialSample[i]);
                }
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string res = String.Empty;

            for (int i = 0; i < chauvenetCriterion.Reports.Count; i++)
            {
                res += String.Format("Шаг {0:D}\n", i);
                res += chauvenetCriterion.Reports[i].ToString();
                res += "\n\n";
            }
            MessageBox.Show(res);
        }


    }
}
