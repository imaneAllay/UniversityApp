using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Driver;
using System.Text.RegularExpressions;

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

        public string DateOfBirth { get; set; }


        public string Department { get; set; }


        public string EnrollmentDate { get; set; }

        public bool ValidateFirstName()
        {
            return !string.IsNullOrEmpty(FirstName) && FirstName.Length >= 3;
        }
        public bool ValidateLastName()
        {
            return !string.IsNullOrEmpty(LastName) && LastName.Length >= 3;
        }
        public bool ValidateUsername()
        {
            string UsernameReg = "^[A-Za-z]\\w{5,29}$";
            Regex re = new Regex(UsernameReg);
            return !string.IsNullOrEmpty(Username) && re.IsMatch(Username);


        }

        public bool ValidateEmail()
        {
            string EmailReg = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex re = new Regex(EmailReg);
            return !string.IsNullOrEmpty(Email) && re.IsMatch(Email);
        }

        public bool ValidatePassword()
        {
            string PasswordReg = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$";
            Regex re = new Regex(PasswordReg);
            return !string.IsNullOrEmpty(Password) && re.IsMatch(Password);
        }

        public bool ValidateConfirmPassword()
        {

            //string confirmPasswordReg = @"^(?=.*\d)(?=.* [a - z])(?=.* [A - Z]).{ 8,}$";
            //Regex re = new Regex(confirmPasswordReg);
            //return !string.IsNullOrEmpty(Password) && re.IsMatch(Password);

            return !string.IsNullOrEmpty(confirmPassword) && confirmPassword.Equals(Password);
        }

        public bool ValidatePhoneNumber()
        {
            string PhoneReg = @"^([0-9]){3}-[0-9]{3}-[0-9]{4}$";
            Regex re = new Regex(PhoneReg);
            return !string.IsNullOrEmpty(PhoneNumber) && re.IsMatch(PhoneNumber);
        }

        ////public bool ValidateDOB()
        ////{
        ////    string DOBReg = @"^\d{2}-\d{2}-\d{4}$";
        ////    Regex re = new Regex(DOBReg);

        ////    return !string.IsNullOrEmpty(PhoneNumber) && re.IsMatch(DateOfBirth);

        ////}

        public bool ValidateDeparment()
        {
            string DepartmentReg = @"^[A-Za-z\s]{3,50}$";
            Regex re = new Regex(DepartmentReg);
            return !string.IsNullOrEmpty(Department) && re.IsMatch(Department);
        }


    }
    public enum UserRole
    {
        Teacher,
        Student
    }


}


