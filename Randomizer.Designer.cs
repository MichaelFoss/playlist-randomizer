namespace Music_Playlist_Randomizer
{
	partial class RandomizerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BrowseButton = new System.Windows.Forms.Button();
			this.RandomizeButton = new System.Windows.Forms.Button();
			this.FileGroupBox = new System.Windows.Forms.GroupBox();
			this.FileLabel = new System.Windows.Forms.Label();
			this.SongCountForLabel = new System.Windows.Forms.Label();
			this.SongCountLabel = new System.Windows.Forms.Label();
			this.ShufflesLabel = new System.Windows.Forms.Label();
			this.ShufflesForLabel = new System.Windows.Forms.Label();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.TimeForLabel = new System.Windows.Forms.Label();
			this.FileGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(237, 70);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(75, 23);
			this.BrowseButton.TabIndex = 0;
			this.BrowseButton.Text = "&Browse...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// RandomizeButton
			// 
			this.RandomizeButton.Location = new System.Drawing.Point(237, 99);
			this.RandomizeButton.Name = "RandomizeButton";
			this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
			this.RandomizeButton.TabIndex = 1;
			this.RandomizeButton.Text = "&Randomize";
			this.RandomizeButton.UseVisualStyleBackColor = true;
			this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
			// 
			// FileGroupBox
			// 
			this.FileGroupBox.Controls.Add(this.FileLabel);
			this.FileGroupBox.Location = new System.Drawing.Point(13, 13);
			this.FileGroupBox.Name = "FileGroupBox";
			this.FileGroupBox.Size = new System.Drawing.Size(299, 40);
			this.FileGroupBox.TabIndex = 2;
			this.FileGroupBox.TabStop = false;
			this.FileGroupBox.Text = "File";
			// 
			// FileLabel
			// 
			this.FileLabel.AutoEllipsis = true;
			this.FileLabel.AutoSize = true;
			this.FileLabel.Location = new System.Drawing.Point(6, 16);
			this.FileLabel.Name = "FileLabel";
			this.FileLabel.Size = new System.Drawing.Size(85, 13);
			this.FileLabel.TabIndex = 0;
			this.FileLabel.Text = "No File Selected";
			// 
			// SongCountForLabel
			// 
			this.SongCountForLabel.AutoSize = true;
			this.SongCountForLabel.Location = new System.Drawing.Point(19, 64);
			this.SongCountForLabel.Name = "SongCountForLabel";
			this.SongCountForLabel.Size = new System.Drawing.Size(40, 13);
			this.SongCountForLabel.TabIndex = 3;
			this.SongCountForLabel.Text = "Songs:";
			// 
			// SongCountLabel
			// 
			this.SongCountLabel.AutoSize = true;
			this.SongCountLabel.Location = new System.Drawing.Point(65, 64);
			this.SongCountLabel.Name = "SongCountLabel";
			this.SongCountLabel.Size = new System.Drawing.Size(24, 13);
			this.SongCountLabel.TabIndex = 3;
			this.SongCountLabel.Text = "n/a";
			// 
			// ShufflesLabel
			// 
			this.ShufflesLabel.AutoSize = true;
			this.ShufflesLabel.Location = new System.Drawing.Point(65, 109);
			this.ShufflesLabel.Name = "ShufflesLabel";
			this.ShufflesLabel.Size = new System.Drawing.Size(24, 13);
			this.ShufflesLabel.TabIndex = 5;
			this.ShufflesLabel.Text = "n/a";
			// 
			// ShufflesForLabel
			// 
			this.ShufflesForLabel.AutoSize = true;
			this.ShufflesForLabel.Location = new System.Drawing.Point(19, 109);
			this.ShufflesForLabel.Name = "ShufflesForLabel";
			this.ShufflesForLabel.Size = new System.Drawing.Size(48, 13);
			this.ShufflesForLabel.TabIndex = 4;
			this.ShufflesForLabel.Text = "Shuffles:";
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Location = new System.Drawing.Point(65, 87);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(24, 13);
			this.TimeLabel.TabIndex = 7;
			this.TimeLabel.Text = "n/a";
			// 
			// TimeForLabel
			// 
			this.TimeForLabel.AutoSize = true;
			this.TimeForLabel.Location = new System.Drawing.Point(19, 87);
			this.TimeForLabel.Name = "TimeForLabel";
			this.TimeForLabel.Size = new System.Drawing.Size(33, 13);
			this.TimeForLabel.TabIndex = 6;
			this.TimeForLabel.Text = "Time:";
			// 
			// RandomizerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 135);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.TimeForLabel);
			this.Controls.Add(this.ShufflesLabel);
			this.Controls.Add(this.ShufflesForLabel);
			this.Controls.Add(this.SongCountLabel);
			this.Controls.Add(this.SongCountForLabel);
			this.Controls.Add(this.FileGroupBox);
			this.Controls.Add(this.RandomizeButton);
			this.Controls.Add(this.BrowseButton);
			this.Name = "RandomizerForm";
			this.Text = "Music Playlist Randomizer";
			this.FileGroupBox.ResumeLayout(false);
			this.FileGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.Button RandomizeButton;
		private System.Windows.Forms.GroupBox FileGroupBox;
		private System.Windows.Forms.Label FileLabel;
		private System.Windows.Forms.Label SongCountForLabel;
		private System.Windows.Forms.Label SongCountLabel;
		private System.Windows.Forms.Label ShufflesLabel;
		private System.Windows.Forms.Label ShufflesForLabel;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Label TimeForLabel;
	}
}

