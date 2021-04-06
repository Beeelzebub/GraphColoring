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
        public int Number { get; set; }
        public int Radius { get; set; }
        public bool IsSelected { get; set; }
        public Point Center { get; set; }
        public List<Vertex> AdjacentVertices { get; set; }
        public Color Color { get; set; }

        public Vertex(Point Center)
        {
            this.Center = Center;
            Radius = 30;
            AdjacentVertices = new List<Vertex>();
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
            if (IsSelected)
                g.DrawEllipse(new Pen(Color.Red, 3), Center.X - Radius / 2, Center.Y - Radius / 2, Radius, Radius);
            g.FillEllipse(Brushes.Gray, Center.X - Radius / 2, Center.Y - Radius / 2, Radius, Radius);
        }

    }
}
