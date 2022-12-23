var HearingSchedule = function () {

    var form = this;
    var baseUrl = 'http://localhost:55653/api';
    var isUserLs = false;

    form._constructor = function () {
        var url = window.location.href;

        $('#hearing-content .alert-success').hide();
        $('#hearing-content .alert-danger').hide();
        $('#hearing-content .row-schedule').hide();

        form._events();
    },
    form._events = function () {
        var url = window.location.href;

        $('.datepicker').datepicker({
            format: 'mm/dd/yyyy',
            startDate: '-3d'
        });

        var id = url.substring(url.lastIndexOf('/') + 1);
        console.log(url.substring(url.lastIndexOf('/')));
        if (url.indexOf("ScheduleSet") !== -1) {
            isUserLs = true;
            $('#hearing-content .row-schedule').show();
        }
        

        form.getHearingSchedule(id);

        $('#hearing-content .schedule-hearing').click(function (e) {

            form.schedule();
        });
    },
    form.getHearingSchedule = function (id) {
        $.get(`${baseUrl}/hearing/${id}`)
            .done(function (data) {
                //if (data.preFilingStatusId == 1) {
                //    $("#hearing-content .tab-content input, select, textarea").attr("disabled", true);
                //    $("#hearing-content .save-changes").hide();
                //    $('#hearing-header .breadcrumb-text').text('View Filed Case/Pleading');
                //}

                //$('#hearing-header .name').text(data.requestSubject);
                $('#hearing-content .hearing-id').val(id);
                $('#hearing-content .schedule-date').val(data.schedule);
                $('#hearing-content .hearing-type-select').val(data.hearingType);
                $("#hearing-content .meeting-link-text").val(data.meetingLink);
                $('#hearing-content .description-text').val(data.description);
            }).fail(function (error) {
                console.log('There was a problem fetching the hearing schedule. Please try again later.');
            });
    },
    form.validateForm = function () {     
        if (!isUserLs) {
            if ($('#hearing-content .schedule-date').val() === '')
                return false;
        } else {
            if ($('#hearing-content .meeting-link-text').val() === '')
                return false;
        }
         
        return true;
    },
    form.schedule = function () {

        if (form.validateForm()) {

            $.ajax({
                type: 'PUT',
                url: `${baseUrl}/hearing`,
                data: JSON.stringify({
                    id: $('#hearing-content .hearing-id').val(),
                    hearingType: parseInt($("#hearing-content .hearing-type-select :selected").val()),
                    schedule: $("#hearing-content .schedule-date").val(),
                    meetingLink: $("#hearing-content .meeting-link-text").val(),
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
                    console.log('There was a problem scheduling a virtual hearing request. Please try again later.');
                },
                async: true
            });
        } else {
            $('#hearing-content .danger-text').text('Please set a date of hearing and meeting link.');
            $('#hearing-content .alert-danger').show();
            window.scrollTo({ top: 0, behavior: 'smooth' });
        }
    }


}

var hearingSchedule = new HearingSchedule();
hearingSchedule._constructor();