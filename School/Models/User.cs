using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.RegularExpressions;
using BCrypt.Net;

namespace School.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string confirmPassword { get; set; }

        public string Salt { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public UserRole Role { get; set; }

        public DateTime DateOfBirth { get; set; }


        public string Department { get; set; }


        public DateTime EnrollmentDate { get; set; }

        public bool ValidateUsername()
        {
            string UsernameReg = "^[A-Za-z]\\w{5,29}$";
            Regex re = new Regex(UsernameReg);
            return !string.IsNullOrEmpty(Username) && re.IsMatch(Username);
        }

        //public bool ValidatePassword()
        //{
        //    string PasswordReg = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        //    Regex re = new Regex(PasswordReg);
        //    return !string.IsNullOrEmpty(Password) && re.IsMatch(Password);
        //}

        //public bool ValidateConfirmPassword()
        //{
        //    return !string.IsNullOrEmpty(confirmPassword) && confirmPassword.Equals(Password);
        //}
        //public bool ValidateEmail()
        //{
        //    string EmailReg = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        //    Regex re = new Regex(EmailReg);
        //    return !string.IsNullOrEmpty(Email) && re.IsMatch(Email);
        //}
        //public bool ValidatePhoneNumber()
        //{
        //    string PhoneReg = @"^([0-9]){3}-[0-9]{3}-[0-9]{4}$";
        //    Regex re = new Regex(PhoneReg);
        //    return !string.IsNullOrEmpty(PhoneNumber) && re.IsMatch(PhoneNumber);
        //}
        //public bool ValidateFirstName()
        //{
        //    return !string.IsNullOrEmpty(FirstName) && FirstName.Length >= 3;
        //}
        public bool ValidateLastName()
        {
            return !string.IsNullOrEmpty(LastName) && LastName.Length >= 3;
        }
        public bool ValidateRole()
        {
            return Role == UserRole.Undefined;
        }

        //public bool ValidateDeparment()
        //{
        //    string DepartmentReg = @"^[A-Za-z\s]{3,50}$";
        //    Regex re = new Regex(DepartmentReg);
        //    return !string.IsNullOrEmpty(Department) && re.IsMatch(Department);
        //}
        
        //public void HashPassword (string Password)
        //{
        //    var passwordHash = BCrypt.HashPassword(Password);

        //}


    }
    public enum UserRole
    {
        Teacher,
        Student,
        Undefined

    }


}


