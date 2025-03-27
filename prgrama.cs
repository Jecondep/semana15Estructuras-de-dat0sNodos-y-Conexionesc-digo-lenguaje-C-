using System;
using System.Drawing;
using System.Windows.Forms;

public class GrafoForm : Form
{
    public GrafoForm()
    {
        this.Text = "Gráfico de Nodos y Conexiones";
        this.Size = new Size(450, 450);
        this.Paint += new PaintEventHandler(DibujaGrafo);
    }

    private void DibujaGrafo(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        // Configuración de los nodos
        Color nodoColor = Color.FromArgb(76, 175, 80); // Color verde
        Pen enlacePen = new Pen(Color.FromArgb(153, 153, 153), 2);

        // Coordenadas de los nodos
        Point A = new Point(100, 100); // Estación Central
        Point B = new Point(200, 100); // Estación Norte
        Point C = new Point(150, 200); // Estación Sur
        Point D = new Point(300, 200); // Estación Este

        // Dibuja los enlaces
        g.DrawLine(enlacePen, A, B); // A-B
        g.DrawLine(enlacePen, A, C); // A-C
        g.DrawLine(enlacePen, B, C); // B-C
        g.DrawLine(enlacePen, B, D); // B-D
        g.DrawLine(enlacePen, C, D); // C-D

        // Dibuja los nodos
        g.FillEllipse(new SolidBrush(nodoColor), A.X - 20, A.Y - 20, 40, 40); // A
        g.FillEllipse(new SolidBrush(nodoColor), B.X - 20, B.Y - 20, 40, 40); // B
        g.FillEllipse(new SolidBrush(nodoColor), C.X - 20, C.Y - 20, 40, 40); // C
        g.FillEllipse(new SolidBrush(nodoColor), D.X - 20, D.Y - 20, 40, 40); // D

        // Dibuja etiquetas
        g.DrawString("A", new Font("Arial", 12), Brushes.White, A);
        g.DrawString("B", new Font("Arial", 12), Brushes.White, B);
        g.DrawString("C", new Font("Arial", 12), Brushes.White, C);
        g.DrawString("D", new Font("Arial", 12), Brushes.White, D);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new GrafoForm());
    }
}
