const container = document.querySelector('.container');
const canvas = document.getElementById('myCanvas');
const context = canvas.getContext('2d');

let isResizing = false;

container.addEventListener('mousedown', (e) => {
  if (e.target === container) {
    isResizing = true;
    initialX = e.clientX - container.offsetWidth;
  }
});

document.addEventListener('mousemove', (e) => {
  if (!isResizing) return;
  container.style.width = (e.clientX - initialX) + 'px';
  canvas.width = container.offsetWidth;
  // Aggiorna il contenuto del canvas se necessario
});

document.addEventListener('mouseup', () => {
  isResizing = false;
});

// Disegna qualcosa sul canvas (ad esempio, un rettangolo)
context.fillRect(10, 10, canvas.width - 20, canvas.height - 20);
