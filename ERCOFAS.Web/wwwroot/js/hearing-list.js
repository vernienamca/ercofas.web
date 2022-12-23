var HearingList = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        var url = window.location.href;

        form.getHearingListRequests($('#search-hearing-text').val(), 1);
        
    },
        form._events = function () {
            var url = window.location.href;
           
            
        },
        //form.getRole = function (id) {
        //    $.get(`${baseUrl}/roles/${id}`)
        //        .done(function (data) {
        //            $('#role-header .name').text(data.roleName);
        //            $('#role-content .role-name-text').val(data.roleName);
        //            $('#role-content .description-text').val(data.description);
        //        }).fail(function (error) {
        //            console.log('There was a problem fetching the role. Please try again later.');
        //        });
        //},
        form.getHearingListRequests = function (searchValue, currentPage, userId) {
            var endpoint = `${baseUrl}/hearing/lists?searchValue=${searchValue}&currentPage=${currentPage}`;
            if (typeof userId !== "undefined")
                endpoint = `${baseUrl}/hearing/lists?searchValue=${searchValue}&currentPage=${currentPage}&userId=userId`;

            $.get(endpoint)
                .done(function (data) {
                    var htmlContent = '';

                    for (var i = 0; i < data.items.length; i++) {
                        var hearingType = '';
                        if (data.items[i].hearingType === 1)
                            hearingType = "Initial hearing";
                        else if (data.items[i].hearingType === 2)
                            hearingType = "Written Order";
                        else
                            hearingType = "Open court";

                        htmlContent += '<tr>';
                        htmlContent += `<td>${data.items[i].id}</td>`;
                        htmlContent += `<td>${hearingType}</td>`;
                        htmlContent += `<td>${data.items[i].schedule}</td>`;
                        htmlContent += `<td><a>${data.items[i].meetingLink}</a></td>`;
                        htmlContent += `<td>${data.items[i].description}</td>`;                        
                        htmlContent += `<td>${new Date(data.items[i].dateFiled).toLocaleDateString()} 
                            ${new Date(data.items[i].dateFiled).toLocaleTimeString()}</td>`;
                        htmlContent += '<td class="text-center">';
                        htmlContent += `<button id="edit-${data.items[i].id}" data-id="${data.items[i].id}" onclick="location.href='Schedule/${data.items[i].id}'" type="button" class="btn btn-md btn-info"><i class="fa fa-eye"></i> Schedule</button>`;
                        htmlContent += '</td>';
                        htmlContent += '</tr>';
                    }

                    $('#hearing-list .count').text(data.pagination.totalItems);
                    $('#hearing-list .table-data').html(htmlContent);
                }).fail(function (error) {
                    console.log('There was a problem fetching the roles. Please try again later.');
                });
        }
        //form.validateForm = function () {
        //    if ($('#role-content .role-name-text').val().length === 0) {
        //        return false;
        //    }
        //    if ($('#role-content .description-text').val().length === 0) {
        //        return false;
        //    }
        //    return true;
        //},
        //form.save = function () {
        //    if (form.validateForm()) {
        //        $.ajax({
        //            type: 'POST',
        //            url: `${baseUrl}/roles`,
        //            data: JSON.stringify({
        //                roleName: $('#role-content .role-name-text').val(),
        //                description: $('#role-content .description-text').val()
        //            }),
        //            contentType: 'application/json; charset=utf-8',
        //            success: function (data) {
        //                setTimeout(function () {
        //                    window.location.href = `EditRole/${data.id}`;
        //                }, 2000);
        //                $('#role-content .alert-success').show();
        //                $('#role-content .alert-danger').hide();
        //            },
        //            error: function (err) {
        //                console.log('There was a problem updating the role. Please try again later.');
        //            },
        //            async: true
        //        });
        //    } else {
        //        $('#role-content .alert-danger').show();
        //    }
        //},
        //form.update = function (id) {
        //    if (form.validateForm()) {
        //        $.ajax({
        //            type: 'PUT',
        //            url: `${baseUrl}/roles/${id}`,
        //            data: JSON.stringify({
        //                id: id,
        //                roleName: $('#role-content .role-name-text').val(),
        //                description: $('#role-content .description-text').val()
        //            }),
        //            contentType: 'application/json; charset=utf-8',
        //            success: function () {
        //                $('#role-content .alert-success').show();
        //                $('#role-content .alert-danger').hide();
        //            },
        //            error: function (err) {
        //                console.log('There was a problem updating the role. Please try again later.');
        //            },
        //            async: true
        //        });
        //    } else {
        //        $('#role-content .alert-danger').show();
        //    }
        //},
        //form.delete = function (id) {
        //    $.ajax({
        //        type: 'DELETE',
        //        url: `${baseUrl}/roles/${id}`,
        //        success: function (isUsed) {
        //            if (isUsed) {
        //                $('#role-list .alert-danger').show();
        //                return;
        //            }
        //            form.getRoles($('#search-role-text').val(), 1);
        //            $('#role-list .alert-success').show();
        //            $('#role-list .alert-danger').hide();
        //        },
        //        error: function (err) {
        //            console.log('There was a problem deleting the role. Please try again later.');
        //        },
        //        async: true
        //    });
        //}
}

var hearingList = new HearingList();
hearingList._constructor();