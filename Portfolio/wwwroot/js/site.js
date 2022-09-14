document.addEventListener("DOMContentLoaded", () => {
    fadin('.fade', { delay: 200 })
});

//parallax
var image = document.getElementById('main-img');
new simpleParallax(image);