using System;

namespace AppUniversity.Model
{
    public class Journal
    {
        public string Id { get; set; }
        public string IdStudent { get; set; }
        public string IdSubject { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
        public Journal()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public Journal(string id)
        {
            Id = id ?? Guid.NewGuid().ToString("N");
        }
    }
}
