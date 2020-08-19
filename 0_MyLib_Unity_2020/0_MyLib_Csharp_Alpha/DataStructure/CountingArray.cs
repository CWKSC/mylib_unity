using MyLib_Csharp_Alpha.CommonClass;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyLib_Csharp_Alpha.DataStructure
{
    /// <summary> [min, max] </summary>
    public class CountingArray
    {
        public int[] memory;
        public int spaceSize;
        public int min;

        /// <summary> [min, max] </summary>
        public CountingArray(int min, int max)
        {
            this.min = min;
            spaceSize = max - min + 1;
            memory = new int[spaceSize];
        }
        public CountingArray(int min, int max, int[] array) 
            : this(min, max) => Count(array);

        public int this[int key]
        {
            get => memory[key - min];
            set => memory[key - min] = value;
        }

        public void Count(int[] array) => 
            array.ForEach(ele => ++this[ele]);


    }
}
