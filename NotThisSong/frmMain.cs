using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
//==================================================================================================================================
//this application is used to play a random mp3 file in a folder with a bunch of mp3 files, and able to delete it if you don't like
//it.
//==================================================================================================================================
//history:
//	2017.07.24: version 1.0.0.1 - initial version
//	2017.07.25: version 1.0.0.2 - files are deleted only after the aplication is close, fixed


namespace NotThisSong
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
		private string curMp3Name = "";

		//play next song
		private void btnNext_Click(object sender, EventArgs e)
		{
			wplayer.controls.stop();
			wplayer = null;
			wplayer = new WMPLib.WindowsMediaPlayer();
			Random rnd = new Random();
			string[] fs = Directory.GetFiles(@txtFolder.Text);
			curMp3Name = fs[rnd.Next(fs.Length)];
			lblStatus.Text = "now playing " + curMp3Name;
			wplayer.URL = curMp3Name;
			wplayer.controls.play();
		}

		//used to delete the mp3 file from disk that is playing now
		private void btnDel_Click(object sender, EventArgs e)
		{
			if (curMp3Name == "") {
				lblStatus.Text = "no file can be deleted, play a song with clicking 'Next' button";
				return;
			}
			wplayer.controls.stop();
			wplayer.close();
			wplayer = null;
			File.Delete(curMp3Name);
			lblStatus.Text = curMp3Name + " is deleted";
			curMp3Name = "";
		}
	}
}
