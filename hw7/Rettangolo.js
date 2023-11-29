"use strict";

class Rettangolo {

  constructor(x, y, width, height) {
    this.x = x;
    this.y = y;
    this.width = width;
    this.height = height;
  }

  left() {
    return this.x;
  }

  top() {
    return this.y;
  }

  right() {
    return this.x + this.width;
  }

  bottom() {
    return this.y + this.height;
  }

  aspectRatio() {
    return this.width / this.height || 1;
    // converto NaN a 1
  }

  disegnaRettangolo(ctx, Colore, Spessore, lineDash) {
    ctx.save();
    ctx.beginPath();
    ctx.rect(this.x, this.y, this.width, this.height);
    ctx.strokeStyle = Colore;
    ctx.lineWidth = Spessore;
    ctx.setLineDash(lineDash);
    ctx.stroke();

    // Aggiungi assi cartesiani
    this.disegnaAsse(ctx, "gray", this.x, this.y + this.height / 2, this.x + this.width, this.y + this.height / 2);
    this.disegnaAsse(ctx, "gray", this.x + this.width / 2, this.y, this.x + this.width / 2, this.y + this.height);

    // Etichette numeriche
    this.scriviTesto(ctx, "0", this.x + this.width / 2 - 5, this.y + this.height / 2 + 10);
    this.scriviTesto(ctx, this.width.toFixed(2), this.x + this.width - 15, this.y + this.height / 2 + 10);
    this.scriviTesto(ctx, this.height.toFixed(2), this.x + this.width / 2 - 20, this.y + this.height - 5);

    ctx.restore();
  }

  disegnaAsse(ctx, colore, startX, startY, endX, endY) {
    ctx.beginPath();
    ctx.moveTo(startX, startY);
    ctx.lineTo(endX, endY);
    ctx.strokeStyle = colore;
    ctx.stroke();
  }

  scriviTesto(ctx, testo, x, y) {
    ctx.fillStyle = "black";
    ctx.font = "10px Arial";
    ctx.fillText(testo, x, y);
  }

  contains(x, y) {
    let lowerX = Math.min(this.left(), this.right());
    let UpperX = Math.max(this.left(), this.right());

    let lowerY = Math.min(this.top(), this.bottom());
    let UpperY = Math.max(this.top(), this.bottom());

    if (x > lowerX && x < UpperX && y > lowerY && y < UpperY) {
      return true;
    }
  }
}