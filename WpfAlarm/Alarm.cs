using System.Media;
using System.Transactions;

namespace WpfAlarm
{
    internal class Alarm
    {
        public String ringTime;
        public Boolean repeat;
        public SoundPlayer ringTone;
        public int snoozeTime;
        private String baseUrl = "C:\\Users\\wilme\\Downloads\\";

        public Alarm()
        {
            ringTime = "";
            repeat = false;
            ringTone = new SoundPlayer();
            snoozeTime = 0;
        }

        public Alarm(String time, Boolean isRepeat = false, string ringToneName = "something.wav", int manualSnoozeTime = 5 * 60 * 1000)
        {
            ringTime = time;
            repeat = isRepeat;
            ringTone = new SoundPlayer(baseUrl + ringToneName);
            snoozeTime = manualSnoozeTime;
            
        }

        public void compareTime(DateTime time)
        {
            if (time.Equals(ringTime))
            {
                Ring();
            }
        }

        public void Ring()
        {
            ringTone.PlayLooping();
        }

        public void SnoozeAlarm()
        {
            ringTone.Stop();
            Thread.Sleep(snoozeTime);
        }

        public void EndAlarm()
        {
            ringTone.Stop();
        }
    }
}