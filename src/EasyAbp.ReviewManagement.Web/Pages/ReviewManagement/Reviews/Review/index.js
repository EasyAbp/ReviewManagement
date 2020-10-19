$(function () {

    var l = abp.localization.getResource('EasyAbpReviewManagement');

    var service = easyAbp.reviewManagement.reviews.review;
    var createModal = new abp.ModalManager(abp.appPath + 'ReviewManagement/Reviews/Review/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'ReviewManagement/Reviews/Review/EditModal');

    var dataTable = $('#ReviewTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('EasyAbp.ReviewManagement.Review.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('EasyAbp.ReviewManagement.Review.Delete'),
                                confirmMessage: function (data) {
                                    return l('ReviewDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                        service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "entityType" },
            { data: "entityId" },
            { data: "startCount" },
            { data: "isPublic" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewReviewButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});