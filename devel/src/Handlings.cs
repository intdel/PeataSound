using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;

namespace PeataSound.Data
{
    class ConfigHandler
    {
        private String soundFileLocation = null;
        private String soundFileName = null;
        private int playEvery = -1;
        private Boolean activeStatus = false;
        private int volumeValue = 0;
        private int duration = 0;

        public string SoundFileLocation
        {
            get { return soundFileLocation; }
            set { soundFileLocation = value; }
        }

        public string SoundFileName
        {
            get { return soundFileName; }
            set { soundFileName = value; }
        }

        public int PlayEvery
        {
            get { return playEvery; }
            set { playEvery = value; }
        }

        public bool ActiveStatus
        {
            get { return activeStatus; }
            set { activeStatus = value; }
        }

        public int VolumeValue
        {
            get { return volumeValue; }
            set { volumeValue = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Boolean readConfig()
        {
            int lines = -1;
            byte[] data;
            String content = null;
            String[] splitLines = null;
            String currentLine = null;

            //use default config if no user config exists
            if ((File.Exists("config.txt")) == false)
            {
                File.Copy("default.dat", "config.txt");
            }

            //read file and split it up
            FileStream configFile = File.OpenRead("config.txt");
            data = new byte[configFile.Length];
            configFile.Read(data, 0, data.Length);
            content = Encoding.UTF8.GetString(data);
            configFile.Close();
            splitLines = content.Split('\n');
            lines = int.Parse(splitLines[0].Split('=')[1]); // get line numbers
            
            if ((splitLines.Length - 1) < lines)
            {
                throw new System.Runtime.InteropServices.ExternalException("Configuration file is corrupt.");
            }

            for (int i = 1; i < splitLines.Length; i++ )
            {
                currentLine = splitLines[i].Replace("\r", "");

                //write right value to right property
                //Case number = line number in config file
                switch (i)
                {
                    case 1: soundFileLocation = currentLine.Split('=')[1].Replace("\"", "");
                        break;
                    case 2: soundFileName = currentLine.Split('=')[1].Replace("\"", "");
                        break;
                    case 3: playEvery = int.Parse(currentLine.Split('=')[1]);
                        break;
                    case 4: activeStatus = Boolean.Parse(currentLine.Split('=')[1]);
                        break;
                    case 5: volumeValue = int.Parse(currentLine.Split('=')[1]);
                        break;
                    case 6: duration = int.Parse(currentLine.Split('=')[1]);
                        break;
                    default:
                        break;
                }
            }
                return true;
        }

        
    }
    
    class TimeHandler
    {
        //Calculate time for the play entry status bar and background worker
        public String calculateNextLaunch(int playEvery)
        {
            DateTime newDate =  DateTime.Now.AddMinutes((double)playEvery);

            return newDate.ToString("HH:mm");
        }
    }

    class SoundHandler
    {
        private SoundPlayer soundPlayer;
        private Boolean musicPlaying = false;
        private int duration = 0;
        private String file = null;

        public Boolean MusicPlaying
        {
            get { return musicPlaying; }
            set { musicPlaying = value; }
        }

        public int Duration { 

            get {return duration;}
            set {this.duration = value;}
        }

        public String File {
            get {return this.file;}
            set {this.file = value;}
        }

        //For multithreading
        public void threadHandling()
        {
            try
            {
                playMusic();
                Thread.Sleep(duration);
            } catch (ThreadInterruptedException exception)
            {
                stopMusic();
            } finally
            {
                stopMusic();
            }
            
            
        }


        public void playMusic (String fileName)
        {
            soundPlayer = new SoundPlayer(fileName);
            musicPlaying = true;
            soundPlayer.Play();
        }

        private void playMusic()
        {
            soundPlayer = new SoundPlayer(this.file);
            musicPlaying = true;
            soundPlayer.Play();
        }

        public void stopMusic ()
        {
            musicPlaying = false;
            soundPlayer.Stop();
        }

        public void changeVolume (int value)
        {

        }

    }

}


