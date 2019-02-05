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
using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace SmsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            var accountSid = "AC499727bcfb1d7139fcce0fd18197a192";
            var authToken = "4938a62f0ad7f4907691284fcd75fb41";
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                to: new PhoneNumber(ToNumber.Text),
                from: new PhoneNumber(FromNumber.Text),
                body: Message.Text);
            MessageBox.Show("Message Sent");
        }
    }
}
        