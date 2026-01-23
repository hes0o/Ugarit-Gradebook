using System;

namespace Course.Models
{
    public class Course
    {
        
        public Guid Id { get; private set; }

        public string Code { get; private set; }

        public string Name { get; private set; }

        // Constructor enforces valid state at creation time
        public Course(string code, string name)
        {
            Validate(code, name);

            Id = Guid.NewGuid();     // Generate Id automatically
            Code = code.Trim();     
            Name = name.Trim();
        }
        
        // Ensures that the course is always created with valid data
        private void Validate(string code, string name)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Course code cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Course name cannot be null or empty.");
        }
    }
}

