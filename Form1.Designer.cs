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
			buttonRotate = new Button();
			buttonReset = new Button();
			label2 = new Label();
			textBoxLength = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			trackBarRED = new TrackBar();
			trackBarBLUE = new TrackBar();
			trackBarGREEN = new TrackBar();
			label6 = new Label();
			textBoxEdges = new TextBox();
			checkBoxCCW = new CheckBox();
			textBoxAngel = new TextBox();
			label7 = new Label();
			listBoxVertices = new ListBox();
			pictureBox = new PictureBox();
			((System.ComponentModel.ISupportInitialize)trackBarRED).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarBLUE).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarGREEN).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			SuspendLayout();
			// 
			// buttonDraw
			// 
			buttonDraw.Location = new Point(906, 509);
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
			label1.Location = new Point(804, 68);
			label1.Name = "label1";
			label1.Size = new Size(70, 15);
			label1.TabIndex = 1;
			label1.Text = "Center (X,Y)";
			// 
			// textBoxX
			// 
			textBoxX.Location = new Point(887, 65);
			textBoxX.MaxLength = 1;
			textBoxX.Name = "textBoxX";
			textBoxX.Size = new Size(36, 23);
			textBoxX.TabIndex = 2;
			textBoxX.Text = "0";
			textBoxX.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxY
			// 
			textBoxY.Location = new Point(945, 65);
			textBoxY.MaxLength = 1;
			textBoxY.Name = "textBoxY";
			textBoxY.Size = new Size(36, 23);
			textBoxY.TabIndex = 3;
			textBoxY.Text = "0";
			textBoxY.TextAlign = HorizontalAlignment.Center;
			// 
			// buttonRotate
			// 
			buttonRotate.Location = new Point(906, 538);
			buttonRotate.Name = "buttonRotate";
			buttonRotate.Size = new Size(75, 23);
			buttonRotate.TabIndex = 19;
			buttonRotate.Text = "Rotate";
			buttonRotate.UseVisualStyleBackColor = true;
			buttonRotate.Click += buttonRotate_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(906, 567);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(75, 23);
			buttonReset.TabIndex = 20;
			buttonReset.Text = "Reset";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += buttonReset_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(827, 130);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 4;
			label2.Text = "Lenght";
			// 
			// textBoxLength
			// 
			textBoxLength.Location = new Point(887, 122);
			textBoxLength.MaxLength = 1;
			textBoxLength.Name = "textBoxLength";
			textBoxLength.Size = new Size(94, 23);
			textBoxLength.TabIndex = 5;
			textBoxLength.Text = "4";
			textBoxLength.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(844, 179);
			label3.Name = "label3";
			label3.Size = new Size(27, 15);
			label3.TabIndex = 6;
			label3.Text = "Red";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(833, 223);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 8;
			label4.Text = "Green";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(844, 270);
			label5.Name = "label5";
			label5.Size = new Size(30, 15);
			label5.TabIndex = 10;
			label5.Text = "Blue";
			// 
			// trackBarRED
			// 
			trackBarRED.LargeChange = 30;
			trackBarRED.Location = new Point(877, 179);
			trackBarRED.Maximum = 255;
			trackBarRED.Name = "trackBarRED";
			trackBarRED.Size = new Size(104, 45);
			trackBarRED.TabIndex = 7;
			// 
			// trackBarBLUE
			// 
			trackBarBLUE.LargeChange = 30;
			trackBarBLUE.Location = new Point(877, 270);
			trackBarBLUE.Maximum = 255;
			trackBarBLUE.Name = "trackBarBLUE";
			trackBarBLUE.Size = new Size(104, 45);
			trackBarBLUE.TabIndex = 11;
			// 
			// trackBarGREEN
			// 
			trackBarGREEN.LargeChange = 30;
			trackBarGREEN.Location = new Point(877, 223);
			trackBarGREEN.Maximum = 255;
			trackBarGREEN.Name = "trackBarGREEN";
			trackBarGREEN.Size = new Size(104, 45);
			trackBarGREEN.TabIndex = 9;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(804, 341);
			label6.Name = "label6";
			label6.Size = new Size(33, 15);
			label6.TabIndex = 12;
			label6.Text = "Edge";
			// 
			// textBoxEdges
			// 
			textBoxEdges.Location = new Point(844, 336);
			textBoxEdges.MaxLength = 2;
			textBoxEdges.Name = "textBoxEdges";
			textBoxEdges.Size = new Size(94, 23);
			textBoxEdges.TabIndex = 13;
			textBoxEdges.Text = "5";
			textBoxEdges.TextAlign = HorizontalAlignment.Center;
			// 
			// checkBoxCCW
			// 
			checkBoxCCW.AutoSize = true;
			checkBoxCCW.Checked = true;
			checkBoxCCW.CheckState = CheckState.Checked;
			checkBoxCCW.Location = new Point(955, 340);
			checkBoxCCW.Name = "checkBoxCCW";
			checkBoxCCW.Size = new Size(53, 19);
			checkBoxCCW.TabIndex = 14;
			checkBoxCCW.Text = "CCW";
			checkBoxCCW.UseVisualStyleBackColor = true;
			checkBoxCCW.CheckedChanged += checkBoxCCW_CheckedChanged;
			// 
			// textBoxAngel
			// 
			textBoxAngel.Location = new Point(844, 375);
			textBoxAngel.MaxLength = 3;
			textBoxAngel.Name = "textBoxAngel";
			textBoxAngel.Size = new Size(94, 23);
			textBoxAngel.TabIndex = 16;
			textBoxAngel.Text = "30";
			textBoxAngel.TextAlign = HorizontalAlignment.Center;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(804, 380);
			label7.Name = "label7";
			label7.Size = new Size(38, 15);
			label7.TabIndex = 15;
			label7.Text = "Angel";
			// 
			// listBoxVertices
			// 
			listBoxVertices.FormattingEnabled = true;
			listBoxVertices.ItemHeight = 15;
			listBoxVertices.Location = new Point(827, 404);
			listBoxVertices.Name = "listBoxVertices";
			listBoxVertices.Size = new Size(162, 94);
			listBoxVertices.TabIndex = 17;
			listBoxVertices.Tag = "";
			// 
			// pictureBox
			// 
			pictureBox.Location = new Point(12, 25);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(775, 607);
			pictureBox.TabIndex = 21;
			pictureBox.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1037, 659);
			Controls.Add(pictureBox);
			Controls.Add(listBoxVertices);
			Controls.Add(textBoxAngel);
			Controls.Add(label7);
			Controls.Add(checkBoxCCW);
			Controls.Add(textBoxEdges);
			Controls.Add(label6);
			Controls.Add(trackBarGREEN);
			Controls.Add(trackBarBLUE);
			Controls.Add(trackBarRED);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(textBoxLength);
			Controls.Add(label2);
			Controls.Add(buttonReset);
			Controls.Add(buttonRotate);
			Controls.Add(textBoxY);
			Controls.Add(textBoxX);
			Controls.Add(label1);
			Controls.Add(buttonDraw);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)trackBarRED).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarBLUE).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarGREEN).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonDraw;
		private Label label1;
		private TextBox textBoxX;
		private TextBox textBoxY;
		private Button buttonRotate;
		private Button buttonReset;
		private Label label2;
		private TextBox textBoxLength;
		private Label label3;
		private Label label4;
		private Label label5;
		private TrackBar trackBarRED;
		private TrackBar trackBarBLUE;
		private TrackBar trackBarGREEN;
		private Label label6;
		private TextBox textBoxEdges;
		private CheckBox checkBoxCCW;
		private TextBox textBoxAngel;
		private Label label7;
		private ListBox listBoxVertices;
		private PictureBox pictureBox;
	}
}
