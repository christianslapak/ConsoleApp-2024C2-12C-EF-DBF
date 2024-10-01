using System;
using System.Collections.Generic;

namespace ConsoleApp_2024C2_12C_EF_DBF.Modelo;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int? StandardId { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public virtual Standard? Standard { get; set; }

    public virtual StudentAddress? StudentAddress { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
