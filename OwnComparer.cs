using System;
using System.Collections.Generic;

namespace Cw2
{
    public class OwnComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y) => StringComparer.InvariantCultureIgnoreCase.Equals($"{x.fname} {x.lname} {x.index}", $"{y.fname} {y.lname} {y.index}");

        public int GetHashCode(Student student) => StringComparer.InvariantCultureIgnoreCase.GetHashCode($"{student.fname} {student.lname} {student.index}");
    }
}