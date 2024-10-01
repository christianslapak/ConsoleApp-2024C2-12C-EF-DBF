using System;
using System.Collections.Generic;

namespace ConsoleApp_2024C2_12C_EF_DBF.Modelo;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? TeacherId { get; set; }

    public virtual Teacher? Teacher { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
