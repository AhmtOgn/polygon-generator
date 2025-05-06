using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
	class Polygon
	{
		public Point2D center { set; get; }
		public int length { set; get; }
		public ColorRGB color { set; get; }
		public int numberOfEdges { set; get; }
		public List<Point2D> Vertices { get; set; }

		public Polygon()
		{
			center = new Point2D();
			length = 4;
			color = new ColorRGB();
			numberOfEdges = 5;
			Vertices = new List<Point2D>();
		}

		public Polygon(Point2D _center, int _lenght)
		{
			this.center = _center;
			this.length = _lenght;
			color = new ColorRGB();
			numberOfEdges = 5;
			Vertices = new List<Point2D>();
		}

		public void calculateEdgeCoordinates()
		{
			Vertices.Clear();
			Random rnd = new Random();
			double startAngle = rnd.Next(360);
			for (int i = 0; i < numberOfEdges; i++)
			{
				double angle = startAngle + i * 360.0 / numberOfEdges;
				double rad = angle * Math.PI / 180;
				double x = center.X + length * Math.Cos(rad);
				double y = center.Y + length * Math.Sin(rad);
				Vertices.Add(new Point2D(x, y));
			}
		}

		public void rotatePolygon(double angle, bool ccw)
		{
			double angleOffset = ccw ? angle : -angle;
			List<Point2D> newVertices = new List<Point2D>();
			foreach (var pt in Vertices)
			{
				double dx = pt.X - center.X;
				double dy = pt.Y - center.Y;
				double r = Math.Sqrt(dx * dx + dy * dy);
				double theta = Math.Atan2(dy, dx) * 180 / Math.PI;
				theta += angleOffset;
				double rad = theta * Math.PI / 180;
				double x = center.X + r * Math.Cos(rad);
				double y = center.Y + r * Math.Sin(rad);
				newVertices.Add(new Point2D(x, y));
			}
			Vertices = newVertices;

		}
	}
}
