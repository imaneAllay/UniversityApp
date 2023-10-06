

function validatePhoneNumber(value, element) {
    let phoneReg = /^\d{10}$/;
    if (!phoneReg.test(value)) {
        $(".phone-error").text("Not a valid number");
        $(".phone-error").addClass('phone-error');
    } else {
        $(".phone-error").text('');
        $(".phone-error").removeClass('phone-error');
    }
}



function validateUsername(value, element) {
    let UsernameReg = /^[A-Za-z]\w{5,29}$/;
    if (!UsernameReg.test(value)) {
        $(".username-error").text("Not a valid username");
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



function validateEmail(value, element) {
    let EmailReg = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (!EmailReg.test(value)) {
        $(".email-error").text("Invalid email");
        $(".email-error").addClass('email-error');
    } else {
        $(".email-error").text('');
        $(".email-error").removeClass('email-error');
    }
}


function validateFirstName(value, element) {
  
    let FirstNameReg = /^[A-Za-z]{3,}$/;

    if (!FirstNameReg.test(value)) {
        $(".Fname-error").text("First Name must be at least 3 characters.");
        $(element).addClass('Fname-error');
    } else {
        $(".Fname-error").text('');
        $(element).removeClass('Fname-error');
    }
}



function validateLastName(value, element) {

    let LastNameReg = /^[A-Za-z]{3,}$/;

    if (!LastNameReg.test(value)) {
        $(".Lname-error").text("Last Name must be at least 3 characters.");
        $(element).addClass('Fname-error');
    } else {
        $(".Lname-error").text('');
        $(element).removeClass('Lname-error');
    }
}

function validateDOB(value, element) {
    
    let DOBReg = /^\d{2}-\d{2}-\d{4}$/;

   
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

function validateEnrollmentD(value, element) {

    let EnrollmentDReg = /^\d{2}-\d{2}-\d{4}$/;


    if (!EnrollmentDReg.test(value)) {
        $(".EnrollmentD-error").text("Please enter a valid date of birth (MM-DD-YYY).");
        $(element).addClass('EnrollmentD-error');
    } else {

        let inputDate = new Date(value);
        let currentDate = new Date();
        if (inputDate > currentDate) {
            $(".EnrollmentD-error").text("Enrollement Date cannot be in the future.");
            $(element).addClass('EnrollmentD-error');
        }  else {

            $(".EnrollmentD-error").text('');
            $(element).removeClass('EnrollmentD-error');
            }
        }
    }

/*---------------------------------------------------------------------------*/


    function nextSection() {
        document.getElementById("Part1").style.display = "none";
    document.getElementById("Part2").style.display = "block";
    }

    function previousSection() {
        document.getElementById("Part2").style.display = "none";
    document.getElementById("Part1").style.display = "block";
    }
