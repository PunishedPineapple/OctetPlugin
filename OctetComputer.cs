using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Text.RegularExpressions;
using System.Linq;
[assembly: AssemblyTitle( "Octet Plugin" )]
[assembly: AssemblyVersion( "1.0.0.0" )]
[assembly: AssemblyCopyright( "Copyright (c) 2019 Punished Pineapple" )]

namespace ACT_Plugin
{
	public class OctetComputer : UserControl, IActPluginV1
	{
		#region Designer Created Code (Avoid editing)
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.player1TextBox = new System.Windows.Forms.TextBox();
			this.player2TextBox = new System.Windows.Forms.TextBox();
			this.player3TextBox = new System.Windows.Forms.TextBox();
			this.player4TextBox = new System.Windows.Forms.TextBox();
			this.player5TextBox = new System.Windows.Forms.TextBox();
			this.player6TextBox = new System.Windows.Forms.TextBox();
			this.player7TextBox = new System.Windows.Forms.TextBox();
			this.player8TextBox = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.logsTextBox = new System.Windows.Forms.TextBox();
			this.exportButton = new System.Windows.Forms.Button();
			this.importButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add( this.player1TextBox );
			this.panel1.Controls.Add( this.player2TextBox );
			this.panel1.Controls.Add( this.player3TextBox );
			this.panel1.Controls.Add( this.player4TextBox );
			this.panel1.Controls.Add( this.player5TextBox );
			this.panel1.Controls.Add( this.player6TextBox );
			this.panel1.Controls.Add( this.player7TextBox );
			this.panel1.Controls.Add( this.player8TextBox );
			this.panel1.Location = new System.Drawing.Point( 3, 27 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size( 202, 211 );
			this.panel1.TabIndex = 8;
			// 
			// player1TextBox
			// 
			this.player1TextBox.Location = new System.Drawing.Point( 23, 11 );
			this.player1TextBox.Name = "player1TextBox";
			this.player1TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player1TextBox.TabIndex = 8;
			this.player1TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player2TextBox
			// 
			this.player2TextBox.Location = new System.Drawing.Point( 23, 34 );
			this.player2TextBox.Name = "player2TextBox";
			this.player2TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player2TextBox.TabIndex = 9;
			this.player2TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player3TextBox
			// 
			this.player3TextBox.Location = new System.Drawing.Point( 23, 57 );
			this.player3TextBox.Name = "player3TextBox";
			this.player3TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player3TextBox.TabIndex = 10;
			this.player3TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player4TextBox
			// 
			this.player4TextBox.Location = new System.Drawing.Point( 23, 80 );
			this.player4TextBox.Name = "player4TextBox";
			this.player4TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player4TextBox.TabIndex = 11;
			this.player4TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player5TextBox
			// 
			this.player5TextBox.Location = new System.Drawing.Point( 23, 103 );
			this.player5TextBox.Name = "player5TextBox";
			this.player5TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player5TextBox.TabIndex = 12;
			this.player5TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player6TextBox
			// 
			this.player6TextBox.Location = new System.Drawing.Point( 23, 126 );
			this.player6TextBox.Name = "player6TextBox";
			this.player6TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player6TextBox.TabIndex = 13;
			this.player6TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player7TextBox
			// 
			this.player7TextBox.Location = new System.Drawing.Point( 23, 148 );
			this.player7TextBox.Name = "player7TextBox";
			this.player7TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player7TextBox.TabIndex = 14;
			this.player7TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// player8TextBox
			// 
			this.player8TextBox.Location = new System.Drawing.Point( 23, 171 );
			this.player8TextBox.Name = "player8TextBox";
			this.player8TextBox.Size = new System.Drawing.Size( 164, 20 );
			this.player8TextBox.TabIndex = 15;
			this.player8TextBox.TextChanged += new System.EventHandler( this.UpdatePlayers );
			// 
			// logsTextBox
			// 
			this.logsTextBox.Location = new System.Drawing.Point( 211, 27 );
			this.logsTextBox.MaxLength = 1000000;
			this.logsTextBox.Multiline = true;
			this.logsTextBox.Name = "logsTextBox";
			this.logsTextBox.ReadOnly = true;
			this.logsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.logsTextBox.Size = new System.Drawing.Size( 427, 148 );
			this.logsTextBox.TabIndex = 14;
			this.logsTextBox.Text = "Started..";
			this.logsTextBox.WordWrap = false;
			// 
			// exportButton
			// 
			this.exportButton.Location = new System.Drawing.Point( 211, 215 );
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size( 75, 23 );
			this.exportButton.TabIndex = 9;
			this.exportButton.Text = "Export";
			this.exportButton.UseVisualStyleBackColor = true;
			this.exportButton.Click += new System.EventHandler( this.ExportPlayerList );
			// 
			// importButton
			// 
			this.importButton.Location = new System.Drawing.Point( 211, 181 );
			this.importButton.Name = "importButton";
			this.importButton.Size = new System.Drawing.Size( 75, 23 );
			this.importButton.TabIndex = 10;
			this.importButton.Text = "Import";
			this.importButton.UseVisualStyleBackColor = true;
			this.importButton.Click += new System.EventHandler( this.ImportPlayerList );
			// 
			// JailPriority
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.logsTextBox );
			this.Controls.Add( this.importButton );
			this.Controls.Add( this.exportButton );
			this.Controls.Add( this.panel1 );
			this.Name = "JailPriority";
			this.Size = new System.Drawing.Size( 969, 493 );
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		#endregion

