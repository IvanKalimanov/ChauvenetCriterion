using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChauvenetCriterionLib
{
    public static class Functions
    {
        public static List<float> ReadSampleFromFile(string path)
        {
            bool isCorrect;

            string[] lines = System.IO.File.ReadAllLines(path);
            List<float> sample = new List<float>();

            foreach (string line in lines)
            {
                isCorrect = float.TryParse(line, out float temp);

                if (!isCorrect)
                {
                    throw new Exception("The numbers in the sample must be float!");
                }

                sample.Add(temp);
            };

            return sample;
        }
    }
}

