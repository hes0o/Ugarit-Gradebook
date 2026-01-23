using System;
using System.Collections.Generic;
using System.Linq;

namespace UgaritGradebook.Services
{
    public class GradebookService
    {
        private Dictionary<string, string> students = new();
        private Dictionary<string, string> courses = new();
        private List<(string studentNumber, string courseCode, double score)> grades = new();

        public void AddStudent(string fullName, string studentNumber)
        {
            if (!students.ContainsKey(studentNumber))
                students.Add(studentNumber, fullName);
        }

        public void AddCourse(string code, string name)
        {
            if (!courses.ContainsKey(code))
                courses.Add(code, name);
        }

        public void RecordGrade(string studentNumber, string courseCode, double score)
        {
            if (students.ContainsKey(studentNumber) && courses.ContainsKey(courseCode))
                grades.Add((studentNumber, courseCode, score));
        }

        public string GetStudentReport(string studentNumber)
        {
            if (!students.ContainsKey(studentNumber))
                return "Student not found.";

            string report = $"Student: {students[studentNumber]}\n";

            foreach (var g in grades.Where(x => x.studentNumber == studentNumber))
                report += $"{courses[g.courseCode]}: {g.score}\n";

            return report;
        }

        public string GetCourseReport(string courseCode)
        {
            if (!courses.ContainsKey(courseCode))
                return "Course not found.";

            string report = $"Course: {courses[courseCode]}\n";

            foreach (var g in grades.Where(x => x.courseCode == courseCode))
                report += $"{students[g.studentNumber]}: {g.score}\n";

            return report;
        }
    }
}