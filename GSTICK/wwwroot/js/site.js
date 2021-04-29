// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    GetGameDetails = (url) => {
        try {
            $.ajax({
                type: 'GET',
                url: url,
                contentType: false,
                processData: false,
                success: function (res) {
                    $('#GameDetailsModal .modal-body').html(res);
                    $('#GameDetailsModal').modal('show');
                },
                error: function (err) {
                    console.log(err)
                }
            })
            return false;
        } catch (ex) {
            console.log(ex)
        }
    }
});

// Initialize and add the map
function initMap() {
    // The location of Uluru
    const odessa = {
        lat: 46.484310,
        lng: 30.738197
    };
    // The map, centered at Uluru
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 16,
        center: odessa,
    });
    // The marker, positioned at Uluru
    const marker = new google.maps.Marker({
        position: odessa,
        map: map,
    });
}

completed = function (xhr) {
    $(".contact-us__form button").attr('disabled', true);
    $(".contact-us__form button").text('Заявка принята!');
    $(".contact-us__form button").css('background-color', 'lightgrey');

};