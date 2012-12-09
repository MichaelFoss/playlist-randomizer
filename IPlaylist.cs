using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Music_Playlist_Randomizer
{
	public interface IPlaylist<BaseSong>
	{
		/// <summary>
		/// Gets the filename for the playlist.
		/// </summary>
		string Filename { get; }

		/// <summary>
		/// Loads the playlist.
		/// </summary>
		/// <param name="filename">The filename of the playlist.</param>
		/// <returns>True on success, false on failure.</returns>
		bool Load(string filename);
		/// <summary>
		/// Saves the playlist.
		/// </summary>
		/// <returns>True on success, false on failure.</returns>
		bool Save();
	}
}