//***************************************************************************
//															**
//			STUDENT NAME.............:	AHMET OGAN				**
//			STUDENT NUMBER...........:	B231202030				**
//***************************************************************************

using System.Windows.Forms;

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

		void ResetValues() //Method to reset the values of the polygon
		{
			polygon = new Polygon();
			polygon.center = new Point2D();
			polygon.Length = rnd.Next(3, 10);
			polygon.NumberOfEdges = rnd.Next(3, 11);
			polygon.color = new ColorRGB(rnd);
			trackBarRED.Value = polygon.color.red;
			trackBarGREEN.Value = polygon.color.green;
			trackBarBLUE.Value = polygon.color.blue;
			textBoxX.Text = polygon.center.X.ToString();
			textBoxY.Text = polygon.center.Y.ToString();
			textBoxLength.Text = polygon.Length.ToString();
			textBoxEdges.Text = polygon.NumberOfEdges.ToString();
			textBoxAngel.Text = "0";

		}


		private void buttonDraw_Click(object sender, EventArgs e) // Button to draw polygon 
		{
			// Check if value of X and Y cordinates valid, and if not, show a message box and polygon are not drawn
			try
			{
				double x = double.Parse(textBoxX.Text);
				double y = double.Parse(textBoxY.Text);

				polygon.center = new Point2D(x, y, true);

			}
			catch (ArgumentOutOfRangeException ex) // Prevent to entering values out of range
			{
				MessageBox.Show(ex.Message, "Invalid X or Y!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch (FormatException) // Prevent to entering invalid values
			{
				MessageBox.Show("Please enter valid numbers.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check if value of Length is valid, and if not, show a message box and polygon are not drawn
			try
			{
				int input = int.Parse(textBoxLength.Text);
				polygon.Length = input;
			}
			catch (FormatException)
			{
				MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			catch (ArgumentOutOfRangeException ex)
			{
				MessageBox.Show(ex.Message, "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check if value of NumberOfEdges is valid, and if not, show a message box and polygon are not drawn
			try
			{
				int input = int.Parse(textBoxEdges.Text);
				polygon.NumberOfEdges = input;
			}
			catch (FormatException)
			{
				MessageBox.Show("Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			catch (ArgumentOutOfRangeException ex)
			{
				MessageBox.Show(ex.Message, "Invalid Number of Edges", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			polygon.color = new ColorRGB(trackBarRED.Value, trackBarGREEN.Value, trackBarBLUE.Value);
			polygon.CalculateEdgeCordinates();
			polygon.DrawPolygon(pictureBox);

			listBoxVertices.Items.Clear(); // Clears the list box that shows the vertices of the polygon
			for (int i = 0; i < polygon.Vertices.Count; i++) // for every vertice, it adds the vertices to the list box
			{
				var v = polygon.Vertices[i];
				listBoxVertices.Items.Add($"V{i + 1} = ({v.X},{v.Y})");
			}
		}



		private void buttonRotate_Click(object sender, EventArgs e) // Button to rotate the polygon
		{
			if (polygon.Vertices.Count == 0) // If there are no vertices, it is not rotated
			{
				buttonReset_Click(sender, e);
			}

			double angle = double.Parse(textBoxAngel.Text); // Variable that is tooken from text box that user entered
			bool isCCW = checkBoxCCW.Checked; // Checks if CW or CCW is

			polygon.RotatePolygon(angle, isCCW);
			polygon.DrawPolygon(pictureBox);

			listBoxVertices.Items.Clear();
			for (int i = 0; i < polygon.Vertices.Count; i++)
			{
				var v = polygon.Vertices[i];
				listBoxVertices.Items.Add($"V{i + 1} = ({v.X},{v.Y})");
			}
		}


		private void buttonReset_Click(object sender, EventArgs e) // Button to reset the values of polygon
		{
			ResetValues();
		}
	}
}
