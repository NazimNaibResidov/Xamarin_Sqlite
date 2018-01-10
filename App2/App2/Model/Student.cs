using SQLite.Net.Attributes;
using System;

namespace App2.Model
{
    public class Student
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime RegeditDate { get; set; }
    }
}
