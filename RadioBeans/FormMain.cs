using LibVLCSharp.Shared;
using System;
using System.Linq;
using System.Media;
using System.Threading.Tasks;

using System.Windows.Forms.Design;

namespace RadioBeans
{

	public partial class FormMain : Form
	{
		string fileTypeSelected = string.Empty;
		public FormMain()
		{
			InitializeComponent();

		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			
			String[] fileTypes =
			{
				"WAV files (*.wav)|*.wav",
				"MP3 files (*.mp3)|*.mp3",
				"OGG files (*.ogg)|*.ogg"
			};

			foreach (String type in fileTypes)
			{
				cboFileTypeSelect.Items.Add(type);
			}
			
			/*cboFileTypeSelect.SelectedItem = 1;
			cboFileTypeSelect.Items.Add("WAV files (*.wav)|*.wav");
			cboFileTypeSelect.Items.Add("MP3 files (*.mp3)|*.mp3");
			cboFileTypeSelect.Items.Add("OGG files (*.ogg)|*.ogg");
*/
		}

		private void btnSoundTest_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = OpenFile();

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				string filePath = ofd.FileName;
				SoundPlayer player = new SoundPlayer(filePath);
				player.Play();
			}

		}

		private void txtYoutubeURL_TextChanged(object sender, EventArgs e)
		{

		}

		// GETTING MEDIA FILES
		public OpenFileDialog OpenFile()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = Environment.SpecialFolder.CommonMusic.ToString();
			//ofd.InitialDirectory = "D:\\Design";
			ofd.Filter = fileTypeSelected;
			ofd.FilterIndex = 1;
			ofd.RestoreDirectory = true;
			return ofd;
		}
		public String GetFilePath(OpenFileDialog ofd)
		// get the full file path of the desired file to be used by the media player internals
		{
			string filePath = ofd.FileName;
			return filePath;
		}
		public String GetFileName(OpenFileDialog ofd)
		// get the modified path to be used to display the title of the currently playing media
		{
			string fileName = ofd.SafeFileName;
			return fileName;
		}

		// PLAYING SOUND
		public SoundPlayer SelectSound(String filePath)
		// pass in the file path of the desired audio and return the object with that information
		{
			SoundPlayer soundPlayer = new SoundPlayer(filePath);
			return soundPlayer;
		}
		public void PlaySound(SoundPlayer soundPlayer)
		// pass in the sound player and file path information and play that audio
		{
			soundPlayer.Play();
		}

		private void cboFileTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			fileTypeSelected = cboFileTypeSelect.SelectedItem.ToString();
		}
	}
}