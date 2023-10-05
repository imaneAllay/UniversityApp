function Phone_keyup(element) {
    validatePhoneNumber($(element).val(), element);
}

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

function username_keyup(element) {
    validateUsername($(element).val(), element);
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

function password_keyup(element) {
    validatePassword($(element).val(), element);
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

function email_keyup(element) {
    validatePassword($(element).val(), element);
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

function Firstname_keyup(element) {
    validateFirstName($(element).val(), element);
}

function validateFirstName(value, element) {
    let FirstNameReg = /^ [A - Za - z] + $ /;
    if (!EmailReg.test(value)) {
        $(".Fname-error").text("Invalid First Name");
        $(".Fname-error").addClass('Fname-error');
    } else {
        $(".Fname-error").text('');
        $(".Fname-error").removeClass('Fname-error');
    }
}