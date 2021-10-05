using System;
using System.Collections.Generic;

namespace DotNetNews
{
    public class Example_Array
    {
        public void Test1()
        {
            var members = new[]
            {
                "RoadRunner",   // 0 - ^9
                "Sertaç",       // 1 - ^8
                "İpek",         // 2 - ^7
                "Ayşegül",      // 3 - ^6
                "Gökhan",       // 4 - ^5
                "Gülçin",       // 5 - ^4
                "Berra",        // 6 - ^3
                "Okan",         // 7 - ^2
                "Caner"         // 8 - ^1
            };                  // 9 - ^0

            var teamName = members[0];
            var presenter = members[^1];
            var teamMembers = members[1..9];
            var allMembers = members[..];
            var singleMembers = members[^3..];

            // Range example
            var range = 0..3;

            var rnd = new Random();
            var jackpot = new Range(rnd.Next(0, 3), rnd.Next(3, 8));
            var luckyMembers = members[jackpot];

            Console.WriteLine("Lucky members");
            Array.ForEach(luckyMembers, Console.WriteLine);

            // Index example
            var index = ^1;
            var singers = new List<string>() {
                "Joan Baez",
                "Grace Slick" ,
                "Joni Mitchell",
                "Janis Joplin"
            };
            var rockQueen = singers[index];
            Console.WriteLine($"Rock queen : {rockQueen}");

            // Not supporting :
            // var allStars = singers[..];
        }
    }
}