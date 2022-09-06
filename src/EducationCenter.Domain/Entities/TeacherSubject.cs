﻿namespace EducationCenter.Domain.Entities;

internal class TeacherSubject
{
    public long? TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; }

    public long? SubjectId { get; set; }
    public virtual Subject Subject { get; set; }

    public DateTime RegistrDate { get; set; }

    public TeacherSubject()
    {
        Teacher = new Teacher();
        Subject = new Subject();
    }
}
