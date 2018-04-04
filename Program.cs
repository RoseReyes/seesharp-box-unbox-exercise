using System;
using System.Collections.Generic;
using System.Linq;

namespace box_unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> multiple_type = new List<object>();
            
            multiple_type.Add((int)7);
            multiple_type.Add((int)28);
            multiple_type.Add((int)-1);
            multiple_type.Add((bool)true);
            multiple_type.Add((string)"chair");
            
            foreach (object item in multiple_type)
            {
                 if (item is int){
                     //THIS ONLY ADDS UP THE POSITIVE VALUE
                   var addInt = multiple_type.Sum(x => Convert.ToInt32(item));
                   Console.WriteLine(addInt);
                   break;
                }
            }
            
            
        }
    }
}
