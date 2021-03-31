var myTable;

$(document).ready(function () {
    loadTable();
});
function loadTable() {
    let url = "/Setup/Module/GetAll";
    myTable = $('#myTable1').DataTable({
        "ajax": url,
        "type": "GET",
        "datatype": "json",
        "bDestroy": true,
        "dom": 'Bfrtip',
        "buttons": [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columns": [
            { "mData": "id" },
            { "mData": "modulE_NAME" },
            {
                "mData": "modulE_ICON",
                render: function (mData) {
                    return '<i class="' + mData + '"></i>'
                }

            },
            { "mData": "modulE_BN_NAME" },
            { "mData": "vieW_ORDER" },
            { "mData": "controlleR_NAME" },
            { "mData": "methoD_NAME" },
            {
                "mData": "iS_ACTIVE",
                render: function (mData) {
                    if (mData == "1") {
                        return '<i class="fas fa-check-circle"></i>'
                    } else {
                        return '<i class="fas fa-times-circle"></i>'
                    }
                }
            },
            {
                "mData": "id",
                render: function (mData) {
                    return '<a href="/Setup/Module/ManageModule/?id=' + mData + '"><i class="fas fa-edit"></i></a> <a onClick=Delete("/Setup/Module/Remove/?id=' + mData + '")><i class="fas fa-trash"></i></a>'
                }
            },

        ],
        "language": { "emptyTable": "no data found" }, "width": "100%"
    });
};

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                success: function (data) {
                    if (data.success) {
                        Toast.fire({ icon: 'success', title: data.messages })
                        myTable.ajax.reload();
                    } else {
                        Toast.fire({ icon: 'error', title: data.messages })
                    }
                }
            });
        };
    })
}