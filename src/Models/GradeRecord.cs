using System;

namespace UgaritGradebook.Models  //projedeki diger modellerle uyumlu olmasi icin
{
    public class GradeRecord
    {
        public string StudentId { get; private set; }
        public string CourseId { get; private set; }
        public int Score { get; private set; }
        public DateTime RecordedAt { get; private set; }

        public GradeRecord(string studentId, string courseId, int score)
        {
            // puan araligi kontrolu burada yapilir
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            }
                StudentId = studentId;
            CourseId = courseId;
            Score = score;
            RecordedAt = DateTime.Now;
        }
    }
}