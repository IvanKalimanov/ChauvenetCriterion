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
        public          int N             { get; }

        public ChauvenetCriterion(List<double> initialSample)
        {
            InitialSample = initialSample;
            CurrentSample = initialSample;
            N = initialSample.Count;
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
    }
}
