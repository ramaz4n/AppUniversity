using System;
using System.Collections.Generic;
using System.Linq;
using AppUniversity.Model;

namespace AppUniversity.Shared
{
    public class StudentRepo
    {
        private List<Student> Students = new List<Student>();

        public void Create(Student st)
        {
            var sts = Students.Where(s => s.Id == st.Id).ToList();

            if(sts.Count == 0)
            {
                Students.Add(st);
            }
        }

        public List<Student> Read()
        {
            return Students;
        }

    }
}
