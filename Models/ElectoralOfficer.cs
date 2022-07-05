using System;
using VotingApp.Enums;
using VotingApp.Repositories;
using VotingApp.Models;

namespace VotingApp.Models
{
    public class ElectoralOfficer
    {
         public int Id { get; set; }
        public string ElectoralCommitteeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public ElectoralOfficer(int id, string firstName, string lastName, string email, Gender gender, 
        DateTime dob, string address, string phoneNumber, string password,Role role)
        {
            Id = id;
            ElectoralCommitteeNo = $"ST{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            DateOfBirth = dob;
            Address = address;
            PhoneNumber = phoneNumber;
            Password = password;
            Role = role;
        }
    }
}