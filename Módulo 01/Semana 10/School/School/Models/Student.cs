﻿using School.Models;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Period { get; set; }
        public int RA { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Student_Discipline> Students_Disciplines { get; set; }
    }
}