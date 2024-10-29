namespace FruitDetictor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void buttonImportCheck_Click(object sender, EventArgs e)
		{
			//Import image 
			OpenFileDialog openFile = new OpenFileDialog();
			var reslut = openFile.ShowDialog();
			if (reslut == DialogResult.OK)
			{
				// Set image into picturebox
				pictureBoxImage.Image = Image.FromFile(openFile.FileName);
				// Send image to ML model
				var imageBytes = File.ReadAllBytes(openFile.FileName);
				MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
				{
					ImageSource = imageBytes,
				};

				// Make a single prediction on the sample image and print results.
				buttonImportCheck.Text = "Deticting...";
				var result = await Task.Run(() => MLModel1.Predict(sampleData));
				labelResult.Text = result.PredictedLabel;
				buttonImportCheck.Text = "Import Check";
			}

		}
	}
}