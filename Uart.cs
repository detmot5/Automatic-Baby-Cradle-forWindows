using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Automatic_Cradle_Control
{
    class Uart
    {
        public static readonly int[] baudrateArray = new int[] { 9600, 14400, 19200, 28800, 38400, 57600, 76800, 115200 };
        public SerialPort Serial = new SerialPort();

        public delegate void SerialPortDataReceivedCallback(string data);
        private SerialPortDataReceivedCallback SerialPortCallback;

        public static void PrintPortNames(ComboBox comboBox)
        {
            comboBox.Items.AddRange(SerialPort.GetPortNames());   
        }


        public static void FillBaudrateBox(ComboBox comboBox)
        {
            foreach (int i in baudrateArray){
                comboBox.Items.Add(i);
            }
        }

        public bool isOpen()
        {
            return Serial.IsOpen;
        }

        public bool Init(string portName, int baudrate, SerialPortDataReceivedCallback callback)
        {
            try
            {
                Serial.PortName = portName;
                Serial.BaudRate = baudrate;
                Serial.DataBits = 8;
                Serial.Parity = Parity.None;
                Serial.StopBits = StopBits.One;
                Serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                SerialPortCallback = callback;
                
                Serial.Open();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Port is already opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Enter a valid port name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter baudrate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Port not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        public bool Send(string data)
        {
            try
            {
                Serial.WriteLine(data);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Port is closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            
            try
            {
                string data = Serial.ReadLine();
                if (data.Length == 0 || data == null) return;
             
                SerialPortCallback(data);
                
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Error Reading From Device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error Reading From Device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
