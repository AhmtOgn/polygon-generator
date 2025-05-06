namespace polygon
{
	public partial class Form1 : Form
	{
		Polygon polygon;
		Random rnd = new Random();
		public Form1()
		{
			InitializeComponent();
			ResetValues();
		}

		void ResetValues()
		{
			polygon = new Polygon();
			polygon.center = new Point2D(rnd.Next(0, 4), rnd.Next(-3, 4));
			polygon.length = rnd.Next(3, 10);
			polygon.numberOfEdges = rnd.Next(3, 11);
			polygon.color = new ColorRGB(rnd);
			trackBarRED.Value = polygon.color.red;
			trackBarGREEN.Value = polygon.color.green;
			trackBarBLUE.Value = polygon.color.blue;
			textBoxX.Text = polygon.center.X.ToString();
			textBoxY.Text = polygon.center.Y.ToString();
			textBoxLength.Text = polygon.length.ToString();
			textBoxEdges.Text = polygon.numberOfEdges.ToString();
			textBoxAngel.Text = "30";
		}

		void DrawPolygon()
		{
			polygon.center = new Point2D(double.Parse(textBoxX.Text), double.Parse(textBoxY.Text));
			polygon.length = int.Parse(textBoxLength.Text);
			polygon.numberOfEdges = int.Parse(textBoxEdges.Text);
			polygon.color = new ColorRGB(trackBarRED.Value, trackBarGREEN.Value, trackBarBLUE.Value);
			polygon.calculateEdgeCoordinates();

			listBoxVertices.Items.Clear();
			foreach (var v in polygon.Vertices)
			{
				listBoxVertices.Items.Add($"({v.X:F2}, {v.Y:F2})");
			}

			Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				g.Clear(Color.White);

				float scale = 40f; // 1 birim = 40 piksel
				Pen pen = new Pen(polygon.color.ToColor(), 3);

				PointF[] points = new PointF[polygon.Vertices.Count];
				for (int i = 0; i < polygon.Vertices.Count; i++)
				{
					float x = (float)(polygon.Vertices[i].X * scale + pictureBox.Width / 2);
					float y = (float)(-polygon.Vertices[i].Y * scale + pictureBox.Height / 2); // y ekseni ters
					points[i] = new PointF(x, y);
				}

				g.DrawPolygon(pen, points);
			}

			pictureBox.Image = bmp;
		}




		private void buttonDraw_Click(object sender, EventArgs e)
		{
			/*
			string xText = textBoxX.Text;
			string yText = textBoxY.Text;

			if (int.TryParse(xText, out int xValue) && int.TryParse(yText, out int yValue)) //Checks if the user input is convertible to int
			{

				if (0 <= xValue && xValue <= 3 && 0 <= yValue && yValue <= 3) //Checks if the range correct
				{
					// If the conversion is successful, we can now create an instance of our Point2D class
					// and set its X and Y properties using the user's input.
					Point2D pointP = new Point2D(xValue, yValue);


					// Now, 'pointP' holds the coordinates entered by the user.
					// You can now use this 'pointP' object as needed in your application.
					// For example, you might want to display the coordinates somewhere else:
					string pCordinates = pointP.printCordinates();

					MessageBox.Show(
						pCordinates,                                           //Message
						"Point Coordinates",                                   //Title
						MessageBoxButtons.OK,                                  //Button for ok
						MessageBoxIcon.Information                             //Information icon
						);
				}
				else
				{
					MessageBox.Show(
						"Please enter numeric values between [0-3} for X and Y.",   //Message		
						"ERROR!",                                                   //Title 
						MessageBoxButtons.OK,                                       //Button for ok
						MessageBoxIcon.Error                                        //Error icon
					);
				}


			}
			else
			{
				// If the conversion fails (e.g., the user entered text that's not a number),
				// it's good practice to show an error message to the user.
				MessageBox.Show(
					"Please enter valid numeric values for X and Y.", //Message
					"ERROR!",                                              //Title 
					MessageBoxButtons.OK,                                  //Button for ok
					MessageBoxIcon.Error                                   //Error icon
					);
			}
			*/
			DrawPolygon();
		}


		private void checkBoxCCW_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void buttonRotate_Click(object sender, EventArgs e)
		{
			if (polygon.Vertices == null || polygon.Vertices.Count == 0) buttonReset.PerformClick();
			double angle = double.Parse(textBoxAngel.Text);
			polygon.rotatePolygon(angle, checkBoxCCW.Checked);
			DrawPolygon();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ResetValues();
		}
	}
}
