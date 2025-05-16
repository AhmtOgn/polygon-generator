using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
    class ColorRGB
    {
		public int red { set; get; }
		public int green { set; get; }
		public int blue { set; get; }
		
		Random rnd = new Random();

		public ColorRGB()
		{
			red = green = blue = 0;
		}
		public ColorRGB(int red, int green, int blue)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
		}
		public ColorRGB(Random rnd)
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
