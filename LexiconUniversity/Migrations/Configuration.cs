namespace LexiconUniversity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LexiconUniversity.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconUniversity.DAL.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LexiconUniversity.DAL.UniversityContext context)
        {

            var courses = new Course[] {
                new Course { Title = ".NET ND16" },
                new Course { Title = ".NET NA17" },
                new Course { Title = "Java JD16" },
                new Course { Title = "Support SC16" },
                new Course { Title = "Java4Women JWA16" }
            };

            context.Courses.AddOrUpdate(c=> c.Title, courses);
            context.SaveChanges();


            context.Students.AddOrUpdate(
                s => s.Name,
                new Student() { Name = "Anna Andersson", CourseId = courses[0].Id },
                new Student() { Name = "Berra Bertilsson", CourseId = courses[0].Id },
                new Student() { Name = "Calle Karlsson", CourseId = courses[0].Id },
                new Student() { Name = "Dina Nemesis", CourseId = courses[2].Id },
                new Student() { Name = "Erik Acolyte", CourseId = courses[3].Id }
                );

            var teacher = new Teacher();
            teacher.Name = "Örjan Undervisare";
            teacher.Department = "Mathematics";
            context.Teachers.AddOrUpdate(t => t.Name, teacher);
            context.SaveChanges();

            //var dbTeacher = context.Teachers
            //    .Include(t => t.TaughtCourses)
            //    .Where(t=>t.Id == teacher.Id)
            //    .FirstOrDefault();

            //dbTeacher.TaughtCourses.Add(courses[0]);
            //context.Teachers.AddOrUpdate(t => t.Name, dbTeacher);

        }
    }
}
