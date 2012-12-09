using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Music_Playlist_Randomizer
{
	public class M3UPlaylist : BasePlaylist
	{
		/// <summary>
		/// Gets the total seconds for the playlist.
		/// </summary>
		public int Seconds
		{
			get
			{
				int seconds = 0;
				foreach (M3USong song in this)
					seconds += song.Seconds;
				return seconds;
			}
		}
		/// <summary>
		/// Gets the time formatted in [hh:m]m:ss.
		/// </summary>
		public string Time
		{
			get
			{
				int seconds = this.Seconds;
				int minutes = seconds / 60;
				seconds %= 60;
				int hours = minutes / 60;
				minutes %= 60;
				string time = "";
				if (hours >= 0)
					time += hours + ":";
				if (minutes < 10 && hours > 0)
					time += "0";
				time += minutes + ":";
				if (seconds < 10)
					time += "0";
				time += seconds;
				return time;
			}
		}
		public M3UPlaylist()
		{
			this.Filename = "";
		}

		public override bool Load(string filename)
		{
			bool isLoaded = default(bool);
			try
			{
				this.Filename = filename;
				string[] lines = File.ReadAllLines(filename);
				if (lines.Length < 1 || lines[0] != "#EXTM3U")
					throw new FormatException("The file is not an M3U playlist.");
				for (int i = 1; i < lines.Length - 1; i += 2)
					this.Add(new M3USong(lines[i], lines[i + 1]));
				isLoaded = true;
			}
			catch
			{
				isLoaded = false;
			}
			return isLoaded;
		}

		public override bool Save()
		{
			bool isSaved = default(bool);
			try
			{
				string[] contents = new string[this.Count * 2 + 1];
				// Header
				contents[0] = "#EXTM3U";
				// Body
				for (int i = 0; i < this.Count; i++)
				{
					M3USong song = (M3USong)(this[i]);
					contents[i * 2 + 1] = "#EXTINF:" + song.Seconds.ToString() + "," + song.Filename;
					contents[i * 2 + 2] = song.FullPath;
				}

				// Final write
				File.WriteAllLines(this.Filename, contents);
				isSaved = true;
			}
			catch
			{
				isSaved = false;
			}
			return isSaved;
		}
	}
}
