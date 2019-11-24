using System;
using System.IO.Ports;
namespace SitecoreIoT
{
    public partial class Index : System.Web.UI.Page
    {
        SerialPort ardo;

        protected void Page_Load(object sender, EventArgs e)
        {
            ardo = new SerialPort();
            ardo.PortName = "COM4";
            ardo.BaudRate = 9600;
        }

        protected void BlueOn(object sender, EventArgs e)
        {
            string blue = "1";
            ardo.Open();
            ardo.Write(blue);
            ardo.Close();
        }
        protected void GreenOn(object sender, EventArgs e)
        {
            string green = "2";
            ardo.Open();
            ardo.Write(green);
            ardo.Close();
        }

        protected void OrangeOn(object sender, EventArgs e)
        {
            string orange = "3";
            ardo.Open();
            ardo.Write(orange);
            ardo.Close();
        }
        protected void RedOn(object sender, EventArgs e)
        {
            string red = "4";
            ardo.Open();
            ardo.Write(red);
            ardo.Close();
        }
    }
}