using System.Collections.Generic;

namespace DotNetNews
{
    public class Example_Record
    {

        #region Test1
        public record Person(string FirstName, string LastName);

        public void Test1()
        {
            var p = new Person("test", "test 2");
            var persons = new List<Person>()
            {
                new Person("Ali", "Veli"),
                new Person("ABC", "DEF")
            };
        }
        #endregion

        #region Test2
        public record PersonExtend : Person
        {
            public string PhoneNumber { get; init; }
            public int Age { get; set; }

            public PersonExtend(string firstName, string lastName)
                : base(firstName, lastName)
            {
            }
        }

        public void Test2()
        {
            var test = new PersonExtend("Test", "Test2")
            {
                PhoneNumber = "1234"
            };
            test.Age = 10;
            // Err! test.PhoneNumber = "123";
        }
        #endregion

        #region Test3
        public class Student
        {
            public string Name { get; init; }
            public string Surname { get; init; }
            public string Phone { get; set; }
        }

        public void Test3()
        {
            var student = new Student()
            {
                Name = "Caner",
                Surname = "Sarıgül"
            };

            student.Phone = "1234";

            // Can't change after initialization - student.Name = "Okan";
            //student.Name = "Okan";
        }
        #endregion

        public void Test4()
        {
            var person = new Person("FirstName", "LastName");
            var person2 = person with { FirstName = "Caner" };
            var person3 = person with { FirstName = "Caner" };

            if (person == person2)
            {

            }

            if (person2 == person3)
            {

            }

            if (ReferenceEquals(person2, person3))
            {

            }
        }
    }
}