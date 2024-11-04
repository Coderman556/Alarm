using System.IO;
using System.Linq.Expressions;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAlarm
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeDisplay.Content = DateTime.Now.ToString("hh:mm:ss");
        }

    }


    public class Alarm
    {
        public DateTime ringTime;
        public Boolean repeat;
        public SoundPlayer ringTone;

        public Alarm(DateTime time, Boolean isRepeat)
        {
            ringTime = time;
            repeat = isRepeat;
            ringTone = new SoundPlayer("something.wav");
        }

        public void compareTime(DateTime time)
        {
            if (time == ringTime)
            {
                ring();
            }
        }

        public void ring()
        {

        }
    }

    
}