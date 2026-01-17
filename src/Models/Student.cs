using System;

namespace UgaritGradebook.Models
{
    public class Student
    {
        // استخدام Guid لضمان معرف فريد لكل طالب
        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string StudentNumber { get; private set; }

        // Constructor يقوم بإنشاء الطالب والتحقق من البيانات فوراً
        public Student(string fullName, string studentNumber)
        {
            // التحقق من أن الاسم ليس فارغاً
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full Name cannot be empty.");

            // التحقق من أن رقم الطالب ليس فارغاً
            if (string.IsNullOrWhiteSpace(studentNumber))
                throw new ArgumentException("Student Number cannot be empty.");

            Id = Guid.NewGuid(); // توليد المعرف تلقائياً
            FullName = fullName;
            StudentNumber = studentNumber;
        }
    }
}
/// <summary> ويمثل هذا النموذج بيانات الطالب في نظام أوغاريت </summary>