var myTable;

$(document).ready(function () {
    loadTable();
});
function loadTable() {
    let url = "/Setup/BloodGroup/GetAll";
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
            { "mData": "blooD_GROUP_NAME" },
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

        ],
        "language": { "emptyTable": "no data found" }, "width": "100%"
    });
};