
//$(document).ready(function () {
//    console.log("ready!");
//    alert("ready")
//})


//function BlockNumbers(e) {
//    if (e.which >= 48 && e.which <= 57) {
//        e.preventDefault();
//    }
//}

//function BlockLetters(e) {
//    if (e.which >= 65 && e.which <= 90 || e.which >= 97 && e.which <= 122)
//        e.preventDefault();
//}

//function validatePhoneNumber(value, event) {
//    let phoneReg = /^([0-9]){3}-[0-9]{3}-[0-9]{4}$/;


//    if (!phoneReg.test(value)) {
//        $(".phone-error").text("phone number should be this format 555-555-5555  ");
//        $(".phone-error").addClass('error');
//    } else {
//        $(".phone-error").text('');
//        $(".phone-error").removeClass('error');
//    }
//}




//function validateUsername(value, element) {
//    let UsernameReg = /^[A-Za-z]\w{5,29}$/;
//    if (!UsernameReg.test(value)) {
//        $(".username-error").text("The username must consist of a minimum of 5 characters and cannot begin with a number.");
//        $(".username-error").addClass('error');
//    } else {
//        $(".username-error").text('');
//        $(".username-error").removeClass('error');
//    }
//}




//function validatePassword(value) {
//    console.log("Validating Password.")
//    let PasswordReg = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
//    if (!PasswordReg.test(value)) {
//        $(".password-error").text("Must contain at least one number and one uppercase and lowercase letter, and be at least 8 characters long");
//        $(".password-error").addClass('error');
//    } else {
//        $(".password-error").text('');
//        $(".password-error").removeClass('error');
//    }
//    validateConfirmPassword(document.getElementById("confirmPassword").value);
//}

//function validateConfirmPassword(value) {
    
//    let passwordValue = document.getElementById("password").value;
//    if (value !== passwordValue || value === "") {
//        $(".confirmpassword-error").text("Passwords must match");
//        $(".confirmpassword-error").addClass('error');
//    } else {
//        $(".confirmpassword-error").text('');
//        $(".confirmpassword-error").removeClass('error');
//    }
//}

//function validatePassword(value) {
//    let PasswordReg = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
//    if (!PasswordReg.test(value)) {
//        $(".password-error").text("Must contain at least one number and one uppercase and lowercase letter, and be at least 8 characters long");
//        $(".password-error").addClass('error');
//    } else {
//        $(".password-error").text('');
//        $(".password-error").removeClass('error');
//    }
   
//    validateConfirmPassword(document.getElementById("confirmPassword").value);
//}


document.addEventListener("DOMContentLoaded", function () {
   
    const togglePassword = document.getElementById('togglePassword');
    const password = document.getElementById('password');

    togglePassword.addEventListener('click', function (e) {
        const type = password.getAttribute('type') === 'password' ? 'text' : 'password';
        password.setAttribute('type', type);
        this.classList.toggle('fa-eye-slash');
    });

    const toggleConfirmPassword = document.getElementById('toggleConfirmPassword');
    const confirmPassword = document.getElementById('confirmPassword');

    toggleConfirmPassword.addEventListener('click', function (e) {
        const type = confirmPassword.getAttribute('type') === 'password' ? 'text' : 'password';
        confirmPassword.setAttribute('type', type);
        this.classList.toggle('fa-eye-slash');
    });
});


//function validateConfirmPassword(value) {
    
//    let passwordValue = document.getElementById("password").value;
//    if (value !== passwordValue) {
//        $(".confirmpassword-error").text("Passwords must match");
//        $(".confirmpassword-error").addClass('error');
//    } else {
//        $(".confirmpassword-error").text('');
//        $(".confirmpassword-error").removeClass('error');
//    }
//}


//function validateEmail(value, element) {
//    let EmailReg = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
//    if (!EmailReg.test(value)) {
//        $(".email-error").text("Please enter a valid email address ");
//        $(".email-error").addClass('error');
//    } else {
//        $(".email-error").text('');
//        $(".email-error").removeClass('error');
//    }
//}


//function validateFirstName(value, element) {

//    let FirstNameReg = /^[A-Za-z]{3,}$/;

//    if (!FirstNameReg.test(value)) {
//        $(".Fname-error").text("First Name must be at least 3 characters and contain only letters.");
//        $(".Fname-error").addClass('error');
//    } else {
//        $(".Fname-error").text('');
//        $(".Fname-error").removeClass('error');
//    }
//}



//function validateLastName(value, element) {

//    let LastNameReg = /^[A-Za-z]{3,}$/;

//    if (!LastNameReg.test(value)) {
//        $(".Lname-error").text("Last Name must be at least 3 characters and contain only letters.");
//        $(".Lname-error").addClass('error');
//    } else {
//        $(".Lname-error").text('');
//        $(".Lname-error").removeClass('error');
//    }
//}

