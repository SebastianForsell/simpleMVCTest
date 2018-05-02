"use strict";
$(document).ready(function () {
    var keyDivValues = $("#keyDiv");
    $("#keyDiv").click(function () {
        if ($(window).width() < 600) {
            alert(keyDivValues.html());
        }
    });
});