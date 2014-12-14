
$(document).ready(function () {

    $('body').on('click', '.ajax-link', function () {
        var btnClicked = $(this); //If 'this' is used inside the GET block, it no longer refers to the button.
        var btnID = $(this).attr('id')

        $.get($(this).data('url'), function (data) {
            if (btnClicked.hasClass('submenu')) {
                $('#subContainer').html(data);

                $('#container').find('.ajax-link').removeClass('active'); //Remove Active class off of all buttons in Container
                btnClicked.addClass('active'); //Add it to the clicked button.
            }
            else {
                $('#container').html(data);
                $('header').find('.ajax-link').removeClass('active'); //Remove Active class off of all buttons in the header
                $('#' + btnID).addClass('active'); //Add it to the clicked button.

            }
        });
    });

    $('body').on('submit', '.ajax-form', function (event) {

        //Preventing the default behaviour of a form.
        event.preventDefault();

        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
            //Update the content area.
            $('#container').html(data);
        });
    });

});