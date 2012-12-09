using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Music_Playlist_Randomizer
{
	public class M3USong : BaseSong
	{
		public int Seconds { get; protected set; }

		public M3USong(string fullPath, int seconds)
		{
			this.Initialize(fullPath, seconds);
		}

		public M3USong(string line1, string line2)
		{
			string fullPath;
			int seconds;
			try
			{
				fullPath = line2;
				seconds = Convert.ToInt32(line1.Substring("#EXTINF:".Length, line1.IndexOf(',') - "#EXTINF:".Length));
			}
			catch
			{
				fullPath = "";
				seconds = 0;
			}
			this.Initialize(fullPath, seconds);
		}

		protected void Initialize(string fullPath, int seconds)
		{
			this.FullPath = fullPath;
			this.Seconds = seconds;
		}
	}
}