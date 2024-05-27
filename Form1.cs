using NAudio.Utils;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Muusika_Kuulamis_Programm
{
    public partial class Form1 : Form
    {
        // Music player instances
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        // File dialog instance
        private OpenFileDialog songFileDialog;

        // TODO:
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            CreateAudioPlayer();
            CreateTimer();
            SubscribeToEvents();
            CheckSongStatus();
        }

        private void CreateTimer()
        {
            if (timer != null) return;
            timer = new();
        }

        #region 
        private void SubscribeToEvents()
        {
            Application.ApplicationExit += Application_ApplicationExit;
            timer.Tick += timer_Tick;
            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;
        }

        private void Application_ApplicationExit(object? sender, EventArgs e)
        {
            timer.Dispose();
            DisposeOldSong();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            outputDevice?.Stop();
            CheckSongStatus();
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CreateAudioPlayer()
        {
            if (outputDevice != null) return;
            outputDevice = new();
        }

        private void OutputDevice_PlaybackStopped(object? sender, StoppedEventArgs e)
        {
            DisposeOldSong();
            CheckSongStatus();
        }

        private void btn_add_songs_to_list_Click(object sender, EventArgs e)
        {
            // Create & configure new instance
            songFileDialog = new OpenFileDialog
            {
                Title = "Vali sobivad laulud",
                Multiselect = true,
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                Filter = "Muusika|*.mp3|*.wav|*.*",
                DefaultExt = "mp3",
                InitialDirectory = @"C:\Music"
            };

            // Open selection screen
            if (songFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (songFileDialog.FileNames.Length == 0) return;

                foreach (var file in songFileDialog.FileNames)
                {
                    string path = file;
                    string cleanName = Path.GetFileName(file).Replace(".mp3", "");

                    SongInfo newSong = new(cleanName, path);
                    SongCollection.songCollection.Add(newSong);
                }
                DisplayAvailableSongs();
            }
        }

        private void DisplayAvailableSongs()
        {
            string outputText = "";
            foreach (var song in SongCollection.songCollection)
            {
                outputText += song.CleanName;
                outputText += "\n";
            }
            tb_song_list.Text = outputText;
        }

        private void btn_clear_song_list_Click(object sender, EventArgs e)
        {
            SongCollection.songCollection.Clear();
            CurrentlyPlayingSong.currentSong = null;
            outputDevice?.Stop();
            DisplayAvailableSongs();
            ClearGuessData();
            CheckSongStatus();
        }

        private void btn_submit_guess_Click(object sender, EventArgs e)
        {
            SongInfo playingSong = CurrentlyPlayingSong.currentSong;

            if (playingSong == null) return;

            // Check guess validity 
            int points = 0;

            string guessTitle = tb_guess_title.Text.ToLower();
            string guessAuthor = tb_guess_author.Text.ToLower();
            string cleanNameLower = playingSong.CleanName.ToLower();

            if (cleanNameLower.Contains(guessAuthor) && guessAuthor != "")
            {
                points++;
            }

            if (cleanNameLower.Contains(guessTitle) && guessTitle != "")
            {
                points++;
            }

            // Display points
            label_guess_result.Text = $"{points} / 2";

            // Display the correct song name at top
            label_song_cleanname.Text = playingSong.CleanName;
        }

        private void ClearGuessData()
        {
            tb_guess_title.Text = "";
            tb_guess_author.Text = "";
            label_guess_result.Text = "? / 2";
            label_song_cleanname.Text = "";
        }

        private void RandomChooseNextSong()
        {
            var rng = new Random();
            var collection = SongCollection.songCollection;

            SongInfo prevSongObject = CurrentlyPlayingSong.currentSong;
            SongInfo nextSongObject = prevSongObject;

            // Ensures that the same song doesn't get played twice
            if (collection.Count > 1)
            {
                while (prevSongObject == nextSongObject)
                {
                    nextSongObject = collection[rng.Next(collection.Count)];
                }
                CurrentlyPlayingSong.currentSong = nextSongObject;
            }
            else
            {
                CurrentlyPlayingSong.currentSong = collection[0];
            }
        }

        private void LoadNewSong(string path)
        {
            DisposeOldSong();
            CreateAudioPlayer();

            audioFile = new(path);
            outputDevice.Init(audioFile);
        }

        private void PlayChosenSong()
        {
            string songPath = CurrentlyPlayingSong.currentSong.Path;

            // Prepare new song
            LoadNewSong(songPath);

            // Get random start time
            int song_max_length = int.Parse(tb_song_max_length.Text);
            if (song_max_length >= 400) song_max_length = 0;
            TimeSpan listeningPeriod = TimeSpan.FromSeconds(song_max_length);

            TimeSpan skipTime = CalculateSongStartTime(listeningPeriod, audioFile.TotalTime, cb_ignore_song_max_length.Checked);

            outputDevice.Play();

            if (!cb_ignore_song_max_length.Checked)
            {
                audioFile.CurrentTime = skipTime;
                StartSongDurationTimer(listeningPeriod);
            }
        }

        private TimeSpan CalculateSongStartTime(TimeSpan maxSongListeningTime, TimeSpan duration, bool playFullSong)
        {
            if (playFullSong) return TimeSpan.Zero;

            int startTimeFrame = (int)duration.Subtract(maxSongListeningTime).TotalSeconds;

            // If the length of the song is smaller than the limited listening period then start the song from the beginning
            if (startTimeFrame <= 0) return TimeSpan.Zero;

            int startSecond = new Random().Next(startTimeFrame);

            return TimeSpan.FromSeconds(startSecond);
        }

        private void StartSongDurationTimer(TimeSpan songDur)
        {
            timer.Interval = (int) songDur.TotalSeconds * 1000;
            timer.Start();
        }

        private void btn_play_shuffle_song_Click(object sender, EventArgs e)
        {
            if (SongCollection.songCollection.Count == 0) return;

            // Clear answer text fields
            ClearGuessData();

            // Choose next song
            RandomChooseNextSong();

            // Play song & reset resule/play song status 
            PlayChosenSong();

            CheckSongStatus();
        }


        private void DisposeOldSong()
        {
            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        private void btn_play_or_pause_current_song_Click(object sender, EventArgs e)
        {
            CheckActionSongStatus();
        }

        private void CheckSongStatus()
        {
            if (outputDevice == null) return;
            switch (outputDevice.PlaybackState)
            {
                case PlaybackState.Playing:
                    btn_play_or_pause_current_song.Text = "Peata";
                    break;

                case PlaybackState.Paused:
                    btn_play_or_pause_current_song.Text = "Jätka";
                    break;

                case PlaybackState.Stopped:
                    btn_play_or_pause_current_song.Text = " ";
                    break;
            }
        }

        private void CheckActionSongStatus()
        {
            if (outputDevice == null) return;
            switch (outputDevice.PlaybackState)
            {
                case PlaybackState.Playing:
                    outputDevice.Pause();
                    btn_play_or_pause_current_song.Text = "Jätka";
                    break;

                case PlaybackState.Paused:
                    outputDevice.Play();
                    btn_play_or_pause_current_song.Text = "Peata";
                    break;

                case PlaybackState.Stopped:
                    btn_play_or_pause_current_song.Text = " ";
                    break;
            }
        }
    }

    public class SongInfo
    {
        public SongInfo(string _cleanname, string _path)
        {
            Id = SongCollection.songCollection.Count + 1;
            CleanName = _cleanname;
            Path = _path;
        }

        public int Id { get; set; }
        public string CleanName { get; set; }
        public string Path { get; set; }
    }


    public static class CurrentlyPlayingSong
    {
        public static SongInfo currentSong;
    }


    public static class SongCollection
    {
        public static List<SongInfo> songCollection = new List<SongInfo>();
    }
}
