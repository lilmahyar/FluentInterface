using System;

namespace FluentInterface
{
    public class FluentStudent
    {
        private Student student = new Student();

        public FluentStudent NameOfStudent(string studentName)
        {
            student.Name = studentName;
            return this;
        }
        public FluentStudent Born(string birthDate)
        {
            student.Birthday = Convert.ToDateTime(birthDate);
            return this;
        }
        public FluentStudent GetAddress(string address)
        {
            student.Address = address;
            return this;
        }
        public FluentStudent GetSchoolName(string school)
        {
            student.HighSchool = school;
            return this;
        }
    }
}
