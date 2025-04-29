namespace polygon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonDraw = new Button();
			label1 = new Label();
			textBoxX = new TextBox();
			textBoxY = new TextBox();
			button1 = new Button();
			button2 = new Button();
			label2 = new Label();
			textLenght = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			trackBarRED = new TrackBar();
			trackBarBLUE = new TrackBar();
			trackBarGREEN = new TrackBar();
			label6 = new Label();
			textEdgesNumber = new TextBox();
			checkBoxCCW = new CheckBox();
			textAngel = new TextBox();
			label7 = new Label();
			listBoxeEdgeCordinates = new ListBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)trackBarRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarBLUE).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarGREEN).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// buttonDraw
			// 
			buttonDraw.Location = new Point(778, 476);
			buttonDraw.Name = "buttonDraw";
			buttonDraw.Size = new Size(75, 23);
			buttonDraw.TabIndex = 18;
			buttonDraw.Text = "Draw";
			buttonDraw.UseVisualStyleBackColor = true;
			buttonDraw.Click += buttonDraw_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(676, 35);
			label1.Name = "label1";
			label1.Size = new Size(70, 15);
			label1.TabIndex = 1;
			label1.Text = "Center (X,Y)";
			// 
			// textBoxX
			// 
			textBoxX.Location = new Point(759, 32);
			textBoxX.MaxLength = 1;
			textBoxX.Name = "textBoxX";
			textBoxX.Size = new Size(36, 23);
			textBoxX.TabIndex = 2;
			textBoxX.Text = "0";
			textBoxX.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxY
			// 
			textBoxY.Location = new Point(817, 32);
			textBoxY.MaxLength = 1;
			textBoxY.Name = "textBoxY";
			textBoxY.Size = new Size(36, 23);
			textBoxY.TabIndex = 3;
			textBoxY.Text = "0";
			textBoxY.TextAlign = HorizontalAlignment.Center;
			// 
			// button1
			// 
			button1.Location = new Point(778, 505);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 19;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(778, 534);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 20;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(699, 97);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 4;
			label2.Text = "Lenght";
			// 
			// textLenght
			// 
			textLenght.Location = new Point(759, 89);
			textLenght.MaxLength = 1;
			textLenght.Name = "textLenght";
			textLenght.Size = new Size(94, 23);
			textLenght.TabIndex = 5;
			textLenght.Text = "4";
			textLenght.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(716, 146);
			label3.Name = "label3";
			label3.Size = new Size(27, 15);
			label3.TabIndex = 6;
			label3.Text = "Red";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(705, 190);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 8;
			label4.Text = "Green";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(716, 237);
			label5.Name = "label5";
			label5.Size = new Size(30, 15);
			label5.TabIndex = 10;
			label5.Text = "Blue";
			// 
			// trackBarRED
			// 
			trackBarRED.LargeChange = 30;
			trackBarRED.Location = new Point(749, 146);
			trackBarRED.Maximum = 256;
			trackBarRED.Name = "trackBarRED";
			trackBarRED.Size = new Size(104, 45);
			trackBarRED.TabIndex = 7;
			// 
			// trackBarBLUE
			// 
			trackBarBLUE.LargeChange = 30;
			trackBarBLUE.Location = new Point(749, 237);
			trackBarBLUE.Maximum = 256;
			trackBarBLUE.Name = "trackBarBLUE";
			trackBarBLUE.Size = new Size(104, 45);
			trackBarBLUE.TabIndex = 11;
			// 
			// trackBarGREEN
			// 
			trackBarGREEN.LargeChange = 30;
			trackBarGREEN.Location = new Point(749, 190);
			trackBarGREEN.Maximum = 256;
			trackBarGREEN.Name = "trackBarGREEN";
			trackBarGREEN.Size = new Size(104, 45);
			trackBarGREEN.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(676, 308);
			label6.Name = "label6";
			label6.Size = new Size(33, 15);
			label6.TabIndex = 12;
			label6.Text = "Edge";
			// 
			// textEdgesNumber
			// 
			textEdgesNumber.Location = new Point(716, 303);
			textEdgesNumber.MaxLength = 2;
			textEdgesNumber.Name = "textEdgesNumber";
			textEdgesNumber.Size = new Size(94, 23);
			textEdgesNumber.TabIndex = 13;
			textEdgesNumber.Text = "5";
			textEdgesNumber.TextAlign = HorizontalAlignment.Center;
			// 
			// checkBoxCCW
			// 
			checkBoxCCW.AutoSize = true;
			checkBoxCCW.Checked = true;
			checkBoxCCW.CheckState = CheckState.Checked;
			checkBoxCCW.Location = new Point(827, 307);
			checkBoxCCW.Name = "checkBoxCCW";
			checkBoxCCW.Size = new Size(53, 19);
			checkBoxCCW.TabIndex = 14;
			checkBoxCCW.Text = "CCW";
			checkBoxCCW.UseVisualStyleBackColor = true;
			checkBoxCCW.CheckedChanged += checkBoxCCW_CheckedChanged;
			// 
			// textAngel
			// 
			textAngel.Location = new Point(716, 342);
			textAngel.MaxLength = 3;
			textAngel.Name = "textAngel";
			textAngel.Size = new Size(94, 23);
			textAngel.TabIndex = 16;
			textAngel.Text = "30";
			textAngel.TextAlign = HorizontalAlignment.Center;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(676, 347);
			label7.Name = "label7";
			label7.Size = new Size(38, 15);
			label7.TabIndex = 15;
			label7.Text = "Angel";
			// 
			// listBoxeEdgeCordinates
			// 
			listBoxeEdgeCordinates.FormattingEnabled = true;
			listBoxeEdgeCordinates.ItemHeight = 15;
			listBoxeEdgeCordinates.Location = new Point(699, 371);
			listBoxeEdgeCordinates.Name = "listBoxeEdgeCordinates";
			listBoxeEdgeCordinates.Size = new Size(162, 94);
			listBoxeEdgeCordinates.TabIndex = 17;
			listBoxeEdgeCordinates.Tag = "";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(53, 50);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(576, 463);
			pictureBox1.TabIndex = 21;
			pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(892, 566);
			Controls.Add(pictureBox1);
			Controls.Add(listBoxeEdgeCordinates);
			Controls.Add(textAngel);
			Controls.Add(label7);
			Controls.Add(checkBoxCCW);
			Controls.Add(textEdgesNumber);
			Controls.Add(label6);
			Controls.Add(trackBarGREEN);
			Controls.Add(trackBarBLUE);
			Controls.Add(trackBarRED);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(textLenght);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBoxY);
			Controls.Add(textBoxX);
			Controls.Add(label1);
			Controls.Add(buttonDraw);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)trackBarRED).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarBLUE).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarGREEN).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonDraw;
		private Label label1;
		private TextBox textBoxX;
		private TextBox textBoxY;
		private Button button1;
		private Button button2;
		private Label label2;
		private TextBox textLenght;
		private Label label3;
		private Label label4;
		private Label label5;
		private TrackBar trackBarRED;
		private TrackBar trackBarBLUE;
		private TrackBar trackBarGREEN;
		private Label label6;
		private TextBox textEdgesNumber;
		private CheckBox checkBoxCCW;
		private TextBox textAngel;
		private Label label7;
		private ListBox listBoxeEdgeCordinates;
		private PictureBox pictureBox1;
	}
}
