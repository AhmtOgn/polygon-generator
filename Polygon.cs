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
		Random rnd = new Random();

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



		public void CalculateEdgeCordinates()
		{
			Vertices.Clear();
			double angleStep = 2 * Math.PI / numberOfEdges; //
			double startAngle = rnd.NextDouble() * 2 * Math.PI; // rastgele başlangıç açısı

			for (int i = 0; i < numberOfEdges; i++)
			{
				double angle = startAngle + i * angleStep;
				double x = center.X + length * Math.Cos(angle);
				double y = center.Y + length * Math.Sin(angle);
				Vertices.Add(new Point2D(x, y, false));
			}
		}


		public void DrawPolygon(PictureBox pictureBox)
		{
			Graphics g = pictureBox.CreateGraphics();
			g.Clear(pictureBox.BackColor); // Önceki çizimleri sil

			if (Vertices.Count == 0) return;

			Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
			using (g = Graphics.FromImage(bmp))
			{
				g.Clear(Color.White);

				// Merkez (0,0) olacak şekilde ortala
				double centerX = pictureBox.Width / 2;
				double centerY = pictureBox.Height / 2;

				Pen pen = new Pen(Color.FromArgb(color.red, color.green, color.blue), 2);
				Point[] points = Vertices.Select(v => new Point((int)(centerX + v.X * 20), (int)(centerY - v.Y * 20))).ToArray(); // ölçekle ve Y ters çevir


				if (points.Length > 1)
				{
					g.DrawPolygon(pen, points);
				}

				
			}

			pictureBox.Image = bmp;
		}


		public void RotatePolygon(double angleDegrees, bool isCCW)
		{
			if (Vertices.Count == 0) return;

			double angleRad = angleDegrees * Math.PI / 180;
			if (!isCCW) angleRad = -angleRad;

			for (int i = 0; i < Vertices.Count; i++)
			{
				double dx = Vertices[i].X - center.X;
				double dy = Vertices[i].Y - center.Y;

				double newX = dx * Math.Cos(angleRad) - dy * Math.Sin(angleRad);
				double newY = dx * Math.Sin(angleRad) + dy * Math.Cos(angleRad);

				Vertices[i] = new Point2D((newX + center.X), (newY + center.Y), false);
			}
		}




	}
}
