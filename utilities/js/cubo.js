
const cube = document.getElementById('cube');
let initialX, initialY;
let isRotating = false;

cube.addEventListener('mousedown', (e) => {
    isRotating = true;
    initialX = e.clientX;
    initialY = e.clientY;
});

cube.addEventListener('mouseup', () => {
    isRotating = false;
});

cube.addEventListener('mousemove', (e) => {
    if (isRotating) {
        const deltaX = e.clientX - initialX;
        const deltaY = e.clientY - initialY;

        cube.style.transform = `rotateX(${deltaY}deg) rotateY(${-deltaX}deg)`;
    }
});

// Disabilita la selezione del testo durante la rotazione
cube.addEventListener('selectstart', () => false);