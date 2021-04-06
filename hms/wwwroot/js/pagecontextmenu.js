$(document).keydown(function (event) {
    if (event.keyCode == 123) {
        return false;//Prevent from F12
    }
    else if (event.ctrlKey && event.shiftKey && event.keyCode == 73) {
        return false; //Prevent from ctrl+shift+i
    }
});

// Trigger action when the contexmenu is about to be shown
$(document).bind("contextmenu", function (event) {

    // Avoid the real one
    event.preventDefault();

    // Show contextmenu
    $(".custom-menu").finish().toggle(100).

        // In the right position (the mouse)
        css({
            top: event.pageY + "px",
            left: event.pageX + "px"
        });
});


// If the document is clicked somewhere
$(document).bind("mousedown", function (e) {

    // If the clicked element is not the menu
    if (!$(e.target).parents(".custom-menu").length > 0) {

        // Hide it
        $(".custom-menu").hide(100);
    }
});


// If the menu element is clicked
$(".custom-menu li").click(function () {

    // This is the triggered action name
    switch ($(this).attr("data-action")) {

        // A case for each action. Your actions here
        case "click1": click1(); break;
        case "click2": click2(); break;
        case "click3": click3(); break;
    }

    // Hide it AFTER the action was triggered
    $(".custom-menu").hide(100);
});

function click1() {
    Swal.fire('Hello','Kayesh - Net Core Programmer');
}
function click2() {
    Swal.fire('Hello', 'Mithun - Net Core Programmer');
}
function click3() {
    Swal.fire('Okay', 'Lets go with new startup');
}