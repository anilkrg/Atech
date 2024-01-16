
$(document).ready(function () {
    debugger;

    //alert("hello");

});

debugger;

// Function to validate email format using regular expression
function validateEmail(email) {
    var emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    return emailRegex.test(email);
}
// Function to validate phone format using regular expression
function validatePhone(phone) {
    var phoneRegex = /^[0-9]{10}$/;
    return phoneRegex.test(phone);
}
// Function to validate password format using regular expression
function validatePassword(password) {
    // Password should be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.
    var passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$/;
    return passwordRegex.test(password);
}

function ValidateFunction() {
    IsValidate = true;

    debugger;
    var valname = $('#name').val().trim();
    var valemail = $('#email').val().trim();
    var valphone = $('#phone').val().trim();
    var valaddress = $('#address').val().trim();
    var valpassword = $('#password').val().trim();
    var valconfirmpassword = $('#confirmpassword').val().trim();
    var valgender = $('#gender').val().trim();

    //Validatation for name
    if (valname == "") {
        $('#vldname').text('Name cannot be empty').css('color', 'red');
        IsValidate = false;
    }
    else {
        $('#vldname').text(" ");
    }

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



    //Validatation for Phone
    if (valphone == "") {
        $('#vldphone').text('Phone number cannot be empty').css('color', 'red');
        IsValidate = false;
    } else if (!validatePhone(valphone)) {
        $('#vldphone').text('Invalid phone number format').css('color', 'red');
        IsValidate = false;
    } else {
        $('#vldphone').text(" ");
    }


    //Validatation for Address
    if (valaddress == "") {
        $('#vldaddress').text('Address cannot be empty').css('color', 'red');
        IsValidate = false;
    }
    else {
        $('#vldaddress').text(" ");
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



    
    if (valconfirmpassword == "") {
        $('#vldconfirmpassword').text('Confirm Password cannot be empty').css('color', 'red');
        IsValidate = false;
    } else if (valconfirmpassword !== valpassword) {
        $('#vldconfirmpassword').text('Passwords do not match').css('color', 'red');
        IsValidate = false;
    } else {
        $('#vldconfirmpassword').text(" ");
    }



    if (valgender === "") {
        $('#vldgender').text('Please select your gender').css('color', 'red');
        IsValidate = false;
    } else {
        $('#vldgender').text(" ");
    }

    return IsValidate;
}



$.ajax({
    type: 'POST',
    url: 'Acccount/Register',
    //data: JSON.stringify(_data),
    contentType: 'application/json',
    dataType: "JSON",
    success: function (data, xhr, error) {
        console.log("RESULT", r);
    },
    error: function (xhr, status, error) {
        var err = eval("(" + xhr.responseText + ")");
        alert(err.Message);
    }
});