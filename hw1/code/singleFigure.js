function getLine(){
    
<canvas id="myCanvas" width="400" height="400"></canvas>
    // Ottieni il riferimento al canvas
    var canvas = document.getElementById("myCanvas");
    // Ottieni il contesto di disegno 2D del canvas
    var context = canvas.getContext("2d");

    // Imposta il punto iniziale della linea (x1, y1) e il punto finale (x2, y2)
    var x1 = 50;
    var y1 = 50;
    var x2 = 350;
    var y2 = 350;

    // Imposta il colore della linea
    context.strokeStyle = "blue";

    // Imposta la larghezza della linea
    context.lineWidth = 5;

    // Disegna la linea
    context.beginPath();
    context.moveTo(x1, y1); // Muovi il cursore al punto iniziale
    context.lineTo(x2, y2); // Traccia una linea al punto finale
    context.stroke(); // Rendi visibile la linea
    context.closePath(); // Chiudi il percorso
}