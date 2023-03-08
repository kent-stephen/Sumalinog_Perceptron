using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumalinog_Regression
{
    internal class Perceptron
    {
        private double[] weights;
        private double bias;
        private int numInputs;
        private double learningRate = 0.1;

        public Perceptron(int numInputs)
        {
            this.numInputs = numInputs;
            weights = new double[numInputs];
            Random random = new Random();
            for (int i = 0; i < numInputs; i++)
            {
                weights[i] = random.NextDouble();
            }
            bias = random.NextDouble();
        }

        public int Predict(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < numInputs; i++)
            {
                sum += inputs[i] * weights[i];
            }
            sum += bias;
            return Activate(sum);
        }

        public void Train(double[][] inputs, int[] targets, int numOfEpochs)
        {
            for (int epoch = 0; epoch < numOfEpochs; epoch++)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    int prediction = Predict(inputs[i]);
                    int error = targets[i] - prediction;
                    for (int j = 0; j < numInputs; j++)
                    {
                        weights[j] += error * inputs[i][j] * learningRate;
                    }
                    bias += error * learningRate;
                }
            }
        }

        private int Activate(double sum)
        {
            if (sum > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
