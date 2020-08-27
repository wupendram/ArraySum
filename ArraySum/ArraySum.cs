using System;
using System.Collections.Generic;

namespace ArraySum
{
    public class ArraySum
    {
        public int GetIndexFromArray(int[] array)
        {
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>(array);
            
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                leftList.Add(array[i]);
                rightList.Remove(array[i]);

                for (int j = 0; j < leftList.Count; j++)
                {
                    leftSum += leftList[j];
                }

                for (int k = 0; k < rightList.Count; k++)
                {
                    rightSum += rightList[k];
                }
                
                if (leftSum == rightSum)
                {
                    index = i; 
                }
            }
            return index;
        }
    }
}
