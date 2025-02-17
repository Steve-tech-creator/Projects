﻿$(function () {
    var l = abp.localization.getResource('ProductStore');
    var createModal = new abp.ModalManager(abp.appPath + 'Products/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Products/EditModal');

    var dataTable = $('#ProductsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(productStore.products.product.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('ProductStore.Products.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('ProductStore.Products.Delete'),
                                    confirmMessage: function (data) {
                                        return l('ProductDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        productStore.products.product
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }

                            ]
                    }
                },
               

                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Description'),
                    data: "description",
                    
                },
                {
                    title: l('Price'),
                    data: "price",
                   
                },
                
                {
                    title: l('StockQuantity'),
                    data: "stockQuantity",
                   
                }
            ]
        })
    );
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });


    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewProductButton').click(function (e) {
        e.preventDefault();
        debugger
        createModal.open();
    });

});

