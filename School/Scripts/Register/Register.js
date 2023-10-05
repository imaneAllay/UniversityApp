function Phone_keyup(element) {
    validatePhoneNumber($(element).val(), element)
}

function validatePhoneNumber(value) {
    let phoneReg = /^\d{10}$/;
    if (!phoneReg.test(value)) {
        $("#TellErrorMsg").text("Not a valid number")
        $("#TellErrorMsg").addClass('error-text')
    } else {
        $("#TellErrorMsg").addText('');
        $("#TellErrorMsg").removeClass('error-text')
    }
}