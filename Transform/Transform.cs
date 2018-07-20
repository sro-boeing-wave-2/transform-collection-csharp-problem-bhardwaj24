using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] InputArray, Func<int, int> Operation)
        {
            List<int> OutputArray = new List<int>();
            foreach (int i in InputArray)
            {
                OutputArray.Add(Operation(i));
            }
            return OutputArray;
            
        }
    }
}
