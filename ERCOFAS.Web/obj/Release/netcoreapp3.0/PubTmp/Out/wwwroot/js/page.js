var Page = function () {
    var form = this;
    var baseUrl = 'http://localhost:55653/api';

    form._constructor = function () {
        var url = window.location.href;

        form._events();

        if (url.split('/')[4] !== "Pages") {
            var id = url.substring(url.lastIndexOf('/') + 1);

            if (!isNaN(id)) {
                localStorage.removeItem('manageRoles');

                form.getPage(id);
                form.getManageRoles(id, $('#search-role-text').val());
            }
        } else {
            form.getPages($('#search-page-text').val(), 1);
        }

        $('#page-content .alert-success-page').hide();
        $('#page-content .alert-danger-page').hide();
        $('#page-content .alert-manage-roles').hide();
    },
    form._events = function () {
        var url = window.location.href;

        $('#page-content .save-changes').click(function (e) {
            e.preventDefault();
            var id = url.substring(url.lastIndexOf('/') + 1);

            form.updatePage(id);
        });

        $('#add-role-button').click(function (e) {
            e.preventDefault();
            var arrAddedRoles = [];

            $('#page-content .table tr').each(function () {
                if ($(this).find(".role-id").html() !== undefined) {
                    arrAddedRoles.push(parseInt($(this).find(".role-id").html()));
                }
            });

            form.getRoles(arrAddedRoles, $('#page-role-modal .search-role-text').val(), 1);

            $('#page-role-modal').modal('toggle');
        });

        $(document).on("click", "#page-role-modal tbody tr td .add-btn", function (e) {
            e.preventDefault();
            var pageId = parseInt(url.substring(url.lastIndexOf('/') + 1));
            var arrManageRoles = JSON.parse(localStorage.getItem('manageRoles'));

            if (arrManageRoles.find(x => x.roleId === parseInt($(this).attr('data-id'))) === undefined) {
                arrManageRoles.push({
                    id: parseInt($(this).attr('data-id')),
                    roleId: parseInt($(this).attr('data-id')),
                    roleName: $(this).attr('data-name'),
                    canCreate: false,
                    canRead: false,
                    canUpdate: false,
                    canDelete: false
                });
            }
            localStorage.setItem('manageRoles', JSON.stringify(arrManageRoles));
            form.getManageRoles(pageId, $('#search-role-text').val());
            $('#page-role-modal').modal('toggle');
        });

        $('#page-content .save-manage-roles').click(function (e) {
            e.preventDefault();
            var arrManageRoles = [];

            $('#page-content .table-data tr').each(function () {
                if ($(this).find(".role-id").html() !== undefined) {
                    arrManageRoles.push({
                        id: parseInt($(this).find(".manage-role-id").html()),
                        pageId: parseInt(url.substring(url.lastIndexOf('/') + 1)),
                        roleId: parseInt($(this).find(".role-id").html()),
                        roleName: $(this).find(".role-name").html(),
                        canCreate: $(`#${$(this).find('.can-create input')[0].id}`).prop('checked'),
                        canRead: $(`#${$(this).find('.can-read input')[0].id}`).prop('checked'),
                        canUpdate: $(`#${$(this).find('.can-update input')[0].id}`).prop('checked'),
                        canDelete: $(`#${$(this).find('.can-delete input')[0].id}`).prop('checked')
                    });
                }
            });
            form.saveManageRoles(arrManageRoles);
        });

        $(document).on("click", "#page-content tbody tr td .remove-btn", function (e) {
            e.preventDefault();
            var arrManageRoles = JSON.parse(localStorage.getItem('manageRoles'));
            var pageId = parseInt(url.substring(url.lastIndexOf('/') + 1));
            var roleId = parseInt($(this).attr('data-id'));

            arrManageRoles.splice(arrManageRoles.findIndex(function (i) {
                return i.roleId === roleId;
            }), 1);

            localStorage.setItem('manageRoles', JSON.stringify(arrManageRoles));
            form.getManageRoles(pageId, $('#search-role-text').val());
        });

        $('#page-content .close').click(function (e) {
            if ($(this).attr('data-type') === 'page-success')
                $('#page-content .alert-success-page').hide();
            else if ($(this).attr('data-type') === 'page-danger')
                $('#page-content .alert-danger-page').hide();
            else 
                $('#page-content .alert-manage-roles').hide();
        });
    },
    form.getPage = function (id) {
        $.get(`${baseUrl}/pages/${id}`)
            .done(function (data) {
                $('#page-header .name').text(data.pageName);
                $('#page-content .page-name-text').val(data.pageName);
                $('#page-content .description-text').val(data.description);
                $('#page-content .url-path-text').val(data.urlPath);
                $('#page-content .accessible-all-check').prop('checked', data.accessibleByAll);
                $('#page-content .status-check').prop('checked', data.isActive);
            }).fail(function (error) {
                console.log('There was a problem fetching the page. Please try again later.');
            });
    },
    form.getPages = function (searchValue, currentPage) {
        $.get(`${baseUrl}/pages/lists?searchValue=${searchValue}&currentPage=${currentPage}`)
            .done(function (data) {
                var htmlContent = '';

                for (var i = 0; i < data.items.length; i++) {
                    var status = '<span class="label label-danger">INACTIVE</span>';
                    if (data.items[i].status == true)
                        status = '<span class="label label-primary">ACTIVE</span>';

                    htmlContent += '<tr>';
                        htmlContent += `<td>${data.items[i].id}</td>`;
                        htmlContent += `<td>${data.items[i].pageName}</td>`;
                        htmlContent += `<td>${data.items[i].description}</td>`;
                        htmlContent += `<td>${data.items[i].urlPath}</td>`;
                        htmlContent += `<td class="text-center">${status}</td>`;
                        htmlContent += `<td>${new Date(data.items[i].dateCreated).toLocaleDateString()} 
                            ${new Date(data.items[i].dateCreated).toLocaleTimeString()}</td>`;
                        htmlContent += '<td class="text-center">';
                            htmlContent += `<button id="view-${data.items[i].id}" data-id="${data.items[i].id}" onclick="location.href='EditPage/${data.items[i].id}'" type="button" class="btn btn-md btn-info"><i class="fa fa-eye"></i> View</button>`;
                        htmlContent += '</td>';
                    htmlContent += '</tr>';
                }

                $('#page-list .count').text(data.pagination.totalItems);
                $('#page-list .table-data').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the pages. Please try again later.');
            });
    },
    form.getManageRoles = function (pageId, searchValue) {
        $.get(`${baseUrl}/pages/manage-roles?pageId=${pageId}&searchValue=${searchValue}`)
            .done(function (data) {
                var htmlContent = '';

                if (localStorage.getItem("manageRoles") === null) {
                    var arrManageRoles = [];

                    for (var i = 0; i < data.length; i++) {
                        arrManageRoles.push({
                            id: data[i].id,
                            roleId: data[i].roleId,
                            roleName: data[i].roleName,
                            canCreate: data[i].canCreate,
                            canRead: data[i].canRead,
                            canUpdate: data[i].canUpdate,
                            canDelete: data[i].canDelete
                        });
                    }
                    localStorage.setItem('manageRoles', JSON.stringify(arrManageRoles));
                }

                var arrManageRoles = JSON.parse(localStorage.getItem('manageRoles'));

                for (var i = 0; i < arrManageRoles.length; i++) {
                    var canCreate = arrManageRoles[i].canCreate === true ? 'checked' : '';
                    var canRead = arrManageRoles[i].canRead === true ? 'checked' : '';
                    var canUpdate = arrManageRoles[i].canUpdate === true ? 'checked' : '';
                    var canDelete = arrManageRoles[i].canDelete === true ? 'checked' : '';

                    htmlContent += '<tr>';
                        htmlContent += '<td class="manage-role-id" style="display: none;">' + arrManageRoles[i].id + '</td>';
                        htmlContent += `<td class="role-id" style="display: none;">${arrManageRoles[i].roleId}</td>`;
                        htmlContent += `<td class="role-name">${arrManageRoles[i].roleName}</td>`;
                        htmlContent += '<td class="can-create text-center"><input type="checkbox" id="can-create-check-' + arrManageRoles[i].roleName.replace(' ', '').toLowerCase() + '"' + canCreate + '></td>';
                        htmlContent += '<td class="can-read text-center"><input type="checkbox" id="can-read-check-' + arrManageRoles[i].roleName.replace(' ', '').toLowerCase() + '"' + canRead + '></td>';
                        htmlContent += '<td class="can-update text-center"><input type="checkbox" id="can-update-check-' + arrManageRoles[i].roleName.replace(' ', '').toLowerCase() + '"' + canUpdate + '></td>';
                        htmlContent += '<td class="can-delete text-center"><input type="checkbox" id="can-delete-check-' + arrManageRoles[i].roleName.replace(' ', '').toLowerCase() + '"' + canDelete + '></td>';
                        htmlContent += '<td class="text-center">';
                            htmlContent += `<button data-id="${arrManageRoles[i].roleId}" type="button" class="btn btn-md btn-danger remove-btn"><i class="fa fa-times"></i> Remove</button>`;
                        htmlContent += '</td>';
                    htmlContent += '</tr>';
                }

                $('#page-content .tab-count').text(data.length);
                $('#page-content .table-data').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the manage roles. Please try again later.');
            });
    },
    form.getRoles = function (addedRoles, searchValue, currentPage) {
        $.get(`${baseUrl}/roles/lists?searchValue=${searchValue}&currentPage=${currentPage}`)
            .done(function (data) {
                var htmlContent = '';

                for (var i = 0; i < data.items.length; i++) {
                    htmlContent += '<tr>';
                        htmlContent += `<td>${data.items[i].roleName}</td>`;
                        htmlContent += '<td class="text-center">';
                        if (!addedRoles.includes(data.items[i].id))
                            htmlContent += '<button data-id=\"' + data.items[i].id + '\" data-name=\"' + data.items[i].roleName + '\" type="button" class="add-btn btn btn-info btn-sm select-city-btn"><i class="fa fa-plus-circle"></i> Add</button>';
                        else
                            htmlContent += '<span class="badge badge-secondary"><i>Added</i></span>';
                        htmlContent += '</td>';
                    htmlContent += '</tr>';
                }

                $('#page-role-modal .count').text(data.pagination.totalItems);
                $('#page-role-modal .table-data').html(htmlContent);
            }).fail(function (error) {
                console.log('There was a problem fetching the roles. Please try again later.');
            });
    },
    form.validateForm = function () {
        if ($('#page-content .page-name-text').val().length === 0) {
            return false;
        }
        if ($('#page-content .description-text').val().length === 0) {
            return false;
        }
        if ($('#page-content .url-path-text').val().length === 0) {
            return false;
        }
        return true;
    },
    form.updatePage = function (id) {
        if (form.validateForm()) {
            $.ajax({
                type: 'PUT',
                url: `${baseUrl}/pages/${id}`,
                data: JSON.stringify({
                    id: id,
                    pageName: $('#page-content .page-name-text').val(),
                    description: $('#page-content .description-text').val(),
                    urlPath: $('#page-content .url-path-text').val(),
                    accessibleByAll: $('#page-content .accessible-all-check').prop('checked'),
                    isActive: $('#page-content .status-check').prop('checked')
                }),
                contentType: 'application/json; charset=utf-8',
                success: function () {
                    $('#page-content .alert-success-page').show();
                    $('#page-content .alert-danger-page').hide();
                },
                error: function (err) {
                    console.log('There was a problem updating the page. Please try again later.');
                },
                async: true
            });
        } else {
            $('#page-content .alert-danger').show();
        }
    }
    form.saveManageRoles = function (manageRoles) {
        $.ajax({
            type: 'POST',
            url: `${baseUrl}/pages/save-manage-roles`,
            data: JSON.stringify(manageRoles),
            contentType: 'application/json; charset=utf-8',
            success: function () {
                $('#page-content .alert-manage-roles').show();
            },
            error: function (err) {
                console.log('There was a problem saving the manage roles. Please try again later.');
            },
            async: true
        });
    }
}

var page = new Page();
page._constructor();