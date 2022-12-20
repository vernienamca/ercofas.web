var PreFiling = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        var url = window.location.href;

        form._events();

        if (url.split('/')[4] !== "CasePleadings") {
            var id = url.substring(url.lastIndexOf('/') + 1);

            form.getCaseTypes();

            if (!isNaN(id)) {
                form.getFiledCase(id);
                form.getDocuments();
            }
        } else {
            form.getFiledCases($('#search-filed-cases-text').val(), 1, 1);
        }

        $('#pleading-content .alert-success').hide();
        $('#pleading-content .alert-danger').hide();
        $('#pleading-content .alert-upload-document-text').hide();
    },
    form.getFiledCase = function (id) {
        $.get(`${baseUrl}/prefilingrequest/${id}`)
            .done(function (data) {
                if (data.preFilingStatusId == 1) {
                    $("#pleading-content .tab-content input, select, textarea").attr("disabled", true);
                    $("#pleading-content .save-changes").hide();
                    $('#pleading-header .breadcrumb-text').text('View Filed Case/Pleading');
                }

                form.getCaseNatures(data.caseTypeId, data.caseNatureId);
                $('#pleading-header .name').text(data.requestSubject);
                $('#pleading-content .subject-request-text').val(data.requestSubject);
                $("#pleading-content .case-type-select").val(data.caseTypeId);
                $('#pleading-content .remarks-text').val(data.remarks);
            }).fail(function (error) {
                console.log('There was a problem fetching the filed case. Please try again later.');
            });
    },
    form._events = function () {
        var url = window.location.href;

        $(document).on("change", "#pleading-content .case-type-select", function (e) {
            var id = parseInt($(this).find('option:selected').attr('id'));
            form.getCaseNatures(id);
        });

        $(document).on("click", "#pleading-list tbody tr td .remove-button", function (e) {
            e.preventDefault();

            var id = parseInt($(this).attr('data-id'));
            if (confirm('Are you sure, you want to delete this filed case/pleading?')) {
                form.delete(id);
                return;
            }
        });

        $('#pleading-content .save-changes').click(function (e) {
            var url = window.location.href;
            var id = url.substring(url.lastIndexOf('/') + 1);

            if (!isNaN(id))
                form.update(id);
            else
                form.save();
        });

        $('#pleading-content .upload-documents').click(function (e) {
            $("#pleading-content .table-data tr").each(function () {
                var fileName = $(this).find('input').val().replace(/C:\\fakepath\\/i, '').replace(/\.[^/.]+$/, "");

                if ($(this).find('.is-required').text() === 'YES') {
                    if (fileName.length == 0) {
                        $('#pleading-content .upload-document-text').html(`Please upload a <strong>${$(this).find('.name').text()}</strong> document file.`);
                        $('#pleading-content .alert-upload-document').show();
                        return;
                    } 
                }

                if (fileName.length > 0) {
                    if (fileName != $(this).find('.name').text()) {
                        $('#pleading-content .upload-document-text').html(`Uploaded file must be the same on document name.`);
                        $('#pleading-content .alert-upload-document').show();
                        return;
                    }
                }
            });
        });

        $('#pleading-content .close').click(function (e) {
            if ($(this).attr('data-type') === 'success')
                $('#pleading-content .alert-success').hide();
            else
                $('#pleading-content .alert-danger').hide();
        });
    },
    form.getFiledCases = function (searchValue, currentPage, userId) {
        var endpoint = `${baseUrl}/prefilingrequest/lists?searchValue=${searchValue}&currentPage=${currentPage}`;
        if (typeof userId !== "undefined")
            endpoint = `${baseUrl}/prefilingrequest/lists?searchValue=${searchValue}&currentPage=${currentPage}&userId=${userId}`;

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
                        htmlContent += `<td>${data.items[i].requestSubject}</td>`;;
                        htmlContent += `<td>${data.items[i].caseType}</td>`;
                        htmlContent += `<td>${data.items[i].caseNature}</td>`;
                        htmlContent += `<td>${status}</td>`;
                        htmlContent += `<td>${new Date(data.items[i].dateFiled).toLocaleDateString()} 
                            ${new Date(data.items[i].dateFiled).toLocaleTimeString()}</td>`;
                        htmlContent += '<td class="text-center">';
                            if (data.items[i].preFilingStatus !== 'Approved') {
                                htmlContent += `<button id="edit-${data.items[i].id}" data-id="${data.items[i].id}" onclick="location.href='EditCasePleading/${data.items[i].id}'" type="button" class="btn btn-md btn-info"><i class="fa fa-pencil"></i> Edit</button> `;
                                htmlContent += `<button id="delete-${data.items[i].id}" data-id="${data.items[i].id}" type="button" class="btn btn-md btn-danger remove-button"><i class="fa fa-times"></i> Delete</button>`;
                            } else {
                                htmlContent += `<button id="view-${data.items[i].id}" data-id="${data.items[i].id}" onclick="location.href='EditCasePleading/${data.items[i].id}'" type="button" class="btn btn-md btn-info btn-block"><i class="fa fa-eye"></i> View Details</button>`;
                            }
                        htmlContent += '</td>';
                    htmlContent += '</tr>';
                }

                $('#pleading-list .count').text(data.pagination.totalItems);
                $('#pleading-list .table-data').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the filed case/pleadings. Please try again later.');
            });
    },
    form.getCaseTypes = function (id) {
        $.get(`${baseUrl}/prefilingrequest/case-types`)
            .done(function (data) {
                var htmlContent = '';

                form.getCaseNatures(data[0].id);

                for (var i = 0; i < data.length; i++) {
                    htmlContent += `<option id="${data[i].id}" value="${data[i].id}">${data[i].description}</option>`; 
                }
                $('#pleading-content .case-type-select').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the case types. Please try again later.');
            });
    },
    form.getCaseNatures = function (caseTypeId, caseNatureId) {
        $.get(`${baseUrl}/prefilingrequest/case-natures?caseTypeId=${caseTypeId}`)
            .done(function (data) {
                var htmlContent = '';

                for (var i = 0; i < data.length; i++) {
                    if (typeof caseNatureId !== "undefined") {
                        if (data[i].id == caseNatureId)
                            htmlContent += `<option value="${data[i].id}" selected>${data[i].description}</option>`;
                        else
                            htmlContent += `<option value="${data[i].id}">${data[i].description}</option>`;
                    } else {
                        htmlContent += `<option value="${data[i].id}">${data[i].description}</option>`;
                    }
                }
                $('#pleading-content .case-nature-select').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the case natures. Please try again later.');
            });
    },
    form.getDocuments = function () {
        $.get(`${baseUrl}/prefilingrequest/documents`)
            .done(function (data) {
                var htmlContent = '';

                for (var i = 0; i < data.length; i++) {
                    htmlContent += '<tr>';
                        htmlContent += `<td class="name">${data[i].name}</td>`;
                        htmlContent += `<td class="text-center is-required">${data[i].isRequired ? 'YES' : 'NO'}</td>`;
                        htmlContent += '<td>';
                            htmlContent += `<input type="file" id="file" name="file">`;
                        htmlContent += '</td>';
                    htmlContent += '</tr>';
                }

                $('#pleading-content .document-count').text(data.length);
                $('#pleading-content .table-data').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the documents. Please try again later.');
            });
    },
    form.validateForm = function () {
        if ($('#pleading-content .subject-request-text').val().length === 0) {
            return false;
        }
        if ($('#pleading-content .full-name-text').val().length === 0) {
            return false;
        }
        return true;
    },
    form.validateTermsPolicies = function () {
        if ($('#pleading-content .authorized-check').is(':checked') === false && $('#pleading-content .complete-check').is(':checked') === false &&
            $('#pleading-content .policies-check').is(':checked') === false) {
            return false;
        }
        return true;
    },
    form.save = function () {
        if (form.validateForm()) {
            if (form.validateTermsPolicies()) {
                $.ajax({
                    type: 'POST',
                    url: `${baseUrl}/prefilingrequest`,
                    data: JSON.stringify({
                        requestSubject: $('#pleading-content .subject-request-text').val(),
                        userId: 1,
                        caseTypeId: parseInt($("#pleading-content .case-type-select :selected").val()),
                        caseNatureId: parseInt($("#pleading-content .case-nature-select :selected").val()),
                        remarks: $('#pleading-content .remarks-text').val()
                    }),
                    contentType: 'application/json; charset=utf-8',
                    success: function (data) {
                        setTimeout(function () {
                            window.location.href = `EditCasePleading/${data.id}`;
                        }, 2000);
                        window.scrollTo({ top: 0, behavior: 'smooth' });
                        $('#pleading-content .success-text').text('Your have been successfully filed a case/pleading.');
                        $('#pleading-content .alert-success').show();
                        $('#pleading-content .alert-danger').hide();
                    },
                    error: function (err) {
                        console.log('There was a problem filing a case/pleading. Please try again later.');
                    },
                    async: true
                });
            } else {
                $('#pleading-content .danger-text').text('Please agree on terms and policies below to proceed.');
                $('#pleading-content .alert-danger').show();
                window.scrollTo({ top: 0, behavior: 'smooth' });
            }
        } else {
            $('#pleading-content .danger-text').text('Please fill out required fields below to proceed.');
            $('#pleading-content .alert-danger').show();
            window.scrollTo({ top: 0, behavior: 'smooth' });
        }
    },
    form.update = function (id) {
        if (form.validateForm()) {
            if (form.validateTermsPolicies()) {
                $.ajax({
                    type: 'PUT',
                    url: `${baseUrl}/prefilingrequest/${id}`,
                    data: JSON.stringify({
                        id: id,
                        requestSubject: $('#pleading-content .subject-request-text').val(),
                        userId: 1,
                        caseTypeId: parseInt($("#pleading-content .case-type-select :selected").val()),
                        caseNatureId: parseInt($("#pleading-content .case-nature-select :selected").val()),
                        remarks: $('#pleading-content .remarks-text').val()
                    }),
                    contentType: 'application/json; charset=utf-8',
                    success: function () {
                        $('#pleading-content .success-text').text('Filed a case/pleading has been successfully updated.');
                        $('#pleading-content .alert-success').show();
                        $('#pleading-content .alert-danger').hide();
                    },
                    error: function (err) {
                        console.log('There was a problem updating the case/pleading. Please try again later.');
                    },
                    async: true
                });
            } else {
                $('#pleading-content .danger-text').text('Please agree on terms and policies below to proceed.');
                $('#pleading-content .alert-danger').show();
                window.scrollTo({ top: 0, behavior: 'smooth' });
            }
        } else {
            $('#pleading-content .danger-text').text('Please fill out required fields below to proceed.');
            $('#pleading-content .alert-danger').show();
            window.scrollTo({ top: 0, behavior: 'smooth' });
        }
    },
    form.delete = function (id) {
        $.ajax({
            type: 'DELETE',
            url: `${baseUrl}/prefilingrequest/${id}`,
            success: function () {
                form.getFiledCases($('#search-filed-cases-text').val(), 1, 1);
            },
            error: function (err) {
                console.log('There was a problem deleting the filed case/pleading. Please try again later.');
            },
            async: true
        });
    }
}

var preFiling = new PreFiling();
preFiling._constructor();