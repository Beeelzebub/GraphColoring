using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphColoring.Elements
{
    class Edge
    {
        public Vertex FirstVertex { get; set; }
        public Vertex SecondVertex { get; set; }

        public Edge(Vertex FirstVertex, Vertex SecondVertex)
        {
            this.FirstVertex = FirstVertex;
            this.SecondVertex = SecondVertex;

            if (!this.FirstVertex.AdjacentVertices.Contains(SecondVertex))
                this.FirstVertex.AddAdjacentVertex(SecondVertex);
            if (!this.SecondVertex.AdjacentVertices.Contains(FirstVertex))
                this.SecondVertex.AddAdjacentVertex(FirstVertex);
        }

        public void Draw(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);

            g.DrawLine(new Pen(Color.Black, 3), FirstVertex.Center, SecondVertex.Center);
        }

        public void Clean()
        {

        }
    }
}
