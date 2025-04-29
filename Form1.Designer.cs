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
			textBox1 = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			trackBar1 = new TrackBar();
			trackBar2 = new TrackBar();
			trackBar3 = new TrackBar();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
			SuspendLayout();
			// 
			// buttonDraw
			// 
			buttonDraw.Location = new Point(778, 452);
			buttonDraw.Name = "buttonDraw";
			buttonDraw.Size = new Size(75, 23);
			buttonDraw.TabIndex = 0;
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
			textBoxX.Name = "textBoxX";
			textBoxX.Size = new Size(36, 23);
			textBoxX.TabIndex = 2;
			// 
			// textBoxY
			// 
			textBoxY.Location = new Point(817, 32);
			textBoxY.Name = "textBoxY";
			textBoxY.Size = new Size(36, 23);
			textBoxY.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(778, 505);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(778, 534);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 5;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(699, 97);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 6;
			label2.Text = "Lenght";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(759, 89);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(94, 23);
			textBox1.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(716, 146);
			label3.Name = "label3";
			label3.Size = new Size(27, 15);
			label3.TabIndex = 8;
			label3.Text = "Red";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(705, 190);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 9;
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
			// trackBar1
			// 
			trackBar1.Location = new Point(749, 146);
			trackBar1.Name = "trackBar1";
			trackBar1.Size = new Size(104, 45);
			trackBar1.TabIndex = 11;
			// 
			// trackBar2
			// 
			trackBar2.Location = new Point(749, 237);
			trackBar2.Name = "trackBar2";
			trackBar2.Size = new Size(104, 45);
			trackBar2.TabIndex = 12;
			// 
			// trackBar3
			// 
			trackBar3.Location = new Point(749, 190);
			trackBar3.Name = "trackBar3";
			trackBar3.Size = new Size(104, 45);
			trackBar3.TabIndex = 13;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(705, 300);
			label6.Name = "label6";
			label6.Size = new Size(33, 15);
			label6.TabIndex = 14;
			label6.Text = "Edge";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(892, 566);
			Controls.Add(label6);
			Controls.Add(trackBar3);
			Controls.Add(trackBar2);
			Controls.Add(trackBar1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBoxY);
			Controls.Add(textBoxX);
			Controls.Add(label1);
			Controls.Add(buttonDraw);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
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
		private TextBox textBox1;
		private Label label3;
		private Label label4;
		private Label label5;
		private TrackBar trackBar1;
		private TrackBar trackBar2;
		private TrackBar trackBar3;
		private Label label6;
	}
}
