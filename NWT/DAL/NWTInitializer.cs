using NWT.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace NWT.DAL
{
    public class NWTInitializer: DropCreateDatabaseAlways<NWTContext>
    {
        protected override void Seed(NWTContext context)
        {
            /*
            // neovisno
            var users = new List<User>()
            {
                new User() { Name = "Mate", Lastname = "Matić", Email = "mmatic@fesb.hr", Year = 1},
                new User() { Name = "Ante", Lastname = "Antić", Email = "aantic@fesb.hr", Year = 2},
                new User() { Name = "Ivo", Lastname = "Ivić", Email = "iivic@fesb.hr", Year = 3},
                new User() { Name = "Luka", Lastname = "Lukić", Email = "llukic@fesb.hr", Year = 1}
            };

            // ovisi o users i files
            var comments = new List<Comment>()
            {
                new Comment() { Text = "bla lih laihd lidjkha", UserID = users[0].ID },
                new Comment() { Text = "lkedj liaedfj hlakhj f", UserID = users[1].ID },
                new Comment() { Text = "ldja lfj ldj alj a", UserID = users[0].ID },
                new Comment() { Text = "ldakj kfj  aljdlsakdj f", UserID = users[2].ID },
                new Comment() { Text = "hjkl,bm  jhbk gbgig", UserID = users[3].ID },
                new Comment() { Text = "lksajd kjdh sjdh ds", UserID = users[2].ID }
            };

            // ovisi o courses
            var studies = new List<Study>()
            {
                new Study() { Name = "Preddiplomski", Type = 1, Courses = new List<Course>() },
                new Study() { Name = "Stručni", Type = 2, Courses = new List<Course>() },
                new Study() { Name = "Razlikovni", Type = 3, Courses = new List<Course>() },
                new Study() { Name = "Diplomski", Type = 4, Courses = new List<Course>() }
            };

            // ovisi o subjects i studies
            var courses = new List<Course>()
            {
                new Course() { Name = "120 Računarstvo", StudyID = studies[0].ID, Subjects = new List<Subject>() },
                new Course() { Name = "530 Strojarstvo", StudyID = studies[1].ID, Subjects = new List<Subject>() },
                new Course() { Name = "540 Brodogradnja",  StudyID = studies[1].ID, Subjects = new List<Subject>() },
                new Course() { Name = "910 Automatika i sustavi",  StudyID = studies[2].ID, Subjects = new List<Subject>() },
                new Course() { Name = "250 Računarstvo",  StudyID = studies[3].ID, Subjects = new List<Subject>() }
            };

            studies[0].Courses = new List<Course>() { courses[0] };
            studies[1].Courses = new List<Course>() { courses[1], courses[2] };
            studies[2].Courses = new List<Course>() { courses[3] };
            studies[3].Courses = new List<Course>() { courses[4] };

            // ovisi o files i courses
            var subjects = new List<Subject>()
            {
                new Subject() { Name = "Matematika 1", CourseID = courses[0].ID, Semester = 1, Files = new List<File>() },
                new Subject() { Name = "Engleski jezik 2", CourseID = courses[1].ID, Semester = 2, Files = new List<File>() },
                new Subject() { Name = "Fizika 1", CourseID = courses[0].ID, Semester = 1, Files = new List<File>() },
                new Subject() { Name = "Engleski jezik 1", CourseID = courses[0].ID, Semester = 1, Files = new List<File>() },
                new Subject() { Name = "Matematika 2", CourseID = courses[1].ID, Semester = 2, Files = new List<File>() }
            };

            // ovisi o users, comments i subjects
            var files = new List<File>()
            {
                new File() { Name = "File 1", Professor = "Prof 1", UserID = users[0].ID, Comments = new List<Comment>() { comments[0], comments[1] }, Subject = subjects[0] },
                new File() { Name = "File 2", Professor = "Prof 2", UserID = users[0].ID, Comments = new List<Comment>() { comments[2] }, Subject = subjects[1] },
                new File() { Name = "File 3", Professor = "Prof 3", UserID = users[2].ID, Comments = new List<Comment>() { comments[3] }, Subject = subjects[2] },
                new File() { Name = "File 4", Professor = "Prof 4", UserID = users[2].ID, Comments = new List<Comment>() { comments[4], comments[5] }, Subject = subjects[3] },
            };

            subjects[0].Files = new List<File>() { files[0], files[1] };
            subjects[1].Files = new List<File>() { files[2], files[3] };
            /*
            files[0].Comments = new List<Comment>() { comments[0], comments[1] };
            files[1].Comments = new List<Comment>() { comments[2] };
            files[2].Comments = new List<Comment>() { comments[3] };
            files[3].Comments = new List<Comment>() { comments[4], comments[5] };*/
            /*
            comments[0].FileID = files[0].ID;
            comments[1].FileID = files[0].ID;
            comments[2].FileID = files[1].ID;
            comments[3].FileID = files[2].ID;
            comments[4].FileID = files[3].ID;
            comments[5].FileID = files[3].ID;

            // spremanje u bazu
            studies.ForEach(study => context.Studies.Add(study));
            courses.ForEach(course => context.Courses.Add(course));
            subjects.ForEach(subject => context.Subjects.Add(subject));
            users.ForEach(user => context.Users.Add(user));
            files.ForEach(file => context.Files.Add(file));
            comments.ForEach(comment => context.Comments.Add(comment));

            context.SaveChanges();*/
        }
    }
}