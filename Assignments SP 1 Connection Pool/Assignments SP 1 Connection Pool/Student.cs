﻿namespace Assignments_SP_1_Connection_Pool
{
    internal class Student
    {
        public string AridNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{AridNo} --- {Name} --- {Age}";
        }
    }
}