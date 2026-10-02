using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public class Math
    {
        public double Sum(int num1, int num2) {
            return num1 + num2;
        }
        public double Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public double Sum(int[] numbers)
        {
            int current = 0;
            foreach (int number in numbers) {
                current += number;
            }
            return current;
        }

        public double Count(int[] numbers)
        {
            return numbers.Length;
        }

        public double Max(int[] numbers) { 
            int maxel = numbers[0];
            for(int i = 1; i < numbers.Length; i++){
                if (numbers[i] > maxel)
                {
                    maxel = numbers[i];
                }
                
            }
            return maxel;
        }
        public double Min(int[] numbers)
        {
            int minel = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minel)
                {
                    minel = numbers[i];
                }

            }
            return minel;
        }
    }
}
