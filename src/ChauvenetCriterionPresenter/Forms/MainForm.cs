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
            double n = 5;
            double zh = Meta.Numerics.Functions.AdvancedMath.InverseErf((2*n-1)/(2*n)) * Math.Sqrt(2);

            label1.Text = String.Format("{0,12:#.00000}", zh);
        }
    }
}
