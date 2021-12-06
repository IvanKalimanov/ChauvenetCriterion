using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChauvenetCriterionLib
{
    public class ChauvenetCriterion
    {
        public List<double> InitialSample { get; }
        public List<double> CurrentSample { get; }
        public List<ChauvenetCriterionReport> Reports { get; }
        public List<double> ExcludedValues { get; }
        public int N { get; }

        public ChauvenetCriterion(List<double> initialSample)
        {
            InitialSample = initialSample.ToList();
            CurrentSample = initialSample;
            Reports = new List<ChauvenetCriterionReport>();
            ExcludedValues = new List<double>();
            N = initialSample.Count;
        }


        public bool ExcludeDoubtfulValue()
        {
            double doubtfulValue = GetDoubtfulValue();
            double mean = GetCurrentMean();
            double std = GetCurrentStandardDeviation();
            double zh = GetCriticalValue();
            double z = Math.Abs(doubtfulValue - mean) / std;

            if (z - zh > 0.001)
            {
                ChauvenetCriterionReport report = new ChauvenetCriterionReport
                {
                    N = CurrentSample.Count,
                    Mean = mean,
                    StandardDeviation = std,
                    CriticalValue = zh,
                    ExcludedValue = doubtfulValue,
                    Deviation = z,
                    Signficance = GetSignificance(doubtfulValue)
                };

                Reports.Add(report);
                CurrentSample.Remove(doubtfulValue);
                ExcludedValues.Add(doubtfulValue);
                return true;
            }

            return false;
        }

        public double GetCriticalValue()
        {
            double condition = (double)(2 * N - 1) / (2 * N);
            double zh = Meta.Numerics.Functions.AdvancedMath.InverseErf(condition) * Math.Sqrt(2);
            return zh;
        }

        public double GetSignificance(double doubtfulValue)
        {
            double mean = GetCurrentMean();
            var distribution = new Meta.Numerics.Statistics.Distributions.NormalDistribution(mean, GetCurrentStandardDeviation());

            double probability;

            if (doubtfulValue >= mean)
            {
                probability = distribution.RightProbability(doubtfulValue) * 2;
            } else
            {
                probability = distribution.LeftProbability(doubtfulValue) * 2;
            }

            return probability;
        }

        public double GetCurrentMean()
        {
            double mean = 0;

            foreach (double sample in CurrentSample)
            {
                mean += sample;
            }

            mean /= N;

            return mean;
        }

        public double GetCurrentStandardDeviation()
        {
            double mean = GetCurrentMean();
            double sd = 0;

            foreach (double sample in CurrentSample)
            {
                sd += Math.Pow(mean - sample, 2);
            }

            sd /= N - 1;
            sd = Math.Sqrt(sd);

            return sd;
        }

        private double GetDoubtfulValue()
        {
            double minValue = CurrentSample.Min();
            double maxValue = CurrentSample.Max();
            double mean = GetCurrentMean();

            if (Math.Abs(maxValue - mean) > Math.Abs(minValue - mean)) {
                return maxValue;
            }

            return minValue;
        }

    }

    public struct ChauvenetCriterionReport
    {
        public int N { get; set; }
        public double CriticalValue { get; set; }
        public double StandardDeviation { get; set; }
        public double Deviation { get; set; }
        public double Mean { get; set; }
        public double Signficance { get; set; }
        public double ExcludedValue { get; set; }


        public override string ToString()
        {
            return String.Format("Размер выборки: {0:D}\nКритическое значение: {1:F4}\nОтклонение от среднего в стандартных отклонениях: {6:F4}\n" +
                "Среднее: {2:F4}\nСтандратное отклонение: {3:F4}\nУровень значимости: {4:F4}\n" +
                "Исключенное значение: {5:F4}",
                N, CriticalValue, Mean, StandardDeviation, Signficance, ExcludedValue, Deviation);
        }
    }
}
