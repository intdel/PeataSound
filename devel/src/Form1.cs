using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PeataSound.Data;

namespace PeataSound
{
    public partial class Form1 : Form
    {
        private String nextRun = null;
        private ConfigHandler configHandler = null;
        private SoundHandler soundHandler = null;
        private Thread soundThread = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize everything
            this.configHandler = new ConfigHandler();
            this.soundHandler = new SoundHandler();
            this.soundThread = new Thread(soundHandler.threadHandling);

            try
            {
                configHandler.readConfig();
            } catch (Exception exception)
            {
                MessageBox.Show("An error occurred during reading the configuration file:\n" + exception.Message, "Uh-Oh!");
                Application.Exit();
            }

            //Set up all the stuff in the interface and read config values
            currentSoundFileNameLabel.Text = configHandler.SoundFileName;

            if (configHandler.ActiveStatus)
            {
                toolStripStatusLabel.Text = "Running";
                runBackgroundWorker();
            }
            else
            {
                toolStripStatusLabel.Text = "Stopped";
            }
            
            minuteSelector.Value = configHandler.PlayEvery;
            toolStripNextTimeLabel.Text = new TimeHandler().calculateNextLaunch(configHandler.PlayEvery);
            nextRun = toolStripNextTimeLabel.Text;

            volumeBar.Value = configHandler.VolumeValue;
            volumeValueLabel.Text = volumeBar.Value + " %";

            durationSelector.Maximum = Int32.MaxValue;
            durationSelector.Value = configHandler.Duration;

            soundHandler.File = configHandler.SoundFileLocation;
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void selectSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectSoundDialog.ShowDialog();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notifyIcon1.ShowBalloonTip(1);
        }

        private void minuteSelector_ValueChanged(object sender, EventArgs e)
        {
            if (minuteSelector.Value < 2 && minuteSelector.Value > 0)
            {
                minutesLabel.Text = "minute.";
            }
            else
            {
                minutesLabel.Text = "minutes.";
            }

            updateTime();

        }

        private void backgroundLauncher_DoWork(object sender, DoWorkEventArgs e)
        {
            String currentTime = DateTime.Now.ToString("HH:mm");

            while ((String.Equals(currentTime, nextRun)) == false && backgroundLauncher.CancellationPending == false)
            {
                currentTime = DateTime.Now.ToString("HH:mm");
            }

            if (backgroundLauncher.CancellationPending)
            {
                backgroundLauncher.ReportProgress(0);
            }
            else
            {
                backgroundLauncher.ReportProgress(100);
            }
            
        }

        private void backgroundLauncher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 100)
            {
                startSound();
                updateTime();
            }
            else
            {
                soundThread.Interrupt();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            runBackgroundWorker();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopBackgroundWorker();
        }

        private void runBackgroundWorker()
        {
            if (backgroundLauncher.IsBusy)
            {
                backgroundLauncher.CancelAsync();
                MessageBox.Show("Background task still busy. Please try again later!");
            }
            else
            {
                backgroundLauncher.RunWorkerAsync();
                configHandler.ActiveStatus = true;
                toolStripStatusLabel.Text = "Running";
            }
            

        }

        private void stopBackgroundWorker()
        {
            backgroundLauncher.CancelAsync();
            configHandler.ActiveStatus = false;
            toolStripStatusLabel.Text = "Stopped";
        }

        private void updateTime()
        {
            configHandler.PlayEvery = (int)minuteSelector.Value;
            toolStripNextTimeLabel.Text = new TimeHandler().calculateNextLaunch(configHandler.PlayEvery);
            nextRun = toolStripNextTimeLabel.Text;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if ( this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {

           MessageBox.Show("Volume adjustment is not available in this version.\nPlease check the GitHub page for new versions.");
           volumeBar.Value = configHandler.VolumeValue;
            /*
            volumeValueLabel.Text = volumeBar.Value + " %";
            configHandler.VolumeValue = volumeBar.Value;
             */
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            selectSoundDialog.ShowDialog();
            configHandler.SoundFileLocation = selectSoundDialog.FileName;
            configHandler.SoundFileName = selectSoundDialog.SafeFileName;

            currentSoundFileNameLabel.Text = selectSoundDialog.SafeFileName;
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (soundHandler.MusicPlaying == true)
            {
                soundThread.Interrupt();
                playButton.Text = "Prelisten";
            }
            else
            {
                startSound();
                playButton.Text = "Stop";
                testSoundButtonWatcher.RunWorkerAsync();
            }
        }

        private void startSound()
        {
            try
            {
                //Disable buttons so User cannot damage application health


               if (soundThread == null || soundThread.ThreadState == ThreadState.Stopped)
               { 
                   soundThread = new Thread(soundHandler.threadHandling);
               }
                 soundThread.Start();
            } catch (Exception exception)
            {
                MessageBox.Show("Sound could not be played:\n" + exception.Message);
                
            }
        }

        private void durationSelector_ValueChanged(object sender, EventArgs e)
        {
            //Update important values
            configHandler.Duration = (int)durationSelector.Value;
            soundHandler.Duration = configHandler.Duration;
        }

        private void testSoundButtonWatcher_DoWork(object sender, DoWorkEventArgs e)
        {
            while (soundThread.ThreadState != ThreadState.Stopped)
            {
             
                
            }
            
        }

        private void testSoundButtonWatcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            playButton.Enabled = true;
            playButton.Text = "Prelisten";
        }

        private void backgroundLauncher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Restart itself
            startButton.Enabled = true;
            if (configHandler.ActiveStatus)
            {
                backgroundLauncher.RunWorkerAsync();
            }
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
       
    }
}
