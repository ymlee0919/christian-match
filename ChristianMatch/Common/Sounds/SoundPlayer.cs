using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianMatch.Common.Sounds
{
    class SoundPlayer
    {
        System.Media.SoundPlayer masterPlayer;

        private static SoundPlayer instance = null;

        private string sourceDir;

        private SoundPlayer()
        {
            this.masterPlayer = new System.Media.SoundPlayer();
            this.sourceDir = System.Environment.CurrentDirectory + "\\resources\\sounds\\";
        }

        public static SoundPlayer Instance
        {
            get
            {
                if (SoundPlayer.instance == null)
                    SoundPlayer.instance = new SoundPlayer();

                return SoundPlayer.instance;
            }
        }

        public void Play(string sound)
        {
            this.masterPlayer.SoundLocation = this.sourceDir + sound + ".wav";
            this.masterPlayer.Play();
        }

        public void Stop()
        {
            this.masterPlayer.Stop();
        }

    }
}
