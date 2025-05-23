﻿//***************************************************************************
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
	class ColorRGB // Class to represent RGB color values
	{
		public int red { set; get; } // Private red variables
		public int green { set; get; } // Private green variables
		public int blue { set; get; } // Private blue variables

		Random rnd = new Random(); // Generate random values

		public ColorRGB() // Constructor to set default color values (0)
		{
			red = green = blue = 0;
		}
		public ColorRGB(int red, int green, int blue) // Constructor to set color values
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
		}
		public ColorRGB(Random rnd) // Constructor to generate random colors
		{
			green = rnd.Next(0, 256);
			red = rnd.Next(0, 256);
			blue = rnd.Next(0, 256);
		}

		public Color ToColor()
		{
			return Color.FromArgb(red, green, blue);
		}
	}
}
