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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string[] lines = System.IO.File.ReadAllLines(filename);
            InitialSampleBox.Items.AddRange(lines);
            // создаем класс для получения характеристик выборки
            var sample = new List<double>();
            foreach (string line in lines)
            {
                sample.Add(Convert.ToDouble(line));
            }
            var chauvenetCriterion = new ChauvenetCriterionLib.ChauvenetCriterion(sample);

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            double mean = chauvenetCriterion.GetCurrentMean();
            double sd = chauvenetCriterion.GetCurrentStandardDeviation();

            label3.Text = String.Format("{0:F4}", mean);
            label4.Text = String.Format("{0:F4}", sd);

            double criticalValue = chauvenetCriterion.GetCriticalValue();
            label8.Text = String.Format("{0:F4}", criticalValue);
            label6.Text = String.Format("{0:F4}", chauvenetCriterion.GetSignificance(mean - sd * criticalValue));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InitialSampleBox.Items.Count == 0)
            {
                MessageBox.Show("Choose file with initial sample");
                return;
            }
            pictureBox1.Image = Image.FromFile("../../images/arrow_right.png");
            pictureBox1.Visible = true;
            label1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
