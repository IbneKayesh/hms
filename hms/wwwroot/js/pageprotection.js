//kayesh 8 apr 2021
$(document).bind("contextmenu", function (e) {
    e.preventDefault();
});
$(document).keydown(function (event) {
    if (event.keyCode == 123) {
        return false;//Prevent from F12
    }
    else if (event.ctrlKey && event.shiftKey && event.keyCode == 73) {
        return false; //Prevent from ctrl+shift+i
    }
});