//function validateDOB(value, element) {

//    let DOBReg = /^\d{4}-\d{2}-\d{2}$/;


//    if (!DOBReg.test(value)) {
//        $(".DOB-error").text("Please enter a valid date of birth (MM-DD-YYY).");
//        $(".DOB-error").addClass('error');
//    } else {

//        let inputDate = new Date(value);
//        let currentDate = new Date();
//        if (inputDate > currentDate) {
//            $(".DOB-error").text("Date of birth cannot be in the future.");
//            $(".DOB-error").addClass('error');
//        } else {

//            let minDOB = new Date(currentDate.getFullYear() - 18, currentDate.getMonth(), currentDate.getDate());

//            if (inputDate > minDOB) {
//                $(".DOB-error").text("You must be at least 18 years old.");
//                $(".DOB-error").addClass('error');
//            } else {

//                $(".DOB-error").text('');
//                $(".DOB-error").removeClass('error');
//            }
//        }
//    }
//}

//function validateDepartment(value, element) {
//    let DepartmentReg = /^[A-Za-z\s]{3,50}$/;

//    if (!DepartmentReg.test(value)) {
//        $(".department-error").text("Department must be atleast 3 characters and should not start with a number.");
//        $(".department-error").addClass("error");
//    } else {
//        $(".department-error").text('');
//        $(".department-error").removeClass('error');
//    }
//}

//function validateEnrollmentD(value, element) {

//    let EnrollmentDReg = /^\d{4}-\d{2}-\d{2}$/;


//    if (!EnrollmentDReg.test(value)) {
//        $(".EnrollmentD-error").text("Please enter a valid date of birth (MM-DD-YYY).");
//        $(".EnrollmentD-error").addClass('error');
//    } else {

//        let inputDate = new Date(value);
//        let currentDate = new Date();
//        if (inputDate > currentDate) {
//            $(".EnrollmentD-error").text("Enrollement Date cannot be in the future.");
//            $(".EnrollmentD-error").addClass('error');
//        } else {

//            $(".EnrollmentD-error").text('');
//            $(".EnrollmentD-error").removeClass('error');
//        }
//    }
//}

/*---------------------------------------------------------------------------*/

var currentSection = 1;
var totalSections = 2;

function nextSection() {
    var currentSectionElement = document.getElementById("Part" + currentSection);
    currentSectionElement.style.display = "none";

    if (currentSection < totalSections) {
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

    if (currentSection === totalSections) {
        document.getElementById("registerButton").style.display = "block";
    } else {
        document.getElementById("registerButton").style.display = "none";
    }
}

function Close() {
    window.location.href = '/Home/Login';
}

function RegisterBtnClicked() {
    ClearErrorMessages();
    var collectedData = $('form').serialize();
    $.ajax({
        type: 'POST',
        url: '/Registration/Register', 
        data: collectedData,
        success: function (response) {
            console.log(response);

            switch (String(response)) {

                case "us":
                    $("#usErrMsg").show();
                    break;
                case "password":
                    $("#passwordErrMsg").show();
                    break;
                case "confirmpassword":
                    $("#confirmpasswordErrMsg").show();
                    break;
                case "email":
                    $("#emailErrMsg").show();
                    break
                case "phone":
                    $("#phoneErrMsg").show();
                    break;
                case "fn":
                    $("#FnErrMsg").show();
                    break;
                case "ln":
                    $("#LnErrMsg").show();
                    break;
                case "r":
                    $("#RErrMsg").show();
                    break;
                case "DOB":
                    $("#DOBErrMsg").show();
                    break;
                case "DOBF":
                    $("#DOBFErrMsg").show();
                    break;
                case "DOBA":
                    $("#DOBAErrMsg").show();
                    break;
                case "department":
                    $("#departmentErrMsg").show();
                    break;
                case "en":
                    $("#enrollmentDateErrMsg").show();
                    break;
                case "1": // popup
                    showSuccessModal();
                    break;
            }
        },
        error: function (error) {
            console.error('Form submission error:', error);
        }
    });
    function ClearErrorMessages() {
        $("#FnErrMsg").hide();
        $("#LnErrMsg").hide();
        $("#usErrMsg").hide();
        $("#emailErrMsg").hide();
        $("#phoneErrMsg").hide();
        $("#DOBErrMsg").hide();
        $("#DOBFErrMsg").hide();
        $("#RErrMsg").hide();
        $("#departmentErrMsg").hide();
        $("#passwordErrMsg").hide();
        $("#confirmpasswordErrMsg").hide();
        $("#enrollmentDateErrMsg").hide();
        $("#DOBAErrMsg").hide();
    }
    function showSuccessModal() {
        $('#successModal').modal('show'); 
    }
   
}




