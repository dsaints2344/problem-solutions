using System;
using System.Collections.Generic;

namespace Solution
{

    /*Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple like so: (index1, index2).
For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.
The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).
Based on: http://oj.leetcode.com/problems/two-sum/*/
    class TwoSum
    {

        public static int[] TwoSum(int[] numbers, int target)
        {

            List<int> listResult = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (listResult.Count > 0)
                {
                    return listResult.ToArray();
                }

                int tempFirstNumber = numbers[i];
                int tempFirstIndex = i;
                for (int j = numbers.Length; j-- > 0;)
                {
                    int tempSecondIndex = j;
                    if (tempFirstIndex != tempSecondIndex)
                    {
                        int tempSecondNumber = numbers[j];
                        int tempSum = tempFirstNumber + tempSecondNumber;
                        if (tempSum == target)
                        {
                            listResult.Add(tempFirstIndex);
                            listResult.Add(tempSecondIndex);
                            break;

                        }
                    }
                }
            }

            return listResult.ToArray();

        }
    }
}