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
		

		private void buttonDraw_Click(object sender, EventArgs e)
			{
				
			}

			private void buttonRotate_Click(object sender, EventArgs e)
			{
				
			}

			private void buttonReset_Click(object sender, EventArgs e)
			{
				ResetValues();
			}
		}
	}
