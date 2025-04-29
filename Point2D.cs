using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
    class Point2D
    {
          public int X { set; get; }
		public int Y { set; get; }
		public double r { set; get; }
		public double theta { set; get; }


		private static Random rnd = new Random();
		
		public Point2D(int x , int y) //between [0-3]
		{
			this.X = x;
			this.Y = y;
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
			r = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
			theta = Math.Atan2(Y, X);
		}

		public void calculateCartesianCordinates()
		{
			X = (int)(r * Math.Cos(theta));
			Y = (int)(r * Math.Sin(theta));
		}
		public string printPolarCordianets()
		{
			
			return "R: " + r + " Theta: " + theta;
		}
	}
}
