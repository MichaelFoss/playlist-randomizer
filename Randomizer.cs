using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Music_Playlist_Randomizer
{
	public partial class RandomizerForm : Form
	{
		protected int _Shuffles = -1;
		public int Shuffles
		{
			get
			{
				return this._Shuffles;
			}
			set
			{
				this._Shuffles = value;
				if (this.Shuffles == -1)
					this.ShufflesLabel.Text = "n/a";
				else
					this.ShufflesLabel.Text = this.Shuffles.ToString();
			}
		}
		public BasePlaylist Playlist { get; protected set; }
		public string Filename
		{
			get
			{
				return this.FileLabel.Text;
			}
			set
			{
				// Try them all!
				try
				{
					this.Playlist = new M3UPlaylist();
					this.Playlist.Load(value);
					this.SongCountLabel.Text = this.Playlist.Count.ToString();
					this.TimeLabel.Text = ((M3UPlaylist)this.Playlist).Time;
				}
				// Aww, we couldn't load
				catch
				{
					this.Reset();
					return;
				}
				this.Shuffles = 0;
				this.FileLabel.Text = value;
				this.RandomizeButton.Enabled = true;
			}
		}

		public RandomizerForm()
		{
			InitializeComponent();
			this.AllowDrop = true;
			this.DragEnter += new DragEventHandler(this.FileDragEnter);
			this.DragDrop += new DragEventHandler(this.FileDragDrop);
			this.Reset();
		}

		protected void FileDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
		}

		protected void FileDragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (files.Length == 1 && files[0].Substring(files[0].LastIndexOf('.')).ToLower() == ".m3u")
				this.Filename = files[0];
		}

		/// <summary>
		/// Resets form to initial state.
		/// </summary>
		public void Reset()
		{
			this.Shuffles = -1;
			this.SongCountLabel.Text = "n/a";
			this.FileLabel.Text = "No File Selected";
			this.RandomizeButton.Enabled = false;
			this.Playlist = null;
		}

		/// <summary>
		/// Handles the clicking of the browse button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowseButton_Click(object sender, EventArgs e)
		{
			this.Reset();
			OpenFileDialog fd = new OpenFileDialog();
			fd.DefaultExt = ".m3u";
			fd.AddExtension = true;
			fd.CheckFileExists = true;
			fd.CheckPathExists = true;
			fd.Filter = "M3U Playlists (*.m3u)|*.m3u";
			fd.InitialDirectory = System.Environment.CurrentDirectory;
			fd.Title = "Open Music Playlist";
			fd.ValidateNames = true;
			if (fd.ShowDialog() == DialogResult.OK)
				this.Filename = fd.FileName;
			if (this.Filename == "")
				MessageBox.Show("The file is not an acceptable format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Handles the clicking of the randomize button.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomizeButton_Click(object sender, EventArgs e)
		{
			this.RandomizeButton.Enabled = false;
			this.Playlist.Shuffle();
			this.Playlist.Save();
			this.Shuffles++;
			this.RandomizeButton.Enabled = true;
		}
	}
}