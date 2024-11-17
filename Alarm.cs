using System;
using System.Media;
namespace WpfAlarm
{
    public class Alarm
    {
        public String ringTime;
        public Boolean repeat;
        public SoundPlayer ringTone;

        public Alarm(String time, Boolean isRepeat)
        {
            ringTime = time;
            repeat = isRepeat;
            ringTone = new SoundPlayer("something.wav");
        }

        public void CompareTime(String time) // needs to be in hh:mm:ss
        {
            if (time == ringTime)
            {
                Ring();
            }
        }

        public void Ring()
        {
            ringTone.Play();
        }
    }

}
