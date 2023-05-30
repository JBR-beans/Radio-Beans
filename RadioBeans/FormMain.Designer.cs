namespace RadioBeans
{
	partial class FormMain
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
			btnSoundTest = new Button();
			pictureBox1 = new PictureBox();
			btnBitmapTest = new Button();
			lblNowPlaying = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnSoundTest
			// 
			btnSoundTest.Location = new Point(12, 12);
			btnSoundTest.Name = "btnSoundTest";
			btnSoundTest.Size = new Size(87, 23);
			btnSoundTest.TabIndex = 0;
			btnSoundTest.Text = "Sound Test";
			btnSoundTest.UseVisualStyleBackColor = true;
			btnSoundTest.Click += btnSoundTest_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(118, 32);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(553, 344);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// btnBitmapTest
			// 
			btnBitmapTest.Location = new Point(701, 12);
			btnBitmapTest.Name = "btnBitmapTest";
			btnBitmapTest.Size = new Size(87, 23);
			btnBitmapTest.TabIndex = 2;
			btnBitmapTest.Text = "Bitmap Test";
			btnBitmapTest.UseVisualStyleBackColor = true;
			// 
			// lblNowPlaying
			// 
			lblNowPlaying.AutoSize = true;
			lblNowPlaying.Location = new Point(12, 426);
			lblNowPlaying.Name = "lblNowPlaying";
			lblNowPlaying.Size = new Size(122, 15);
			lblNowPlaying.TabIndex = 3;
			lblNowPlaying.Text = "Now Playing: fdffsdfd";
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblNowPlaying);
			Controls.Add(btnBitmapTest);
			Controls.Add(pictureBox1);
			Controls.Add(btnSoundTest);
			Name = "FormMain";
			Text = "Radio Beans Music Player";
			Load += FormMain_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSoundTest;
		private PictureBox pictureBox1;
		private Button btnBitmapTest;
		private Label lblNowPlaying;
	}
}