using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] input, Func<int, int> arithoperation)
        {
            List<int> task = new List<int>();
            foreach (int i in input)
            {
                task.Add(arithoperation(i));
            }
            return task;
            
        }
    }
}
