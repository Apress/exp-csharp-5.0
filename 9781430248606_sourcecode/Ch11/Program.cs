using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ch12
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> firstList = new List<int>() 
            { 
                1,2,3,4
            };

            IList<string> secondList = new List<string>() 
            { 
                "One","Two","Three","Four"
            };

            var result = firstList.Zip(secondList, (x, y) => x + ":\t" + y);

            result.ToList().ForEach(x => Console.WriteLine(x));
        }



    }
}
