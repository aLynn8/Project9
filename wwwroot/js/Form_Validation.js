//Aubrey Farnbach (Wright) Section 2 Group 1
// This script is used to validate the form entry. The form cannot be submitted until these conditions are met.
$(function () {
    // Initialize form validation on the registration form.
    $("form[name='NewMovieCollector']").validate({
        // Specify validation rules
        rules: {
            // The key name on the left side is the name attribute
            // of an input field. Validation rules are defined
            // on the right side

            Category: {
                required: true,
            },
            Title: {
                required: true,
            },
            Year: {
                required: true,
                range: [1000, 9999]
            },
            Director: {
                required: true,
            },
            Rating: {
                required: true,
            },
            Edited: {

            },
            Lent_To: {

            },
            Notes: {

            }
        },
        // Specify validation error messages
        messages: {
        // The key name on the left side is the name attribute
        // of an input field. Validation rules are defined
        // on the right side

            Category: {
                required: "Please select a category",
            },
            Title: {
                required: "Please enter the title",
            },
            Year: {
                required: "Please enter the year",
                range: "Use format YYYY"
            },
            Director: {
                required: "Please enter the director"
            },
            Rating: {
                required: "Please select the rating"
            },
            Edited: {

            },
            Lent_To: {

            },
            Notes: {

            }
        },

        submitHandler: function (form) {
            form.submit();
        }
    }); 
});