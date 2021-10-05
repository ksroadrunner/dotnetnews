using System;
using System.Collections.Generic;
using System.IO;

namespace DotNetNews
{
    public class Example_Others
    {
        public void Test1()
        {
            // var fileInfo = new FileInfo("BeepBeep.txt").OpenRead();
            // using (fileInfo)
            // {
            // }

            // var fileInfo = new FileInfo("BeepBeep.txt").OpenRead();
            // fileInfo.Dispose();

            using var x = new FileInfo("BeepBeep.txt").OpenRead();

            // Actions
        }

        public void Test2()
        {
            string name = "RoadRunner";
            //if (name == "RoadRunner" || name == "BeepBeep!")
            //{

            //}

            //if(new[] { "RoadRunner", "BeepBeep!" }.Contains(""))
            //{

            //}

            if (name is "RoadRunner" or "BeepBeep!" or "Test")
            {

            }

            int salary = 5000;
            if (salary is >= 100 and <= 60000)
            {

            }
        }

        public void Test2A()
        {
            var student = new
            {
                Class = new
                {
                    Name = "1-A",
                    Capacity = 20
                },
                Name = "Okan"
            };

            // C# 9
            if (student is { Class: { Name: "1-A" or "1-C" } })
            {

            }

            // C# 10 - Pre
            // if(student is { Class.Name : "1-A" })
            // {
            //
            // }

            if (student.Name is { Length: 5 })
            {

            }
        }

        public void Test3()
        {
            object x = 0;
            if (!(x is null))
            {

            }

            if (x is not null)
            {
            }

            object xx = 0;
            if (xx is int number)
            {

            }
        }

        public void Test4()
        {
            // _ discard
            Func<int, int, int> funcEmpty = (_, _) => 5;

            funcEmpty(0, 0);
        }

        public void Test5()
        {
            var abc = new List<string>();
            List<string> list = new();
            list = new() { "Test", "Test2" };

            var arr = new[] { 1, 2, 3, new object() };
            var arr2 = new[] { 1, 2, 3, 4L };
            var arr3 = new[] { 1, 2D, 3L, 4f };

            var x = default(int);
            Test6(list);
            Test6(new());
            Test6(default);
        }

        private void Test6(List<string> items)
        {
            items.Add("1");
            items.Add("2");
            items.Add("3");
        }

    }
}