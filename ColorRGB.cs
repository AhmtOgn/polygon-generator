using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
    class ColorRGB
    {
		int red { set; get; }
		int green { set; get; }
		int blue { set; get; }
		
		Random rnd = new Random();
		public ColorRGB(int _red, int _green, int _blue)
		{
			this.red = _red;
			this.green = _green;
			this.blue = _blue;
		}
		public ColorRGB()
		{
			
			green = rnd.Next(0, 256);
			red = rnd.Next(0, 256);
			blue = rnd.Next(0, 256);
		}
	}
}
