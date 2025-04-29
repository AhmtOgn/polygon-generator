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
			SuspendLayout();
			// 
			// buttonDraw
			// 
			buttonDraw.Location = new Point(662, 283);
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
			label1.Location = new Point(586, 47);
			label1.Name = "label1";
			label1.Size = new Size(70, 15);
			label1.TabIndex = 1;
			label1.Text = "Center (X,Y)";
			// 
			// textBoxX
			// 
			textBoxX.Location = new Point(662, 39);
			textBoxX.Name = "textBoxX";
			textBoxX.Size = new Size(27, 23);
			textBoxX.TabIndex = 2;
			// 
			// textBoxY
			// 
			textBoxY.Location = new Point(710, 39);
			textBoxY.Name = "textBoxY";
			textBoxY.Size = new Size(27, 23);
			textBoxY.TabIndex = 3;
			// 
			// button1
			// 
			button1.Location = new Point(662, 312);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(662, 341);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 5;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBoxY);
			Controls.Add(textBoxX);
			Controls.Add(label1);
			Controls.Add(buttonDraw);
			Name = "Form1";
			Text = "Form1";
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
	}
}
