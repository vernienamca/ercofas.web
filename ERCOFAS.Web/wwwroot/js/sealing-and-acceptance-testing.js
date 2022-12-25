var SealingAndAcceptanceTesting = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        var url = window.location.href;

        form._events();

        if (url.split('/')[4] !== "SealingAndAcceptanceTesting") {
            var id = url.substring(url.lastIndexOf('/') + 1);
            if (!isNaN(id)) {
                form.getSealingAndAcceptanceTesting(id);
            }
        } else {
            form.getSealingAndAcceptanceTestings($('#search-sealing-and-acceptance-testing-text').val(), 1);
        }

        $('#sealing-and-acceptance-testing-list .alert-success').hide();
        $('#sealing-and-acceptance-testing-list .alert-danger').hide();
        $('#sealing-and-acceptance-testing-content .alert-success').hide();
        $('#sealing-and-acceptance-testing-content .alert-danger').hide();
    },
        form._events = function () {
            var url = window.location.href;

            $(document).on("click", "#search-sealing-and-acceptance-testing-button", function (e) {
                form.getSealingAndAcceptanceTestings($('#search-sealing-and-acceptance-testing-text').val(), 1);
            });

            $(document).keypress(function (e) {
                if (e.which == 13) {
                    e.preventDefault();

                    if (e.target.id === 'search-sealing-and-acceptance-testing-text') {
                        form.getSealingAndAcceptanceTestings($('#search-sealing-and-acceptance-testing-text').val(), 1);
                    }
                }
            });

            $(document).on("click", "#sealing-and-acceptance-testing-list tbody tr td .remove-button", function (e) {
                e.preventDefault();
                var id = parseInt($(this).attr('data-id'));
                if (confirm('Are you sure, you want to delete this sealing?')) {
                    form.delete(id);
                    return;
                }
            });

            $('#sealing-and-acceptance-testing-content .save-changes').click(function (e) {
                e.preventDefault();
                var id = url.substring(url.lastIndexOf('/') + 1);
                if (!isNaN(id)) {
                    form.update(id);
                    return;
                }
                form.save();
            });

            $('#sealing-and-acceptance-testing-content .close').click(function (e) {
                if ($(this).attr('data-type') === 'success')
                    $('#sealing-and-acceptance-testing-content .alert-success').hide();
                else
                    $('#sealing-and-acceptance-testing-content .alert-danger').hide();
            });

            $('#sealing-and-acceptance-testing-list .close').click(function (e) {
                if ($(this).attr('data-type') === 'success')
                    $('#sealing-and-acceptance-testing-list .alert-success').hide();
                else
                    $('#sealing-and-acceptance-testing-list .alert-danger').hide();
            });
        },
        form.getSealingAndAcceptanceTesting = function (id) {
            $.get(`${baseUrl}/sealing-and-acceptance-testing/${id}`)
                .done(function (data) {
                    $('#sealing-and-acceptance-testing-header .name').text(data.documents);
                    $('#sealing-and-acceptance-testing-content .sealing-and-acceptance-testing-name-text').val(data.documents);
                }).fail(function (error) {
                    console.log('There was a problem fetching the sealing. Please try again later.');
                });
        },
        form.getSealingAndAcceptanceTestings = function (searchValue, currentPage) {
            $.get(`${baseUrl}/sealing-and-acceptance-testing/lists?searchValue=${searchValue}&currentPage=${currentPage}`)
                .done(function (data) {
                    var htmlContent = '';

                    for (var i = 0; i < data.items.length; i++) {
                        htmlContent += '<tr>';
                        htmlContent += `<td>${data.items[i].id}</td>`;
                        htmlContent += `<td>${data.items[i].document}</td>`;
                        htmlContent += `<td>${data.items[i].document}</td>`;
                        htmlContent += `<td>Test</td>`;
                        htmlContent += `<td>${new Date(data.items[i].dateCreated).toLocaleDateString()} 
                            ${new Date(data.items[i].dateCreated).toLocaleTimeString()}</td>`;
                        htmlContent += '<td class="text-center">';
                        htmlContent += `<button id="edit-${data.items[i].id}" data-id="${data.items[i].id}" onclick="location.href='EditSealingAndAcceptanceTesting/${data.items[i].id}'" type="button" class="btn btn-md btn-info"><i class="fa fa-pencil"></i> Edit</button> `;
                        htmlContent += `<button id="delete-${data.items[i].id}" data-id="${data.items[i].id}" type="button" class="btn btn-md btn-danger remove-button"><i class="fa fa-times"></i> Delete</button>`;
                        htmlContent += '</td>';
                        htmlContent += '</tr>';
                    }

                    $('#sealing-and-acceptance-testing-list .count').text(data.pagination.totalItems);
                    $('#sealing-and-acceptance-testing-list .table-data').html(htmlContent);
                }).fail(function (error) {
                    console.log('There was a problem fetching the sealing. Please try again later.');
                });
        },
        form.validateForm = function () {
            if ($('#sealing-and-acceptance-testing-content .sealing-and-acceptance-testing-name-text').val().length === 0) {
                return false;
            }
            if ($('#sealing-and-acceptance-testing-content .description-text').val().length === 0) {
                return false;
            }
            return true;
        },
        form.save = function () {
            if (form.validateForm()) {
                $.ajax({
                    type: 'POST',
                    url: `${baseUrl}/sealing-and-acceptance-testings`,
                    data: JSON.stringify({
                        document: $('#sealing-and-acceptance-testing-content .sealing-and-acceptance-testing-name-text').val(),
                    }),
                    contentType: 'application/json; charset=utf-8',
                    success: function (data) {
                        setTimeout(function () {
                            window.location.href = `EditSealingAndAcceptanceTesting/${data.id}`;
                        }, 2000);
                        $('#sealing-and-acceptance-testing-content .alert-success').show();
                        $('#sealing-and-acceptance-testing-content .alert-danger').hide();
                    },
                    error: function (err) {
                        console.log('There was a problem updating the sealing. Please try again later.');
                    },
                    async: true
                });
            } else {
                $('#sealing-and-acceptance-testing-content .alert-danger').show();
            }
        },
        form.update = function (id) {
            if (form.validateForm()) {
                $.ajax({
                    type: 'PUT',
                    url: `${baseUrl}/sealing-and-acceptance-testing/${id}`,
                    data: JSON.stringify({
                        id: id,
                        documents: $('#sealing-and-acceptance-testing-content .sealing-and-acceptance-testing-name-text').val(),
                    }),
                    contentType: 'application/json; charset=utf-8',
                    success: function () {
                        $('#sealing-and-acceptance-testing-content .alert-success').show();
                        $('#sealing-and-acceptance-testing-content .alert-danger').hide();
                    },
                    error: function (err) {
                        console.log('There was a problem updating the sealing. Please try again later.');
                    },
                    async: true
                });
            } else {
                $('#sealing-and-acceptance-testing-content .alert-danger').show();
            }
        },
        form.delete = function (id) {
            $.ajax({
                type: 'DELETE',
                url: `${baseUrl}/sealing-and-acceptance-testing/${id}`,
                success: function (isUsed) {
                    if (isUsed) {
                        $('#sealing-and-acceptance-testing-list .alert-danger').show();
                        return;
                    }
                    form.getSealingAndAcceptanceTestings($('#search-sealing-and-acceptance-testing-text').val(), 1);
                    $('#sealing-and-acceptance-testing-list .alert-success').show();
                    $('#sealing-and-acceptance-testing-list .alert-danger').hide();
                },
                error: function (err) {
                    console.log('There was a problem deleting the sealing. Please try again later.');
                },
                async: true
            });
        }
}

var sealingAndAcceptanceTesting = new SealingAndAcceptanceTesting();
sealingAndAcceptanceTesting._constructor();