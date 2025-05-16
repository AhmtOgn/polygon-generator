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
		private int x;
		private int y;
		public int X 
		{
			set
			{
				if (value < 0 || value > 3)
					throw new ArgumentOutOfRangeException("X", "X must be between 0 and 3");
				x = value;
			}
			get { return x; }
		}
		public int Y
		{
			set
			{
				if (value < -3 || value > 0 )
					throw new ArgumentOutOfRangeException("Y", "Y must be between -3 and 0");
				y = value;
			}
			get	{ return y; }
		}
		public double R { private set; get; }
		public double Theta { private set; get; }

		private static Random rnd = new Random();
		public Point2D(double x, double y, bool isForCenter) // Without isForCenter, It can be an error because edge cordinates not between 0 and 3
		{
			if (isForCenter)
			{
				X = (int)Math.Round(x);
				Y = (int)Math.Round(y);
				calculatePolarCordinates();
			}
			else
			{
				x = (int)Math.Round(x);
				y = (int)Math.Round(y);
				calculatePolarCordinates();
			}
		}

		public Point2D()
		{
			this.x = rnd.Next(0, 4);
			this.y = rnd.Next(-3, 1);
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

