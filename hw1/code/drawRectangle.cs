using System;
using System.Drawing;
using System.Windows.Forms;

class RectangleGenerator : Form
{
    public RectangleGenerator()
    {
        this.Size = new Size(400, 400);
        this.Paint += new PaintEventHandler(OnPaint);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen pen = new Pen(Color.Black);
        int x = 50; // Coordinata x dell'angolo superiore sinistro del rettangolo
        int y = 50; // Coordinata y dell'angolo superiore sinistro del rettangolo
        int width = 200; // Larghezza del rettangolo
        int height = 100; // Altezza del rettangolo

        g.DrawRectangle(pen, x, y, width, height);
    }

    static void Main()
    {
        Application.Run(new RectangleGenerator());
    }
}
