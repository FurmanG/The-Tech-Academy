// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


// Functions to called onmouseover and on mouseout to change the color of "video_title"
function newColor() {
    document.getElementById("title").style.color = "gold";
}

function oldColor() {
    document.getElementById("title").style.color = "goldenrod";
}


function MoveTheBox() {
    let id = null;
    const elem = document.getElementById("animateBox");
    let pos = 0;
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame() {
        if (pos == 350) {
            clearInterval(id);
        } else {
            pos++;
            elem.style.top = pos + "px";
            elem.style.left = pos + "px";
        }
    }
}