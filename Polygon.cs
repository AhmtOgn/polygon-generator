using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
	class Polygon
	{
		private int numberOfEdges;
		private int length;
		public Point2D center { set; get; }
		public ColorRGB color { set; get; }
		public int Length
		{
			set
			{
				if (value < 3 || value > 9)
				{
					MessageBox.Show("Length must be between 3 and 10", "Invalid Length!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					length = value;
				}
			}
			get
			{
				return length;
			}
		}

		public int NumberOfEdges
		{

			set
			{
				if (value < 3 || value > 10)
				{
					MessageBox.Show("Number of edges must be between 3 and 10", "Invalid Edge Number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					numberOfEdges = value;
				}
			}
			get
			{
				return numberOfEdges;
			}
		}
		public List<Point2D> Vertices { get; set; }

		public Polygon()
		{
			center = new Point2D();
			length = 4;
			color = new ColorRGB();
			numberOfEdges = 5;
			Vertices = new List<Point2D>();
		}

		public Polygon(Point2D center, int lenght)
		{
			this.center = center;
			this.length = lenght;
			color = new ColorRGB();
			numberOfEdges = 5;
			Vertices = new List<Point2D>();
		}

		public void CalculateEdgeCordinates() { }
		public void DrawPolygon() { }
		public void RotatePolygon() { }

		
	}
}
