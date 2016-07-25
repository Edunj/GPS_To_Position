using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace GPS_To_Position
{
    public partial class Form1 : Form
    {

        delegate void SetTextCallback(string text);
        delegate void SetTextLongCallback(string text);
        delegate void SetTextLatCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.TextGPS.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.TextGPS.Text += text;
            }
        }

        private void SetTextLong(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textB_Long.InvokeRequired)
            {
                SetTextLongCallback d = new SetTextLongCallback(SetTextLong);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textB_Long.Text = text;
            }
        }

        private void SetTextLat(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textB_Lat.InvokeRequired)
            {
                SetTextLatCallback d = new SetTextLatCallback(SetTextLat);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textB_Lat.Text = text;
            }
        }





        private void TextGPS_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            TextGPS.SelectionStart = TextGPS.Text.Length;
            // scroll it automatically
            TextGPS.ScrollToCaret();
        }



        public Form1()
        {
            InitializeComponent();      
        }




 

        private void Form1_Load(object sender, EventArgs e)
        {

            //Add com ports to comboBox
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            combo_COMS.Items.AddRange(ports);


        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {


            string text = serialPort1.ReadExisting().ToString();


            Decode_GPGGA_gps(text);
            SetText(text);
        }

        private /*string[]*/ void Decode_GPGGA_gps(string cadena)
        {
            
            int position2=0, position=0;
            string subcadena;
             position = cadena.IndexOf("GPGGA");
            if (position>0)
             position2 = cadena.IndexOf("GPGSA");

            if (position > 0 && position2 > 0)
            {
                //Cadena valida
                subcadena = cadena.Substring(position, position2-position);

                string[] subcadenas = subcadena.Split(',');
                SetTextLat(subcadenas[2].Substring(0,2) + "º " + subcadenas[2].Substring(2) + "' " + subcadenas[3]);
                SetTextLong(subcadenas[4].Substring(0, 3) + "º " + subcadenas[4].Substring(3) + "' " + subcadenas[5]);
            }


        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(textB_Baudios.Text);
            serialPort1.PortName = combo_COMS.SelectedItem.ToString();
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.ReceivedBytesThreshold = 256;
            serialPort1.Open();

        }


    }
}
