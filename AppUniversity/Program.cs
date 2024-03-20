using System;
using AppUniversity.Model;
using AppUniversity.Shared;

namespace AppUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student()
            {
                Name = "Doter",
                Age = 18,
            };
            var student2 = new Student()
            {
                Name = "Voter",
                Age = 15,
            };

            var studentRepo = new StudentRepo();
            studentRepo.Create(student1);
            studentRepo.Create(student2);


            var subject1 = new Subject()
            {
                Name = "Math",
                DateStart = new DateTime(2022, 11, 01),
                DateEnd = new DateTime(2022, 11, 10),
            };
            var subjectRepo = new SubjectRepo();
            subjectRepo.Create(subject1);


            var journalRepo = new JournalRepo(studentRepo, subjectRepo);

        }
    }
}



 //создать 20 студентов и 10 предметов

 //   1 - средняя успеваемость всех студентов по каждомум предмету
 //   2 -  средняя успеваемость по каждому предмету для каждого студента