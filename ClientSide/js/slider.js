var slideIndex = 1;
let ind = 0;
showSlides();
window.setInterval(showSlides, 7000);

function changeSlides(n) {
    showSlidesManually(slideIndex += n);
}

function currentSlide(n) {
    showSlidesManually(slideIndex = n);
}

function showSlidesManually(n) {
    var slides = document.getElementsByClassName("background__slides");
    var dots = document.getElementsByClassName("carousel__circle");
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (var i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (var i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";
    dots[slideIndex-1].className += " active";

}

function showSlides() {

    var slides = document.getElementsByClassName("background__slides");
    var dots = document.getElementsByClassName("carousel__circle");
    for (var i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (var i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    ind++;
    if (ind > slides.length) {ind = 1}


    slides[ind-1].style.display = "block";
    dots[ind-1].className += " active";
}