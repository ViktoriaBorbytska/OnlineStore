function pictureChange(change, thumb){
    var thumbs = document.querySelectorAll('.thumb');
    for (var i = 0; i < thumbs.length; i++) {
        thumbs[i].style.border = 'none';
    }
    if (change === true ) {
        document.getElementById("fullsize").src = document.getElementById(thumb).src;
        document.getElementById(thumb).style.border = '1px solid black';
    } else {
        document.getElementById("fullsize").src = document.getElementById('thumb1').src;
        document.getElementById('thumb1').style.border = '1px solid black';
    }
}