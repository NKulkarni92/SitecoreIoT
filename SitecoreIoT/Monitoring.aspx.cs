using System;
using System.IO.Ports;

namespace SitecoreIoT
{
    public partial class Monitoring : System.Web.UI.Page
    {
        SerialPort ardo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //set initial label text
            Label1.Text = "";
            //set com port for arduino
            ardo = new SerialPort();
            ardo.PortName = "COM4";
            ardo.BaudRate = 9600;
        }
        protected void BlueOn(object sender, EventArgs e)
        {
            ardo.DataReceived += OnReceived;
            string blue = "1";
            ardo.Open();
            ardo.Write(blue);
            System.Threading.Thread.Sleep(2000);
            ardo.Close();
        }
        protected void GreenOn(object sender, EventArgs e)
        {
            ardo.DataReceived += OnReceived;
            string green = "2";
            ardo.Open();
            ardo.Write(green);
            System.Threading.Thread.Sleep(2000);
            ardo.Close();
        }
        protected void OrangeOn(object sender, EventArgs e)
        {
            ardo.DataReceived += OnReceived;
            string orange = "3";
            ardo.Open();
            ardo.Write(orange);
            System.Threading.Thread.Sleep(2000);
            ardo.Close();
        }
        protected void RedOn(object sender, EventArgs e)
        {
            ardo.DataReceived += OnReceived;
            string red = "4";
            ardo.Open();
            ardo.Write(red);
            System.Threading.Thread.Sleep(2000);
            ardo.Close();
        }
        protected void OnReceived(object sender, SerialDataReceivedEventArgs c)
        {
            try
            {
                // write out text coming back from the arduino
                Label1.Text = ardo.ReadLine();
            }
            catch (Exception)
            {
                Label1.Text = ("COM Return Error");
            }
        }
    }
}