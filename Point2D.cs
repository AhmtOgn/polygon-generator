//***************************************************************************
//															**
//			STUDENT NAME.............:	AHMET OGAN				**
//			STUDENT NUMBER...........:	B231202030				**
//***************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
	class Point2D // Class for point that has x and y component 
	{
		private const double PI = Math.PI; // PI number as const 
		private double x; // Private X component for Public X
		private double y; // Private Y component for Public Y
		public double X // Public X component of points
		{
			set // Setter that checks interval is valid (0 and 3)
			{
				if (value < 0 || value > 3) // Interval is checked here
					throw new ArgumentOutOfRangeException("X", "X must be between 0 and 3"); // If interval is invalid throw an exception
				x = value; // If it is valid, value will be equal to x
			}
			get { return x; } // getter to obtain x
		}
		public double Y // Setter that checks interval is valid (-3 and 0)
		{
			set
			{
				if (value < -3 || value > 0) // Interval is checked here
					throw new ArgumentOutOfRangeException("Y", "Y must be between -3 and 0"); // If interval is invalid throw an exception
				y = value; // If it is valid, value will be equal to y
			}
			get { return y; } // getter to obtain y
		}
		public double R { private set; get; } // Variable for radius of polygon 
		public double Theta { private set; get; } // Variable for Angle 

		private static Random rnd = new Random(); // generate random values 
		public Point2D(double x, double y, bool isForCenter) // Without isForCenter, It can be an error because edge cordinates not between 0 and 3
		{
			if (isForCenter) // If it is for center, parameters are assigned through X and Y properties
			{
				X = x;
				Y = y;
			}
			else // If it is for edge cordinates, parameters assigh directly x and y
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
			R = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); // Radius equals to x square plus y square
			Theta = Math.Atan2(Y, X); // Theta equal to arctan(Y/X)
		}

		public void calculateCartesianCordinates() // Method to calculate cartesian coordinates
		{
			X = (int)(R * Math.Cos(Theta)); // X equals to radiius timmes cos(theta) between x apsis and OX  
			Y = (int)(R * Math.Sin(Theta)); // Y equals to radiius timmes sin(theta) between y apsis and OX  
		}
		public string printPolarCordianets() // Method to print polar coordinates 
		{
			return "R: " + R + " Theta: " + Theta;
		}
	}
}

