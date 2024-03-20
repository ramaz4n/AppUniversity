using System;
using System.Collections.Generic;
using System.Linq;
using AppUniversity.Model;

namespace AppUniversity.Shared
{
    public class JournalRepo
    {
        private List<Journal> Journals = new List<Journal>();

        public JournalRepo(StudentRepo studRepo, SubjectRepo subRepo)
        {
            var students = studRepo.Read();
            var subjects = subRepo.Read();


            foreach(var sub in subjects)
            {
                foreach(var st in students)
                {
                    var dt = sub.DateStart;
                    while(dt <= sub.DateEnd)
                    {
                        var journal = new Journal()
                        {
                            Date = dt,
                            IdStudent = st.Id,
                            IdSubject = sub.Id
                        };
                        Journals.Add(journal);
                        dt = dt.AddDays(1);
                    }

                }
            }
        }
    }
}
