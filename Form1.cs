namespace polygon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonDraw_Click(object sender, EventArgs e)
		{
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
		}

		private void checkBoxCCW_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
