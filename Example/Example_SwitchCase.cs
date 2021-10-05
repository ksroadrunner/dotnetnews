using System;
namespace DotNetNews
{
    public class Example_SwitchCase
    {
        public void Test1()
        {
            string abc = "test";
            switch (abc)
            {
                case "1":
                    break;

                case "2":
                    break;

                default:
                    break;
            }
        }

        public void Test2()
        {
            var developer = new
            {
                Name = "Caner",
                Surname = "Sarıgül",
                Team = "RoadRunner",
                Age = 30
            };

            Func<int, bool> checkDeveloperAge = (a) => a is <= 36 or > 50;
            switch (developer)
            {
                case
                {
                    Name: "Caner",
                    Surname: "Test",
                    Age: > 20 and < 35
                }:
                    break;

                case
                {
                    Team: "RoadRunner"
                }
                when checkDeveloperAge(developer.Age):
                    break;

            }


            var favoriteBook = "Jack Kerouac - On the road";
            switch ((favoriteBook, developer))
            {
                case ("Neil Young - Waging heavy peace", { Name: "Okan" }):
                    break;

                case ("George Orwell - 1984", { Team: "RoadRunner" }):
                    break;

                default:
                    break;
            }
        }

        #region Test3
        public enum RoadRunnerMembers : int
        {
            Okan = 1,
            Ipek = 2,
            Sertac = 3,
            Gokhan = 4,
            Berra = 5,
            Aysegul = 6,
            Caner = 7,
            Gulcin = 8
        };

        public string GetTeamMemberId(RoadRunnerMembers member) =>
            member switch
            {
                RoadRunnerMembers.Aysegul => "Ayşegül",
                RoadRunnerMembers.Ipek => "İpek",
                RoadRunnerMembers.Berra => "Berra",
                RoadRunnerMembers.Gulcin => "Gülçin",

                _ => throw new Exception(":)")
            };

        public RoadRunnerMembers GetMember(string name, string surname)
            => (name.ToLower(), surname) switch
            {
                ("okan", "Tiryaki") => RoadRunnerMembers.Okan,
                ("caner", "Sarıgül") => RoadRunnerMembers.Caner,
                ("gökhan", "Ergün") => RoadRunnerMembers.Gokhan,
                ("sertaç", "Yıldırım") => RoadRunnerMembers.Sertac,
                _ => throw new Exception(":)")
            };

        public record Student(string Name, string Surname, int Age);
        public RoadRunnerMembers GetStudentId(Student student) =>
            student switch
            {
                { Name: "Gökhan", Surname: "Ergün", Age: 10 } => RoadRunnerMembers.Gokhan,
                { Name: "Gökhan", Surname: "Ergün", Age: > 20 and < 30 } => RoadRunnerMembers.Gokhan,
                { Name: "Okan", Surname: "Tiryaki" } => RoadRunnerMembers.Okan,
                { Name: "İpek", Surname: "Erten" } => RoadRunnerMembers.Ipek,
                { Name: "Berra", Surname: "Ekmekcioglu" } => RoadRunnerMembers.Berra,
                _ => throw new Exception("Bla bla...")
            };
        #endregion
    }
}