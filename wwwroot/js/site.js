window.addEventListener("DOMContentLoaded", function () {

    const ball = document.getElementById("ball");

    let x = 100;
    let y = 100;
    let dx = 3;
    let dy = 3;

    function animate() {

        x += dx;
        y += dy;

        // Bounce from screen edges
        if (x <= 0 || x >= window.innerWidth - 50) dx *= -1;
        if (y <= 0 || y >= window.innerHeight - 50) dy *= -1;

        ball.style.left = x + "px";
        ball.style.top = y + "px";

        requestAnimationFrame(animate);
    }

    animate();
});