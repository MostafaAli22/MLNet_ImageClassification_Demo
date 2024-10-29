namespace FruitDetictor
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
			pictureBoxImage = new PictureBox();
			buttonImportCheck = new Button();
			labelResult = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
			SuspendLayout();
			// 
			// pictureBoxImage
			// 
			pictureBoxImage.BorderStyle = BorderStyle.Fixed3D;
			pictureBoxImage.Location = new Point(78, 31);
			pictureBoxImage.Name = "pictureBoxImage";
			pictureBoxImage.Size = new Size(582, 402);
			pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxImage.TabIndex = 0;
			pictureBoxImage.TabStop = false;
			// 
			// buttonImportCheck
			// 
			buttonImportCheck.Location = new Point(78, 457);
			buttonImportCheck.Name = "buttonImportCheck";
			buttonImportCheck.Size = new Size(582, 53);
			buttonImportCheck.TabIndex = 1;
			buttonImportCheck.Text = "Import Check";
			buttonImportCheck.UseVisualStyleBackColor = true;
			buttonImportCheck.Click += buttonImportCheck_Click;
			// 
			// labelResult
			// 
			labelResult.BackColor = SystemColors.Info;
			labelResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			labelResult.Location = new Point(78, 542);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(582, 169);
			labelResult.TabIndex = 2;
			labelResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(727, 711);
			Controls.Add(labelResult);
			Controls.Add(buttonImportCheck);
			Controls.Add(pictureBoxImage);
			Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 5, 4, 5);
			Name = "Form1";
			Text = "Fruit Detictor";
			((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBoxImage;
		private Button buttonImportCheck;
		private Label labelResult;
	}
}