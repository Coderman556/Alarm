using System.Windows;
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

            Alarm alarm1 = new(time: DateTime.Now.ToString("hh:mm:ss"), isRepeat: true);

            alarm1.Ring();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeDisplay.Content = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}