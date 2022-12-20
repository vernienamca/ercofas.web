var Registration = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        form._events();
        form.getRERClassifications();

        $(document).ready(function () {
            $('#registration-content .juridical').hide();
            $('#registration-content .juridical-form').hide();
        });
    },
    form._events = function () {
        $(document).on("change", "#registration-content .individual-radio", function (e) {
            $('#registration-content .individual').show();
            $('#registration-content .juridical').hide();
            $('#registration-content .juridical-form').hide();
        });

        $(document).on("change", "#registration-content .juridical-radio", function (e) {
            $('#registration-content .juridical').show();
            $('#registration-content .juridical-form').show();
            $('#registration-content .individual').hide();
        });
    },
    form.getRERClassifications = function (userTypeId) {
        var endpoint = `${baseUrl}/registrations/lists`;
        if (typeof userTypeId !== "undefined")
            endpoint = `${baseUrl}/registration/lists?userTypeId=${userTypeId}`;

        $.get(endpoint)
            .done(function (data) {
                var htmlContent = '';

                for (var i = 0; i < data.length; i++) {
                    htmlContent += '<div>';
                        htmlContent += '<label>';
                            htmlContent += `<input type="radio" class="rer-classification-${data[i].id}" data-id="${data[i].id}" name="rer-classifications"> ${data[i].description}`;
                        htmlContent += '</label>';
                    htmlContent += '</div>';
                }

                console.log(data);
                $('#registration-content .rer-classification').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the RER classifications. Please try again later.');
            });
    }
}

var registration = new Registration();
registration._constructor();