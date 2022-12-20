var PreFilingApproval = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        var url = window.location.href;

        form.getPreFilingRequests($('#search-prefiling-request-text').val(), 1);

        //form._events();

        //if (url.split('/')[4] !== "Roles") {
        //    var id = url.substring(url.lastIndexOf('/') + 1);
        //    if (!isNaN(id)) {
        //        form.getRole(id);
        //    }
        //} else {
            
        //}

        //$('#role-list .alert-success').hide();
        //$('#role-list .alert-danger').hide();
        //$('#role-content .alert-success').hide();
        //$('#role-content .alert-danger').hide();
    },
    form._events = function () {
        var url = window.location.href;

        $(document).on("click", "#search-role-button", function (e) {
            form.getRoles($('#search-role-text').val(), 1);
        });

        $(document).keypress(function (e) {
            if (e.which == 13) {
                e.preventDefault();

                if (e.target.id === 'search-role-text') {
                    form.getRoles($('#search-role-text').val(), 1);
                }
            }
        });

        $(document).on("click", "#role-list tbody tr td .remove-button", function (e) {
            e.preventDefault();
            var id = parseInt($(this).attr('data-id'));
            if (confirm('Are you sure, you want to delete this role?')) {
                form.delete(id);
                return;
            }
        });

        $('#role-content .save-changes').click(function (e) {
            e.preventDefault();
            var id = url.substring(url.lastIndexOf('/') + 1);
            if (!isNaN(id)) {
                form.update(id);
                return;
            }
            form.save();
        });

        $('#role-content .close').click(function (e) {
            if ($(this).attr('data-type') === 'success')
                $('#role-content .alert-success').hide();
            else
                $('#role-content .alert-danger').hide();
        });

        $('#role-list .close').click(function (e) {
            if ($(this).attr('data-type') === 'success')
                $('#role-list .alert-success').hide();
            else
                $('#role-list .alert-danger').hide();
        });
    },
    form.getRole = function (id) {
        $.get(`${baseUrl}/roles/${id}`)
            .done(function (data) {
                $('#role-header .name').text(data.roleName);
                $('#role-content .role-name-text').val(data.roleName);
                $('#role-content .description-text').val(data.description);
            }).fail(function (error) {
                console.log('There was a problem fetching the role. Please try again later.');
            });
    },
    form.getPreFilingRequests = function (searchValue, currentPage, userId) {
        var endpoint = `${baseUrl}/prefilingrequest/lists?searchValue=${searchValue}&currentPage=${currentPage}`;
        if (typeof userId !== "undefined")
            endpoint = `${baseUrl}/prefilingrequest/lists?searchValue=${searchValue}&currentPage=${currentPage}&userId=userId`;

        $.get(endpoint)
            .done(function (data) {
                var htmlContent = '';

                for (var i = 0; i < data.items.length; i++) {
                    var status = '<span class="label label-warning">Rejected</span>';
                    if (data.items[i].preFilingStatus === 'Approved')
                        status = '<span class="label label-primary">APPROVED</span>';
                    else if (data.items[i].preFilingStatus === 'Pending')
                        status = '<span class="label label-warning">PENDING</span>';
                    else
                        status = '<span class="label label-danger">REJECTED</span>';

                    htmlContent += '<tr>';
                        htmlContent += `<td>${data.items[i].id}</td>`;
                        htmlContent += `<td>${data.items[i].requestSubject}</td>`;
                        htmlContent += `<td>${data.items[i].fullName}</td>`;
                        htmlContent += `<td>${data.items[i].caseType}</td>`;
                        htmlContent += `<td>${data.items[i].caseNature}</td>`;
                        htmlContent += `<td>${status}</td>`;
                        htmlContent += `<td>${new Date(data.items[i].dateFiled).toLocaleDateString()} 
                            ${new Date(data.items[i].dateFiled).toLocaleTimeString()}</td>`;
                        htmlContent += '<td class="text-center">';
                            htmlContent += `<button id="edit-${data.items[i].id}" data-id="${data.items[i].id}" onclick="location.href='EditRole/${data.items[i].id}'" type="button" class="btn btn-md btn-info"><i class="fa fa-eye"></i> Review</button>`;
                        htmlContent += '</td>';
                    htmlContent += '</tr>';
                }

                $('#prefiling-list .count').text(data.pagination.totalItems);
                $('#prefiling-list .table-data').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the roles. Please try again later.');
            });
    },
    form.validateForm = function () {
        if ($('#role-content .role-name-text').val().length === 0) {
            return false;
        }
        if ($('#role-content .description-text').val().length === 0) {
            return false;
        }
        return true;
    },
    form.save = function () {
        if (form.validateForm()) {
            $.ajax({
                type: 'POST',
                url: `${baseUrl}/roles`,
                data: JSON.stringify({
                    roleName: $('#role-content .role-name-text').val(),
                    description: $('#role-content .description-text').val()
                }),
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    setTimeout(function () {
                        window.location.href = `EditRole/${data.id}`;
                    }, 2000);
                    $('#role-content .alert-success').show();
                    $('#role-content .alert-danger').hide();
                },
                error: function (err) {
                    console.log('There was a problem updating the role. Please try again later.');
                },
                async: true
            });
        } else {
            $('#role-content .alert-danger').show();
        }
    },
    form.update = function (id) {
        if (form.validateForm()) {
            $.ajax({
                type: 'PUT',
                url: `${baseUrl}/roles/${id}`,
                data: JSON.stringify({
                    id: id,
                    roleName: $('#role-content .role-name-text').val(),
                    description: $('#role-content .description-text').val()
                }),
                contentType: 'application/json; charset=utf-8',
                success: function () {
                    $('#role-content .alert-success').show();
                    $('#role-content .alert-danger').hide();
                },
                error: function (err) {
                    console.log('There was a problem updating the role. Please try again later.');
                },
                async: true
            });
        } else {
            $('#role-content .alert-danger').show();
        }
    },
    form.delete = function (id) {
        $.ajax({
            type: 'DELETE',
            url: `${baseUrl}/roles/${id}`,
            success: function (isUsed) {
                if (isUsed) {
                    $('#role-list .alert-danger').show();
                    return;
                }
                form.getRoles($('#search-role-text').val(), 1);
                $('#role-list .alert-success').show();
                $('#role-list .alert-danger').hide();
            },
            error: function (err) {
                console.log('There was a problem deleting the role. Please try again later.');
            },
            async: true
        });
    }
}

var preFilingApproval = new PreFilingApproval();
preFilingApproval._constructor();