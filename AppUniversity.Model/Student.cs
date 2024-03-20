using System;

namespace AppUniversity.Model
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Passport { get; set; }
        public Student()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public Student(string id)
        {
            Id = id ?? Guid.NewGuid().ToString("N");
        } 
    }
}
