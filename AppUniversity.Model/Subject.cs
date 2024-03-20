using System;

namespace AppUniversity.Model
{
    public class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Subject()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public Subject(string id)
        {
            Id = id ?? Guid.NewGuid().ToString("N");
        }
    }
}