		//  Construction
		public OctetComputer()
		{
			InitializeComponent();
		}

		#region IActPluginV1 Members
		public void InitPlugin( TabPage pluginScreenSpace, Label pluginStatusText )
		{
			lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add( this );   // Add this UserControl to the tab ACT provides
			this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
			xmlSettings = new SettingsSerializer( this ); // Create a new settings serializer and pass it this instance
			LoadSettings();
			ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
			lblStatus.Text = "Plugin Started";
		}

		public void DeInitPlugin()
		{
			// Unsubscribe from any events you listen to when exiting!
			ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;
			SaveSettings();
			lblStatus.Text = "Plugin Exited";
		}
		#endregion


		void LoadSettings()
		{
			if( File.Exists( settingsFile ) )
			{
				FileStream fs = new FileStream( settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite );
				XmlTextReader xReader = new XmlTextReader( fs );
				TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
				try
				{
					int i = 0;
					while( xReader.Read() )
					{
						if( xReader.NodeType == XmlNodeType.Element )
						{
							if( xReader.Name == "Player" )
							{
								String line = xReader.ReadElementContentAsString();
								mPlayers.Add( line );
								Players[i].Text = line;
								++i;
							}
						}
					}
				}
				catch( Exception ex )
				{
					lblStatus.Text = "Error loading settings: " + ex.Message;
				}
				xReader.Close();
			}
		}
		void SaveSettings()
		{
			FileStream fs = new FileStream( settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite );
			XmlTextWriter xWriter = new XmlTextWriter( fs, Encoding.UTF8 );
			TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
			xWriter.Formatting = Formatting.Indented;
			xWriter.Indentation = 1;
			xWriter.IndentChar = '\t';
			xWriter.WriteStartDocument( true );
			xWriter.WriteStartElement( "Config" );    // <Config>
			for( int i = 0; i < Players.Length; ++i )
			{
				xWriter.WriteStartElement( "Player" );
				xWriter.WriteValue( Players[i].Text );
				xWriter.WriteEndElement();
			}
			xWriter.WriteEndElement();  // </Config>
			xWriter.WriteEndDocument(); // Tie up loose ends (shouldn't be any)
			xWriter.Flush();    // Flush the file buffer to disk
			xWriter.Close();
		}

		private void ExportPlayerList( object sender, EventArgs e )
		{
			SaveFileDialog savefile = new SaveFileDialog();
			// set a default file name
			savefile.FileName = "Priority.xml";
			// set filters - this can be done in properties as well
			savefile.Filter = "XML file (*.xml)|*.xml|All files (*.*)|*.*";
			savefile.RestoreDirectory = true;
			if( savefile.ShowDialog() == DialogResult.OK )
			{
				try
				{
					using( FileStream fs = new FileStream( savefile.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite ) )
					{
						XmlTextWriter xWriter = new XmlTextWriter( fs, Encoding.UTF8 );
						TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
						xWriter.Formatting = Formatting.Indented;
						xWriter.Indentation = 1;
						xWriter.IndentChar = '\t';
						xWriter.WriteStartDocument( true );
						xWriter.WriteStartElement( "Priority" );
						for( int i = 0; i < Players.Length; i++ )
						{
							xWriter.WriteStartElement( "Player" );
							xWriter.WriteValue( Players[i].Text );
							xWriter.WriteEndElement();
						}
						xWriter.WriteEndElement();
						xWriter.WriteEndDocument();
						xWriter.Flush();
						xWriter.Close();
					}
				}
				catch( Exception ex )
				{
					lblStatus.Text = "Error Exporting File: " + ex.Message;
				}
			}
		}
		private void ImportPlayerList( object sender, EventArgs e )
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.CheckFileExists = true;
			openFileDialog1.CheckPathExists = true;
			openFileDialog1.DefaultExt = "txt";
			openFileDialog1.Filter = "XML file (*.xml)|*.xml|All files (*.*)|*.*";
			openFileDialog1.RestoreDirectory = true;
			if( openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				if( File.Exists( openFileDialog1.FileName ) )
				{
					try
					{
						FileStream fs = new FileStream( openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite );
						TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
						XmlTextReader xReader = new XmlTextReader( fs );
						int i = 0;
						while( xReader.Read() )
						{
							if( xReader.NodeType == XmlNodeType.Element )
							{
								if( xReader.Name == "Player" )
								{
									Players[i].Text = xReader.ReadElementContentAsString();
									i++;
								}
							}
						}
						xReader.Close();
					}
					catch( Exception ex )
					{
						lblStatus.Text = "Error Importing File: " + ex.Message;
					}

				}
			}
		}

		/////////////////
		//
		//  Utility Functions
		//
		/////////////////

