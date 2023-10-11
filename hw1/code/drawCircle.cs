using System;
using System.Drawing;
using System.Windows.Forms;

// Definizione di una classe CircleGenerator che eredita da Form
class CircleGenerator : Form
{
    public CircleGenerator()
    {
        // Impostiamo la dimensione della finestra
        this.Size = new Size(400, 400);

        // Aggiungiamo un gestore per l'evento Paint
        this.Paint += new PaintEventHandler(OnPaint);
    }

    // Gestore per l'evento Paint
    private void OnPaint(object sender, PaintEventArgs e)
    {
        // Otteniamo un oggetto Graphics per disegnare
        Graphics g = e.Graphics;

        // Creiamo una penna nera per il contorno del cerchio
        Pen pen = new Pen(Color.Black);

        // Calcoliamo il centro della finestra
        int centerX = this.Width / 2;
        int centerY = this.Height / 2;

        // Calcoliamo il raggio del cerchio in modo che sia centrato e abbia un margine di 10 pixel
        int radius = Math.Min(centerX, centerY) - 10;

        // Disegniamo il cerchio utilizzando la penna
        g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
    }

    
    static void Main()
    {
        Application.Run(new CircleGenerator());
    }
}
