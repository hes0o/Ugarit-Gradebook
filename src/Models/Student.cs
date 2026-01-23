using System;

namespace UgaritGradebook.Models
{
    public class Student
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string StudentNumber { get; private set; }

        public Student(string fullName, string studentNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("FullName is required.");

            if (string.IsNullOrWhiteSpace(studentNumber))
                throw new ArgumentException("StudentNumber is required.");

            Id = Guid.NewGuid();
            FullName = fullName;
            StudentNumber = studentNumber;
        }
    }
}