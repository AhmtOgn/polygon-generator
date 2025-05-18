//***************************************************************************
//															**
//			STUDENT NAME.............:	AHMET OGAN				**
//			STUDENT NUMBER...........:	B231202030				**
//***************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
	class Polygon // Class for Polygon
	{
		Random rnd = new Random();

		private int numberOfEdges; //
		private int length;
		public Point2D center { set; get; }
		public ColorRGB color { set; get; }
		public int Length 
		{
			set //// Setter that checks if value is between 3 and 9
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

			set //// Setter that checks if the value is between 3 and 10
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
		public List<Point2D> Vertices { get; set; } // Creates a list for Vertices

		public Polygon() // Constructor to set default values for polygon 
		{
			center = new Point2D();
			length = 4;
			color = new ColorRGB();
			numberOfEdges = 5;
			Vertices = new List<Point2D>();
		}

		public Polygon(Point2D center, int lenght) // Constructor to set default values and the values that are tooken from user
		{
			this.center = center;
			this.length = lenght;
			color = new ColorRGB();
			numberOfEdges = 5;
			Vertices = new List<Point2D>();
		}



		public void CalculateEdgeCordinates() // Method to calculate edge cordinate and save them to the list 
		{
			Vertices.Clear();
			double angleStep = 2 * Math.PI / numberOfEdges; // Calculates interior angles of polygons 
			double startAngle = rnd.NextDouble() * 2 * Math.PI; // rnd.NextDouble gives a random number between 0 and 360 degrees. So it begins to calculate cordinates from random points. So the rotation will be changed everytime

			for (int i = 0; i < numberOfEdges; i++) // Loop to calculate every edge 
			{
				double angle = startAngle + i * angleStep;
				double x = center.X + length * Math.Cos(angle);
				double y = center.Y + length * Math.Sin(angle);
				Vertices.Add(new Point2D(x, y, false));
			}
		}


		public void DrawPolygon(PictureBox pictureBox) // Method to draw polygon into picture box 
		{
			Graphics g = pictureBox.CreateGraphics();
			g.Clear(pictureBox.BackColor); // Deletes old draws 

			if (Vertices.Count == 0) return; // If there are no vertice it will not be drawn 

			Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
			using (g = Graphics.FromImage(bmp))
			{
				g.Clear(Color.White);

				double centerX = pictureBox.Width / 2;
				double centerY = pictureBox.Height / 2;

				Pen pen = new Pen(Color.FromArgb(color.red, color.green, color.blue), 2);
				Point[] points = Vertices.Select(v => new Point((int)(centerX + v.X * 20), (int)(centerY - v.Y * 20))).ToArray(); 


				if (points.Length > 1)
				{
					g.DrawPolygon(pen, points);
				}

				
			}

			pictureBox.Image = bmp;
		}


		public void RotatePolygon(double angleDegrees, bool isCCW) // Method to rotate polygon with parametes that are how many degrees will be rotated and whether CW or CWW is
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
