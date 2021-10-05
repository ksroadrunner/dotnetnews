using System.Collections.Generic;

namespace DotNetNews
{
    public class Example_Operators
    {
        public void Test1()
        {
            //int? x = null;
            //var y = x ?? 5;

            List<int> numbers = null;
            numbers ??= new List<int>();

            if (numbers == null)
            {
                numbers = new List<int>();
            }
            // ------

            int? i = null;
            numbers.Add(i ??= 17); // i = 17
            numbers.Add(i ?? 17); // i = null
        }
    }
}