//***************************************************************************
//															**
//			STUDENT NAME.............:	AHMET OGAN				**
//			STUDENT NUMBER...........:	B231202030				**
//***************************************************************************

using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
	class Point2D // Class 
	{
		private const double PI = Math.PI; // PI number as const 
		private double x; 
		private double y;
		public double X // X component of points
		{
			set // Setter that checks interval is valid (0 and 3)
			{
				if (value < 0 || value > 3)
					throw new ArgumentOutOfRangeException("X", "X must be between 0 and 3");
				x = value;
			}
			get { return x; }
		}
		public double Y // Setter that checks interval is valid (-3 and 0)
		{
			set
			{
				if (value < -3 || value > 0 )
					throw new ArgumentOutOfRangeException("Y", "Y must be between -3 and 0");
				y = value;
			}
			get	{ return y; }
		} 
		public double R { private set; get; } // Variable for radius of polygon 
		public double Theta { private set; get; } // Variable for Angle 

		private static Random rnd = new Random();
		public Point2D(double x, double y, bool isForCenter) // Without isForCenter, It can be an error because edge cordinates not between 0 and 3
		{
			if (isForCenter)
			{
				X = x;
				Y = y;
			}
			else
			{
				this.x = x;
				this.y = y;
			}
			calculatePolarCordinates();
		}

		public Point2D() // Constructor to set random values for X that is between "0 and 3" and Y that is between "-3 and 0"
		{
			this.X = rnd.Next(0, 4);
			this.Y = rnd.Next(-3, 1);
			calculatePolarCordinates();
		}
		public string printCordinates() // Method to print the coordinates
		{
			return "X: " + X + " Y: " + Y;
		}

		public void calculatePolarCordinates() // Method to calculate polar coordinates
		{
			R = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
			Theta = Math.Atan2(Y, X);
		}

		public void calculateCartesianCordinates() // Method to calculate cartesian coordinates
		{
			X = (int)(R * Math.Cos(Theta));
			Y = (int)(R * Math.Sin(Theta));
		}
		public string printPolarCordianets() // Method to print polar coordinates 
		{
			return "R: " + R + " Theta: " + Theta;
		}
	}
}

