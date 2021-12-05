using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChauvenetCriterionLib
{
    public static class Functions
    {
        public static List<double> ReadSampleFromFile(string path)
        {
            bool isCorrect;

            string[] lines = System.IO.File.ReadAllLines(path);
            List<double> sample = new List<double>();

            foreach (string line in lines)
            {
                isCorrect = double.TryParse(line, out double temp);

                if (!isCorrect)
                {
                    throw new Exception("The numbers in the sample must be float!");
                }

                sample.Add(temp);
            };

            return sample;
        }

        public static bool ChauvenetCriterion(List<double> samples, double doubtfulValue)
        {
            double mean = 0, sd = 0;
            int n = samples.Count;

            foreach (double sample in samples)
            {
                mean += sample;
            }

            mean /= n;

            foreach (double sample in samples)
            {
                sd += Math.Pow(mean - sample, 2);
            }

            sd /= n - 1;
            sd = Math.Sqrt(sd);

            double probability = MathNet.Numerics.Distributions.Normal.CDF(mean, sd, doubtfulValue) * 2;

            Console.WriteLine(probability);

            return probability * n >= 0.5;
        }
    }
}

