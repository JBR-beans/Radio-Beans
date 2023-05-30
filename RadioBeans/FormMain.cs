using System.Media;
using System.Windows.Forms.Design;

namespace RadioBeans
{
	public partial class FormMain : Form
	{
		String filePath = "";
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}

		private void btnSoundTest_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = "D:\\Music";
			ofd.Filter = "ogg files (*.ogg)|*.ogg|All files (*.*)|*.*";
			ofd.FilterIndex = 1;
			ofd.RestoreDirectory = true;
			filePath = ofd.SafeFileName;
			
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				//SoundPlayer soundPlayer = new SoundPlayer(filePath);
				lblNowPlaying.Text = "Now Playing: " + filePath.ToString();
			}
			
		}

		
	}
}