		private void UpdatePlayers( object sender, EventArgs e )
		{
			mPlayers.Clear();
			TextBox[] Players = panel1.Controls.OfType<TextBox>().ToArray();
			for( int i = 0; i < Players.Length; ++i )
			{
				mPlayers.Add( Players[i].Text );
			}
		}

		/////////////////
		//
		//  Callbacks
		//
		/////////////////

		private void OFormActMain_OnLogLineRead( bool isImport, LogLineEventArgs logInfo )
		{
			//  Check for a regex match.
			var match = Regex.Match( logInfo.logLine, mDiveRegEx, RegexOptions.IgnoreCase );

			//  If no match, get out now.
			if( !match.Success ) return;

			//  Octet is 30s from start of cast to Bahamut Marker, so if it's been longer than that since the last player was marked, make sure we're starting fresh.
			if( mStopwatch.ElapsedMilliseconds > 30000 )
			{
				ResetOctetComputer();
			}

			//  Log the matched lines and get started.
			++mNumMatches;
			logsTextBox.Text += "\r\n" + logInfo.logLine;
			mStopwatch.Start();

			//  Check the list of known players to see if it contains the marked one.
			bool foundPlayer = false;
			for( int i = 0; i < System.Math.Min( mPlayers.Count, mMarkedPlayerIndices.Count ); ++i )
			{
				if( logInfo.logLine.Contains( mPlayers[i] ) )
				{
					if( mMarkedPlayerIndices[i] )
					{
						logsTextBox.Text += "\r\n" + "*REPEATED*: " + mPlayers[i];
						mRepeatedName = true;
					}
					else
					{
						mMarkedPlayerIndices.Set( i, true );
						foundPlayer = true;
					}
				}
			}

			//  If we had a player marked that is not in the list, say so, and reset everything.
			if( !foundPlayer )
			{
				logsTextBox.Text += "\r\n" + "-[Incorrect name/s in priority list!]-";
				return;
			}

			//  Once we have had seven marked players, say the name of the eighth player if we can (otherwise say "Random").
			if( mNumMatches >= 7 )
			{
				//  If a player was marked twice, that means someone was dead, and twin marker will be random, so say so.
				if( mRepeatedName )
				{
					ActGlobals.oFormActMain.TTS( "Random" );
				}
				//  Otherwise, find the unmarked player, and say their name.
				else
				{
					for( int i = 0; i < System.Math.Min( mPlayers.Count, mMarkedPlayerIndices.Count ); ++i )
					{
						if( !mMarkedPlayerIndices[i] )
						{
							ActGlobals.oFormActMain.TTS( mPlayers[i] );
							logsTextBox.Text += "\r\n" + mPlayers[i];
							return;
						}
					}
				}

				//  Clean up now that we're done.
				ResetOctetComputer();
			}
		}

		/////////////////
		//
		//  Utility Functions
		//
		/////////////////

		private void ResetOctetComputer()
		{
			logsTextBox.Text += "\r\n\r\n" + "=======[RESET]=======";
			mStopwatch.Reset();
			mNumMatches = 0;
			mMarkedPlayerIndices.SetAll( false );
			mRepeatedName = false;
		}

		/////////////////
		//
		//  Data Members
		//
		/////////////////

		//  Players in the party.  Configured in this plugin's tab.  Could probably be gotten automatically from ACT.
		protected List<string> mPlayers = new List<string>();

		//  A boolean array of whether a player in the mPlayers list has been marked for a dive.
		protected System.Collections.BitArray mMarkedPlayerIndices = new System.Collections.BitArray( 8, false );// whether each player in the list has been marked

		//  The regex string that indicates whether a player has been marked.
		protected const string mDiveRegEx = "1B:[0-9A-F]{8}:[\\w'-]+ [\\w'-]+:[0-9A-F]{4}:[0-9A-F]{4}:00(14|29|77):[0-9A-F]{4}:[0-9A-F]{4}:[0-9A-F]{4}:";

		//  Whether a player has been marked twice with a dive.
		protected bool mRepeatedName = false;

		//  The number of times the dive regex has been matched.  This should be the number of players marked so far for a dive.
		protected int mNumMatches = 0;

		//  A stopwatch to keep track of time, since the octet dives go out over a limited timeframe.
		protected System.Diagnostics.Stopwatch mStopwatch = new System.Diagnostics.Stopwatch();

		//  ACT and Designer Stuff
		Label lblStatus;    // The status label that appears in ACT's Plugin tab
		protected string settingsFile = Path.Combine( ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\OctetComputer.config.xml" );
		protected Panel panel1;
		protected TextBox player8TextBox;
		protected TextBox player7TextBox;
		protected TextBox player6TextBox;
		protected TextBox player5TextBox;
		protected TextBox player4TextBox;
		protected TextBox player3TextBox;
		protected TextBox player2TextBox;
		protected TextBox player1TextBox;
		protected System.ComponentModel.BackgroundWorker backgroundWorker1;
		protected TextBox logsTextBox;
		protected Button exportButton;
		protected Button importButton;
		SettingsSerializer xmlSettings;
	}
}