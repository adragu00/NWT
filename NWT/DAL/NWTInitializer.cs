using NWT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NWT.DAL
{
    public class NWTInitializer: DropCreateDatabaseAlways<NWTContext>
    {
        protected override void Seed(NWTContext context)
        {
            var users = new List<User>()
            {
                new User() { Name = "", Lastname = "", Email = "", Course = "", Year = 1},
                new User() { Name = "", Lastname = "", Email = "", Course = "", Year = 2},
                new User() { Name = "", Lastname = "", Email = "", Course = "", Year = 3},
                new User() { Name = "", Lastname = "", Email = "", Course = "", Year = 1}
            };

            users.ForEach(user => context.Users.Add(user));

            var files = new List<File>()
            {
                new File() { Name = "", Course = "", Professor = "", Semester = 1, Author = users[0] },
                new File() { Name = "", Course = "", Professor = "", Semester = 6, Author = users[0] },
                new File() { Name = "", Course = "", Professor = "", Semester = 5, Author = users[2] },
                new File() { Name = "", Course = "", Professor = "", Semester = 3, Author = users[2] },
            };

            files.ForEach(file => context.Files.Add(file));

            var comments = new List<Comment>()
            {
                new Comment() { Text = "", Author = users[0] },
                new Comment() { Text = "", Author = users[1] },
                new Comment() { Text = "", Author = users[0] },
                new Comment() { Text = "", Author = users[2] },
                new Comment() { Text = "", Author = users[3] },
                new Comment() { Text = "", Author = users[2] }
            };

            comments.ForEach(comment => context.Comments.Add(comment));

            context.SaveChanges();
        }
    }
}