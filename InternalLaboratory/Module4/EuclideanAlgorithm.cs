using System.Diagnostics;

namespace Module4
{
    public static class EuclideanAlgorithm
    {
        private static int CalculateGCDEuclidean(int numberA, int numberB)
        {
            if (numberB == 0)
            {
                return Math.Abs(numberA);
            }

            return CalculateGCDEuclidean(numberB, numberA % numberB);
        }

        private static int CalculateGCDBinary(int numberA, int numberB)
        {
            numberA = Math.Abs(numberA);
            numberB = Math.Abs(numberB);

            if (numberA == numberB)
            {
                return numberA;
            }
                
            if (numberA == 0)
            {
                return numberB;
            }
                
            if (numberB == 0)
            {
                return numberA;
            }
                
            if ((~numberA & 1) != 0)
            {
                if ((numberB & 1) != 0)
                {
                    return CalculateGCDBinary(numberA >> 1, numberB);
                }
                    
                else
                {
                    return CalculateGCDBinary(numberA >> 1, numberB >> 1) << 1;
                }
                    
            }

            if ((~numberB & 1) != 0)
            {
                return CalculateGCDBinary(numberA, numberB >> 1);
            }
                
            if (numberA > numberB)
            {
                return CalculateGCDBinary((numberA - numberB) >> 1, numberB);
            }
                
            return CalculateGCDBinary((numberB - numberA) >> 1, numberA);
        }

        private static int CalculateGCDForSeveralNumbers(Func<int, int, int> CalculationMethod, params int[] inputArray)
        {
            int GCD = CalculationMethod(inputArray[0], inputArray[1]);

            for (int i = 2 ; i < inputArray.Length; i++)
            {
                GCD = CalculationMethod(GCD, inputArray[i]);
            }

            return GCD;
        }

        public static int CalculateGCD(out string executionTime, bool IsEuclidean, params int[] input)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int methodResult = CalculateGCD(IsEuclidean, input);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            executionTime = ts.ToString(@"dd\.hh\:mm\:ss\:fffffff");
            return methodResult;
        }

        public static int CalculateGCD(bool IsEuclidean = true, params int[] input)
        {
            if (input == null || input.Length == 0)
            {
                throw new ArgumentNullException(nameof(input), "You cannot pass zero arguments");
            }

            if (input.Length == 1)
            {
                return Math.Abs(input[0]);
            }

            return CalculateGCDForSeveralNumbers(IsEuclidean ? CalculateGCDEuclidean : CalculateGCDBinary, input);
        }
    }
}