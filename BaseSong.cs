using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Music_Playlist_Randomizer
{
	public abstract class BaseSong
	{
		protected string _Filename = "";
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			protected set
			{
				this._Filename = value;
			}
		}
		public string _FullPath = "";
		public string FullPath
		{
			get
			{
				return this._FullPath;
			}
			protected set
			{
				this._FullPath = value;
				int finalBackslashIndex = this.FullPath.LastIndexOf('\\');
				if (finalBackslashIndex == -1 || this.FullPath.Length - finalBackslashIndex - 1 <= 0)
					this.Filename = this.FullPath;
				else
					this.Filename = this.FullPath.Substring(finalBackslashIndex + 1, this.FullPath.Length - finalBackslashIndex - 1);
			}
		}
	}
}