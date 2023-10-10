
function BlockNumbers(e) {
    if (e.which >= 48 && e.which <= 57) {
        e.preventDefault();
    }
}

function BlockLetters(e) {
    if (e.which >= 65 && e.which <= 90 || e.which >= 97 && e.which <= 122)
        e.preventDefault();
}

function validatePhoneNumber(value, event) {
    let phoneReg = /^[0-9]{3}-[0-9]{3}-[0-9]{4}$/;


    if (!phoneReg.test(value)) {
        $(".phone-error").text("phone number should be 10 digits  ");
        $(".phone-error").addClass('phone-error');
    } else {
        $(".phone-error").text('');
        $(".phone-error").removeClass('phone-error');
    }
}




function validateUsername(value, element) {
    let UsernameReg = /^[A-Za-z]\w{5,29}$/;
    if (!UsernameReg.test(value)) {
        $(".username-error").text("The username must consist of a minimum of 5 characters and cannot begin with a number.");
        $(".username-error").addClass('username-error');
    } else {
        $(".username-error").text('');
        $(".username-error").removeClass('username-error');
    }
}



function validatePassword(value, element) {
    let PasswordReg = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
    if (!PasswordReg.test(value)) {
        $(".password-error").text("Must contain at least one number and one uppercase and lowercase letter, and be at least 8 characters long");
        $(".password-error").addClass('password-error');
    } else {
        $(".password-error").text('');
        $(".password-error").removeClass('password-error');
    }
}

function validateConfirmPassword(value) {
    let passwordValue = document.getElementById("password").value;
    if (value !== passwordValue) {
        $(".confirmpassword-error").text("Passwords must match");
        $(".confirmpassword-error").addClass('confirmpassword-error');
    } else {
        $(".confirmpassword-error").text('');
        $(".confirmpassword-error").removeClass('confirmpassword-error');
    }
}

function validateEmail(value, element) {
    let EmailReg = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (!EmailReg.test(value)) {
        $(".email-error").text("Please enter a valid email address ");
        $(".email-error").addClass('email-error');
    } else {
        $(".email-error").text('');
        $(".email-error").removeClass('email-error');
    }
}


function validateFirstName(value, element) {

    let FirstNameReg = /^[A-Za-z]{3,}$/;

    if (!FirstNameReg.test(value)) {
        $(".Fname-error").text("First Name must be at least 3 characters and contain only letters.");
        $(element).addClass('Fname-error');
    } else {
        $(".Fname-error").text('');
        $(element).removeClass('Fname-error');
    }
}



function validateLastName(value, element) {

    let LastNameReg = /^[A-Za-z]{3,}$/;

    if (!LastNameReg.test(value)) {
        $(".Lname-error").text("Last Name must be at least 3 characters and contain only letters.");
        $(element).addClass('Lname-error');
    } else {
        $(".Lname-error").text('');
        $(element).removeClass('Lname-error');
    }
}

function validateDOB(value, element) {

    let DOBReg = /^\d{4}-\d{2}-\d{2}$/;


    if (!DOBReg.test(value)) {
        $(".DOB-error").text("Please enter a valid date of birth (MM-DD-YYY).");
        $(element).addClass('DOB-error');
    } else {

        let inputDate = new Date(value);
        let currentDate = new Date();
        if (inputDate > currentDate) {
            $(".DOB-error").text("Date of birth cannot be in the future.");
            $(element).addClass('DOB-error');
        } else {

            let minDOB = new Date(currentDate.getFullYear() - 18, currentDate.getMonth(), currentDate.getDate());

            if (inputDate > minDOB) {
                $(".DOB-error").text("You must be at least 18 years old.");
                $(element).addClass('DOB-error');
            } else {

                $(".DOB-error").text('');
                $(element).removeClass('DOB-error');
            }
        }
    }
}

function validateDepartment(value, element) {
    let DepartmentReg = /^[A-Za-z\s]{3,50}$/;

    if (!DepartmentReg.test(value)) {
        $(".department-error").text("Department must be atleast 3 characters");
        $(".department-error").addClass("department-error");
    } else {
        $(".department-error").text('');
        $(".department-error").removeClass('department-error');
    }
}

function validateEnrollmentD(value, element) {

    let EnrollmentDReg = /^\d{4}-\d{2}-\d{2}$/;


    if (!EnrollmentDReg.test(value)) {
        $(".EnrollmentD-error").text("Please enter a valid date of birth (MM-DD-YYY).");
        $(element).addClass('EnrollmentD-error');
    } else {

        let inputDate = new Date(value);
        let currentDate = new Date();
        if (inputDate > currentDate) {
            $(".EnrollmentD-error").text("Enrollement Date cannot be in the future.");
            $(element).addClass('EnrollmentD-error');
        } else {

            $(".EnrollmentD-error").text('');
            $(element).removeClass('EnrollmentD-error');
        }
    }
}

/*---------------------------------------------------------------------------*/


var currentSection = 1;
var totalSections = 2;

function nextSection() {

    var currentSectionElement = document.getElementById("Part" + currentSection);
    currentSectionElement.style.display = "none";


    if (currentSection < totalSections) {
        document.getElementById("registerButton").style.display = "none";
        currentSection++;
        var nextSectionElement = document.getElementById("Part" + currentSection);
        nextSectionElement.style.display = "block";
    }


    if (currentSection === totalSections) {
        document.getElementById("registerButton").style.display = "block";
    } else {
        document.getElementById("registerButton").style.display = "none";
    }
}

function previousSection() {
    var currentSectionElement = document.getElementById("Part" + currentSection);
    currentSectionElement.style.display = "none";

    if (currentSection > 1) {
        currentSection--;
        var previousSectionElement = document.getElementById("Part" + currentSection);
        previousSectionElement.style.display = "block";
    }


    document.getElementById("registerButton").style.display = "none";
}