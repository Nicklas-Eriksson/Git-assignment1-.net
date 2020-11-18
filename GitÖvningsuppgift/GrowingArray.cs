using System;
using System.Collections.Generic;
using System.Text;

namespace GitÖvningsuppgift
{
    class GrowingArray
    {
        private int[] intArray;
        private int currentPosition = 0;

        public GrowingArray()
        {
            intArray = new int[2];
        }

        public void Add(int intToAdd)
        {
            intArray[currentPosition] = intToAdd;
            currentPosition++;

            if(currentPosition >= intArray.Length)
            {
                int[] tempArray = new int[intArray.Length * 2];

                for (int i = 0; i < intArray.Length; i++)
                {
                    tempArray[i] = intArray[i];
                }
                intArray = tempArray;
                
            }
            
            
        }
    }
}
