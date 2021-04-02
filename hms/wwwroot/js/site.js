paceOptions = {
    ajax: false, // disabled
    document: false, // disabled
    eventLag: false, // disabled
    elements: {
        selectors: ['.my-page']
    }
};
$(function () {
    $("#example1").DataTable({
        "responsive": true, "lengthChange": false, "autoWidth": false,
        "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');

    $('#example2').DataTable({
        "paging": false,
        "lengthChange": false,
        "searching": false,
        "ordering": true,
        "info": true,
        "autoWidth": false,
        "responsive": true,
    });
});

var Toast = Swal.mixin({
    position: 'top-end',
    showConfirmButton: false,
    timer: 1500
});
//Current Navigation Location by Menu Active
$(document).ready(function () {
    var url = window.location;
    $('ul.nav-treeview a').filter(function () {
        return this.href == url;
    }).addClass('active');
    $('ul.nav-sidebar a').filter(function () {
        return this.href == url;
    }).parent().parent().parent().addClass('menu-open').children('.nav-link').addClass('active');
});