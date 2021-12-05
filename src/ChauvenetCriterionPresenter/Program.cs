using ChauvenetCriterionLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChauvenetCriterionPresenter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int n = 5;
            double zh = Meta.Numerics.Functions.AdvancedMath.InverseErf((2 * n - 1) / (2 * n)) * Math.Sqrt(2);
            Application.Run(new MainForm());

        }


    }


}
