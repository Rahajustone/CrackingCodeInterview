using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsAndDatastructure.SearchingAlgorithms.CodingProblems
{
    class FindTheMissingNumber
    {
        public static int MissinNumberFind(int []arr)
        {
            var number = new HashSet<int>();
            foreach (var item in arr)
                number.Add(item);

            for(int i = 1; i <= arr.Length; i ++)
            {
                if (!arr.Contains(i)) return i;
            }

            return -1;
        }

        public static int MissinNumberSecondWay(int []arr)
        {
            return ((arr.Length + 1) * ((arr.Length + 2) / 2)) - arr.Sum();
        }
    }


}
