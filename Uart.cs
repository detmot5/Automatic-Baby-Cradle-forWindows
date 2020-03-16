using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Automatic_Cradle_Control
{
    class Uart
    {
        public static readonly int[] baudrateArray = new int[] { 9600, 14400, 19200, 28800, 38400, 57600, 76800, 115200 };
        public static string receivedData;
        public static string commandToSend;

   
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

        public static bool Init(SerialPort serial, ComboBox portList, ComboBox baudrateList)
        {
            try
            {
                serial.PortName = portList.Text;
                serial.BaudRate = int.Parse(baudrateList.Text);
                serial.Open();
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

        public static bool Send(SerialPort serialPort, string data)
        {
            try
            {
                serialPort.WriteLine(data);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Port is closed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
