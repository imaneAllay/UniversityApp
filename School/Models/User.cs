using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Driver;

namespace School.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        //[RegularExpression(@"^[A-Za-z]\w{5,29}$", ErrorMessage = "The username must consist of a minimum of 5 characters and cannot begin with a number.")]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        //[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Must contain at least one number and one uppercase and lowercase letter, and be at least 8 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        public string confirmPassword { get; set; }

        public string Salt { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        //[RegularExpression(@"/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/", ErrorMessage = "Please enter a valid email address Ex: Sample123@email.com")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Phone number is required")]

        //[RegularExpression(@"/^([0 - 9]){3}-[0-9]{3}[0 - 9]{ 4}$/", ErrorMessage = "phone number should be this format 555-555-5555")]
        public string PhoneNumber { get; set; }

        //[RegularExpression(@"^[A-Za-z]{3,}$", ErrorMessage = "First/Last Name must be at least 3 characters and contain only letters.")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Role is required")]
        public UserRole Role { get; set; }
        //[RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "Please enter a valid date of birth (YYYY-MM-DD).")]
        [Required(ErrorMessage = "DOB is required")]
        public DateTime DateOfBirth { get; set; }

        //[RegularExpression(@"^[A-Za-z]{3,}$", ErrorMessage = "Department must be at least 3 characters and contain only letters.")]
        [Required(ErrorMessage = "Departement is required")]
        public string Department { get; set; }

        //[RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "Please enter a valid date of birth (YYYY-MM-DD).")]
        [Required(ErrorMessage = "Enrollment Date is required")]
        public DateTime EnrollmentDate { get; set; }

        //public bool IsValid()
        //{
        //    if (string.IsNullOrEmpty(FirstName))
        //    { return false; }
        //    else if(^[A - Za - z]{ 3,}$)
        //}

    }

    public enum UserRole
    {
        Teacher,
        Student
    }
}