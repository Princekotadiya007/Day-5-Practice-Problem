using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Prectice_Problem
{
    public class DeleteArray
    {
        public static T[] DeleteMethod<T>(T[] arr, T elem)
        {
            int index = Array.IndexOf(arr, elem);

            if (index != -1)
            {
                T[] result = new T[arr.Length - 1];
                Array.Copy(arr, 0, result, 0, index);
                Array.Copy(arr, index + 1, result, index, arr.Length - index - 1);
                return result;
            }
            return arr;
        }
    }
}
