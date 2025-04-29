using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygon
{
    class Polygon
    {
		Point2D center { set; get; }
		int lenght { set; get; }
		ColorRGB color { set; get; }
		int numberOfEdges { set; get; }

		public Polygon()
		{

		}
		
		public Polygon(Point2D _center, int _lenght)
		{
			this.center = _center;
			this.lenght = _lenght;	
		}

		public void calculateEdgeCoordinates()
		{
			
		}

		public void rotatePolygon()
		{

		}

	}

}
