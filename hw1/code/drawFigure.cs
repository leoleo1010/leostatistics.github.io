using System;
using System.Drawing;
using System.Windows.Forms;

class LineDrawingProgram : Form
{
    public LineDrawingProgram()
    {
        // Imposta le dimensioni della finestra
        this.Size = new Size(400, 400);

        // Registra l'evento Paint per disegnare la linea
        this.Paint += new PaintEventHandler(OnPaint);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        // Crea un oggetto Graphics dal modulo PaintEventArgs
        Graphics g = e.Graphics;

        // Crea una penna nera per disegnare la linea
        Pen blackPen = new Pen(Color.Black, 2);

        // Definisci i punti di inizio e fine della linea
        Point startPoint = new Point(50, 50);
        Point endPoint = new Point(350, 350);

        // Disegna la linea sulla superficie grafica
        g.DrawLine(blackPen, startPoint, endPoint);
    }

    public static void Main()
    {
        Application.Run(new LineDrawingProgram());
    }
}
