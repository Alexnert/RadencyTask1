using System;
using System.Collections.Generic;
using System.Linq;

namespace RadencyTask1
{
    public class WeightComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int sumX =x.ToCharArray().Sum(x=> (int)(x-'0')); 
            int sumY =y.ToCharArray().Sum(x => (int)(x - '0'));
            
            if (sumX == sumY)
                return x.CompareTo(y);
            return sumX-sumY;

            throw new NotImplementedException();
        }
    }
    public class WeightList
    {
        public string Order(string input)
        {
            string result = "";
            if (string.IsNullOrEmpty(input))
                return result;

            string[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(numbers, new WeightComparer());

            return string.Join(" ", numbers);
        }
    }
    class Program
    {

        

        static void Main(string[] args)
        {
            WeightList weightList = new WeightList();

            string str = weightList.Order("45 34 24 108 76 58 64 130 80");
            
                Console.WriteLine(str);
            

        }
    }
}
