using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Music_Playlist_Randomizer
{
	public abstract class BasePlaylist : List<BaseSong>, IPlaylist<BaseSong>
	{
		public string Filename { get; protected set; }

		/// <summary>
		/// Shuffles the songs in the playlist.
		/// </summary>
		public void Shuffle()
		{
			// Fisher-Yates shuffle
			Random rng = new Random();
			int n = this.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				BaseSong song = this[k];
				this[k] = this[n];
				this[n] = song;
			}
		}

		public abstract bool Load(string filename);
		public abstract bool Save();

		/// <summary>
		/// Gets the extension of a filename.
		/// </summary>
		/// <param name="filename">The filename to get the extension of.</param>
		/// <returns></returns>
		public static string GetExtension(string filename)
		{
			string ext;
			int finalDotIndex = filename.LastIndexOf('.');
			if (finalDotIndex == -1 || filename.Length - finalDotIndex - 1 <= 0)
				ext = filename;
			else
				ext = filename.Substring(finalDotIndex + 1, filename.Length - finalDotIndex - 1);
			return ext;
		}
	}
}