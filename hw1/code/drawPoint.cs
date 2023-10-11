using System;
using System.Drawing;
using System.Windows.Forms;

class PointDrawingProgram : Form
{
    public PointDrawingProgram()
    {
        // Imposta le dimensioni della finestra
        this.Size = new Size(400, 400);

        // Registra l'evento Paint per disegnare il punto
        this.Paint += new PaintEventHandler(OnPaint);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        // Crea un oggetto Graphics dal modulo PaintEventArgs
        Graphics g = e.Graphics;

        // Crea una penna nera per disegnare il punto
        Pen blackPen = new Pen(Color.Black);

        // Definisci le coordinate del punto
        int x = 200;
        int y = 200;

        // Disegna il punto sulla superficie grafica
        g.DrawLine(blackPen, x, y, x + 1, y + 1);
    }

    public static void Main()
    {
        Application.Run(new PointDrawingProgram());
    }
}
