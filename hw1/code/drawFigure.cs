using System;
using System.Drawing;
using System.Windows.Forms;

// Define a class ShapeGenerator that inherits from Form
class ShapeGenerator : Form
{
    public ShapeGenerator()
    {
        // Set the size of the window
        this.Size = new Size(400, 400);

        // Add a handler for the Paint event
        this.Paint += new PaintEventHandler(OnPaint);
    }

    // Handler for the Paint event
    private void OnPaint(object sender, PaintEventArgs e)
    {
        // Get a Graphics object for drawing
        Graphics g = e.Graphics;

        // Create a black pen for the outline of the shapes
        Pen pen = new Pen(Color.Black);

        // Draw a red point at coordinates (50, 50) with dimensions 2x2
        g.FillEllipse(Brushes.Red, 50, 50, 2, 2);

        // Draw a horizontal line from (100, 100) to (200, 100)
        g.DrawLine(pen, 100, 100, 200, 100);

        // Draw a rectangle with the upper-left corner at coordinates (50, 150),
        // width 200, and height 100
        g.DrawRectangle(pen, 50, 150, 200, 100);

        // Draw a circle with the center at coordinates (300, 300) and a radius of 50
        g.DrawEllipse(pen, 250, 250, 100, 100);
    }

    // The Main method starts the application
    static void Main()
    {
        Application.Run(new ShapeGenerator());
    }
}
