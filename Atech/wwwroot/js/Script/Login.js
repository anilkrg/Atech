
// Function to validate email format using regular expression
function validateEmail(email) {
    var emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    return emailRegex.test(email);
}



// Function to validate password format using regular expression
function validatePassword(password) {
    // Password should be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.
    var passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$/;
    return passwordRegex.test(password);
}

function Validatelogin() {
    IsValidate = true;

    debugger;
   
    var valemail = $('#email').val().trim();
    
    var valpassword = $('#password').val().trim();
   
    //Validatation for name
   
    //Validatation for Email
    if (valemail == "") {
        $('#vldemail').text('Email cannot be empty').css('color', 'red');
        IsValidate = false;
    }
    else if (!validateEmail(valemail)) {
        $('#vldemail').text('Please provide the valid email address').css('color', 'red');
        IsValidate = false;
    }
    else {
        $('#vldemail').text(" ");
    }




    //Validatation for Password
    if (valpassword == "") {
        $('#vldpassword').text('Password cannot be empty').css('color', 'red');
        IsValidate = false;
    } else if (!validatePassword(valpassword)) {
        $('#vldpassword').text('Invalid! Password should be 8 char, 1 upper, 1 lower, and one number.').css('color', 'red');
        IsValidate = false;
    } else {
        $('#vldpassword').text(" ");
    }


    return IsValidate;
}
