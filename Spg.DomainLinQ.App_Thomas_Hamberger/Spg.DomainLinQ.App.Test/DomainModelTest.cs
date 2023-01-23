using Microsoft.EntityFrameworkCore;
using NuGet.Frameworks;
using Spg.DomainLinQ.App.Infrastructure;

namespace Spg.DomainLinQ.App.Test
{
    public class DomainModelTest
    {
        private School2000Context GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=./../../../Shop2000.db");

            School2000Context db = new School2000Context(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        [Fact]
        public void Test1()
        {
            // Arrange
            School2000Context db = GenerateDb();
            Student newStudent = new Student()
            // ...

            // Act
            // ...
            db.Student.Add(newStudent);
            db.SaveChanges();

            // Assert
            Assert.Equal(1, db.Student.Count());
        }
    }
}