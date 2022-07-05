using System;
using VotingApp.Models;
using VotingApp.Enums;

namespace VotingApp.Models
{
public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string MatricNo { get; set; }
        public string Password { get; set; }
        public Level Level { get; set; }


        protected Person(int id, string firstName, string lastName, Gender gender, string matricNo,  string password, Level level )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            MatricNo = matricNo;
            Password = password;
            Level = level;
        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        } 

    }
}