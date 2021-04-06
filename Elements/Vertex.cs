using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphColoring.Elements
{
    class Vertex
    {
        private static int Counter = 1;
        private static int Radius = 30;
        public int Number { get; set; }
        public bool IsSelected { get; set; }
        public Point Center { get; set; }
        public List<Vertex> AdjacentVertices { get; set; }
        public Brush VertexColor { get; set; }

        public Vertex(Point Center)
        {
            this.Center = Center;
            Radius = 30;
            Number = Counter++;
            AdjacentVertices = new List<Vertex>();
            VertexColor = Brushes.Gray;
        }

        public void AddAdjacentVertex(Vertex vertex)
        {
            AdjacentVertices.Add(vertex);
        }

        public void RemoveAdjacentVertex(Vertex vertex)
        {
            AdjacentVertices.Remove(vertex);
        }

        public bool IsAdjacent(Vertex vertex)
        {
            return AdjacentVertices.Contains(vertex);
        }

        public bool IsPointInRange(Point point)
        {
            return (point.X - Center.X) * (point.X - Center.X) + (point.Y - Center.Y) * (point.Y - Center.Y) < Radius * Radius;
        }

        public void Draw(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);
            StringFormat stringFormat = new StringFormat();
            RectangleF rect = new RectangleF(Center.X - Radius / 2, Center.Y - Radius / 2, Radius, Radius);
            if (IsSelected)
                g.DrawEllipse(new Pen(Color.Red, 3), rect);
            g.FillEllipse(VertexColor, rect);
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(Number.ToString(), new Font("Verdana", 15),
                new SolidBrush(Color.Yellow), rect, stringFormat);
        }

    }
}
