using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentStudent student = new FluentStudent();
            student.NameOfStudent("John Doe")
                .Born("2001-03-02")
                .GetAddress("Nyc ...")
                .GetSchoolName("Something ....");
            Console.WriteLine("Name : {}");
        }
    }
}
