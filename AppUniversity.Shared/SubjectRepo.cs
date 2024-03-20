using System;
using System.Collections.Generic;
using System.Linq;
using AppUniversity.Model;

namespace AppUniversity.Shared
{
    public class SubjectRepo
    {
        private List<Subject> Subjects = new List<Subject>();

        public void Create(Subject sub)
        {
            var subs = Subjects.Where(s => s.Id == sub.Id).ToList();

            if (subs.Count == 0)
            {
                Subjects.Add(sub);
            }
        }

        public List<Subject> Read()
        {
            return Subjects;
        }
    }
}
