using System;
using VotingApp.Enums;
using VotingApp.Models;

namespace VotingApp.Models
{
    public class Student : Person
    {
        public decimal Grade {get; set; }

        public Student(int id, string firstName, string lastName, Gender gender, string matricNo,  string password,
        Level level, decimal grade): base(id, firstName, lastName, gender, matricNo, password, level)
        {
            Grade = grade;
        }
        public static Student[] students = new Student[]
        {
            new Student(1, "Ade", "ola", Gender.Male, "clh/01/2022", "ola", Level.Year1, 3.7m),
            new Student(2, "Idris", "olobe", Gender.Male, "clh/02/2022", "idris", Level.Year2, 3.8m),
            new Student(3, "Aderibigbe", "musodiq", Gender.Male, "clh/03/2022", "aderibigbe", Level.Year6, 4.0m),
            new Student(4, "Hamzat", "yomi", Gender.Male, "clh/04/2022", "ola", Level.Year1, 3.5m),
            new Student(5, "Eba", "oriyomi", Gender.Female, "clh/05/2022", "eba", Level.Year3, 3.7m),
            new Student(6, "Sodiq", "sodiq", Gender.Male, "clh/06/2022", "sodiq", Level.Year6, 3.7m),
            new Student(7, "Ahmad", "tijani", Gender.Male, "clh/07/2022", "tijani", Level.Year2, 3.9m),
            new Student(8, "Adeola", "AbdulMalik", Gender.Male, "clh/08/2022", "abdulmalik", Level.Year2, 3.7m),
            new Student(9, "Hamzat", "Abdulqahar", Gender.Male, "clh/09/2022", "abdulqahar", Level.Year5, 3.6m),
            new Student(10, "Abu-Bakar", "Abdulsabur", Gender.Male, "clh/10/2022", "abdulsabur", Level.Year1, 3.7m),
            new Student(11, "Adeyemi", "Mary", Gender.Female, "clh/11/2022", "ola", Level.Year4, 3.7m),
            new Student(12, "Sulaimon", "Maryam", Gender.Female, "clh/12/2022", "maryam", Level.Year6, 3.9m),
            new Student(13, "Hamzat", "Hazimah", Gender.Female, "clh/13/2022", "hazimah", Level.Year1, 4.7m),
            new Student(14, "Hamzat", "Mozidah", Gender.Female, "clh/14/2022", "mozidah", Level.Year1, 3.7m),
            new Student(15, "Omotanle", "Omosanle", Gender.Female, "clh/15/2022", "omosanle", Level.Year4, 3.7m),
            new Student(16, "Ezikeal", "Yusuf", Gender.Male, "clh/16/2022", "yusuf", Level.Year2, 3.8m),
            new Student(17, "Adetona", "Misturah", Gender.Female, "clh/17/2022", "misturah", Level.Year1, 3.7m),
            new Student(18, "Omojomi", "Masturoh", Gender.Female, "clh/18/2022", "masturoh", Level.Year1, 4.7m),
            new Student(19, "Adeagbo", "Yasir", Gender.Male, "clh/19/2022", "oltua", Level.Year1, 3.7m),
            new Student(20, "Omokuru", "Siddiq", Gender.Male, "clh/20/2022", "siddiq", Level.Year5, 3.7m),
        };
        public static Student GetStudent(string matricNo, string password)
        {
            foreach (var student in students)
            {
                if (student.MatricNo == matricNo && student.Password == password)
                {
                    return student;
                }
            }
            return null;
        }
    }
}