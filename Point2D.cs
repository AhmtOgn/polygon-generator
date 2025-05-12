	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

namespace polygon
{
	class Point2D
	{
		private const double PI = Math.PI;
		private double x;
		private double y;
		public double X { get; set; }
		public double Y { get; set; }
		public double R { private set; get; }
		public double Theta { private set; get; }

		private static Random rnd = new Random();
		public Point2D(double x, double y, bool enforceRange) //between [0-3]
		{
			if (enforceRange && (x < 0 || x > 3 || y < 0 || y > 3))
			{
				MessageBox.Show("X and Y must be between 0 and 3", "Invalid Point", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			X = x;
			Y = y;
			calculatePolarCordinates();

			
		}

		public Point2D()
		{
			this.X = rnd.Next(0, 4);
			this.Y = rnd.Next(0, 4);
			calculatePolarCordinates();
		}
		public string printCordinates()
		{
			return "X: " + X + " Y: " + Y;
		}

		public void calculatePolarCordinates()
		{
			R = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
			Theta = Math.Atan2(Y, X);
		}

		public void calculateCartesianCordinates()
		{
			X = (int)(R * Math.Cos(Theta));
			Y = (int)(R * Math.Sin(Theta));
		}
		public string printPolarCordianets()
		{
			return "R: " + R + " Theta: " + Theta;
		}
	}
}

