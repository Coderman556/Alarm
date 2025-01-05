using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;



namespace WpfAlarm
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            List<Alarm> alarmArray = new List<Alarm>();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            Alarm alarm1 = new(time: DateTime.Now.ToString("hh:mm:ss"), isRepeat: true);

            alarm1.Ring();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            TimeDisplay.Content = DateTime.Now.ToString("hh:mm:ss");

        }

        private void Compare_Time(object? sender, EventArgs e)
        {

        }

        private void Add_Alarm(object sender, RoutedEventArgs e)
        {
            AddAlarmPopupDialog newAlarm = new AddAlarmPopupDialog();
        }
    }
}