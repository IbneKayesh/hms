$(document).ready(function () {

});

function btnSaveStateClick() {
    var data = [];
    var userId = $('#UserId').val();
    $("#mytable > tbody > tr").each(function () {
        var chkVal = $(this).find('td:eq(1)').find(':checkbox').val();
        if (chkVal !== undefined && userId !== '') {
            var chkStat = $(this).find('td:eq(1)').find(':checkbox').is(':checked');
            data.push({ myrole: chkVal, mystate: chkStat, myuser: userId });
        }
    });
    $.ajax({
        type: "GET",
        url: "/Setup/UserRole/UserRoleSetup",
        traditional: true,
        data: { 'post_data': JSON.stringify(data) },
        success: function (data) {
            if (data.success) {
                Toast.fire({ icon: 'success', title: data.messages })
            } else {
                Toast.fire({ icon: 'error', title: data.messages })
            }
        }
    });
}