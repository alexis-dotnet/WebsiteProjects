var opencount = -1;

window.onload = function () {
    document.getElementById('primarybtn').onclick = function () {
        opencount++;
        var dialog = document.getElementById("dialog").ej2_instances[0];
        dialog.show();
    };
}

function onOverlayClick() {
    var dialog = document.getElementById("dialog").ej2_instances[0];
    dialog.hide();
}

function validation(args) {
    args.cancel = opencount < 0;
}

function dlgButtonClick() {
    var dialogObj = document.getElementById('dialog').ej2_instances[0];
    dialogObj.hide();
}