var Hearing = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        var url = window.location.href;

        form._events();      

        $('#hearing-content .alert-success').hide();
        $('#hearing-content .alert-danger').hide();
    },
    form._events = function () {
        var url = window.location.href;            

        $('#hearing-content .send-request').click(function (e) {
         
            form.sendrequest();
        });            
    },
    form.validateForm = function () {
        if ($('#hearing-content .hearing-type-select :selected').val().length === 0)
                return false;
         
        return true;
    },
    form.sendrequest = function () {
        console.log("sendrequest");
        if (form.validateForm()) {
            
            $.ajax({
                type: 'POST',
                url: `${baseUrl}/hearing`,
                data: JSON.stringify({                       
                    hearingType: parseInt($("#hearing-content .hearing-type-select :selected").val()),
                    description: $("#hearing-content .description-text").val()
                }),
                contentType: 'application/json; charset=utf-8',
                success: function (data) {                        
                    window.scrollTo({ top: 0, behavior: 'smooth' });
                    $('#hearing-content .success-text').text('Your have been successfully sent a request for virtual hearing.');
                    $('#hearing-content .alert-success').show();
                    $('#hearing-content .alert-danger').hide();
                },
                error: function (err) {
                    console.log('There was a problem sending a virtual hearing request. Please try again later.');
                },
                async: true
            });            
        } else {
            $('#hearing-content .danger-text').text('Please select a hearing type to proceed.');
            $('#hearing-content .alert-danger').show();
            window.scrollTo({ top: 0, behavior: 'smooth' });
        }
    }

}

var hearing = new Hearing();
hearing._constructor();

