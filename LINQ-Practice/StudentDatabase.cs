using System;
using System.Linq;

namespace LINQ_Practice
{
    public class StudentDatabase
    {
                public static IQueryable<Student> GetStudentsFromDb()
        {
            return new Student[] {
                new Student() {StudentID = 1, StudentName = "John Nigel", Score = 83, City = "NYC", IsActive = true},
                new Student() {StudentID = 2, StudentName = "Alex Roma", Score = 81, City = "CA", IsActive = true},
                new Student() {StudentID = 3, StudentName = "Noha Shemil", Score = 88, City = "CA", IsActive = false},
                new Student() {StudentID = 4, StudentName = "James Palatte", Score = 45, City = "NYC", IsActive = false},
                new Student() {StudentID = 5, StudentName = "Ron Jenova", Score = 85, City = "NYC", IsActive = true}
            }.AsQueryable();
        }

    }
}
