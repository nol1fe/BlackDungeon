using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackDungeon
{
    public class SoundManager
    {
        private WMPLib.WindowsMediaPlayer player;
        public event EventHandler OnSoundComplete; 


        public SoundManager()
        {
            player = new WMPLib.WindowsMediaPlayer();
            player.PlayStateChange += WmPlayer_PlayStateChange;
        }

        public void PlaySound(string soundPath, EventHandler onSoundComplete)
        {
            OnSoundComplete = onSoundComplete;

            player.URL = Path.Combine(AppSettings.GetGameDirectory, soundPath);
            player.controls.play();
        }

        public void WmPlayer_PlayStateChange(int newState)
        {
            if ((MediaState)newState == MediaState.Stopped)
            {
                OnSoundComplete(this, new EventArgs());
            }
        }
    }
}
