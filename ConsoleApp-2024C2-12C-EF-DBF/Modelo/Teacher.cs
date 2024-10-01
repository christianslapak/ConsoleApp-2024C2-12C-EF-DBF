﻿using System;
using System.Collections.Generic;

namespace ConsoleApp_2024C2_12C_EF_DBF.Modelo;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? TeacherName { get; set; }

    public int? StandardId { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual Standard? Standard { get; set; }
}
