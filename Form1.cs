using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphColoring.Elements;

namespace GraphColoring
{
    public partial class Form1 : Form
    {
        private List<Vertex> Vertices;
        private List<Edge> Edges;
        private Vertex SelectedVertex;

        public Form1()
        {
            InitializeComponent();
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Vertices.Clear();
            Edges.Clear();
            Draw();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pricture_MouseDown(object sender, MouseEventArgs e)
        {
            Point relativePoint = e.Location;

            if (e.Button == MouseButtons.Left)
                LeftMouseButtonHundler(relativePoint);
            else if (e.Button == MouseButtons.Right)
                RightMouseButtonHundler(relativePoint);

            Draw();
        }

        private void RightMouseButtonHundler(Point relativePoint)
        {
            Vertex vertexInRange = GetVertexInRange(relativePoint);


        }

        private void LeftMouseButtonHundler(Point relativePoint)
        {
            Vertex vertexInRange = GetVertexInRange(relativePoint);

            if (vertexInRange == null)
            {
                if (SelectedVertex != null)
                {
                    SelectedVertex.IsSelected = false;
                    SelectedVertex = null;
                    return;
                }

                Vertices.Add(new Vertex(relativePoint));
            }
            else
            {
                if (SelectedVertex != null && !vertexInRange.Equals(SelectedVertex))
                {
                    SelectedVertex.IsSelected = false;
                    Edges.Add(new Edge(SelectedVertex, vertexInRange));
                    SelectedVertex = null;
                    return;
                }

                vertexInRange.IsSelected = true;
                SelectedVertex = vertexInRange;
            }
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(Picture.Width, Picture.Height);

            foreach (var edge in Edges)
                edge.Draw(bmp);

            foreach (var vertex in Vertices)
                vertex.Draw(bmp);

            Picture.Image = bmp;
        }

        private Vertex GetVertexInRange(Point point)
        {
            foreach (var vertex in Vertices)
                if (vertex.IsPointInRange(point))
                    return vertex;

            return null;
        }
    }
}
