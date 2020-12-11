using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDatastructure.SearchingAlgorithms.Implimantation
{
    class LinearSearch
    {
        public  bool Search(int []array, int target)
        {
            foreach (var item in array)
                if (item == target)
                    return true;

            return false;
        }
    }
}
