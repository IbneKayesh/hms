$(document).ready(function () {

});

function btnSaveRoleMenuClick() {
    var data = [];
    var roleId = $('#Role').val();
    $("#mytable > tbody > tr").each(function () {
        var chkVal = $(this).find('td:eq(2)').find(':checkbox').val();
        if (chkVal !== undefined && roleId !== '') {
            var chkStat = $(this).find('td:eq(2)').find(':checkbox').is(':checked');
            data.push({ mymenu: chkVal, mystate: chkStat, myrole: roleId });
        }
    });
    $.ajax({
        type: "GET",
        url: "/Setup/RoleMenu/RoleMenuSetup",
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