using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAlarm
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AddAlarmPopupDialog : UserControl
    {
        public AddAlarmPopupDialog()
        {
            InitializeComponent();
        }

        private void OButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK clicked");
        }

        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cancel clicked");
        }
    }
}
