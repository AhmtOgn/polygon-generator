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
			public int X { private set; get; }
			public int Y { private set; get; }
			public double R { private set; get; }
			public double Theta { private set; get; }
			



			private static Random rnd = new Random();
		
			public Point2D(double x , double y) //between [0-3]
			{
				this.X = (int) x;
				this.Y = (int) y;
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
