using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Automatic_Cradle_Control
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            Uart.PrintPortNames(COMcombo);
            Uart.FillBaudrateBox(baudCombo);
            AT.PrintSpeed(speedCombo);
            AT.PrintDuration(angleCombo);
            
    
           // uart.Init();
        }

        private void tittleLabel_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Automatic Cradle for Windows v1.0\n\tNorbert Bielak", 
                "About product", MessageBoxButtons.OK, MessageBoxIcon.Information);      
        }


        private void termTextBox_KeyUp(object sender, KeyEventArgs e)
        {       
            if(e.KeyCode == Keys.Enter)
            {
                string text = termTextBox.Text;
                text = termTextBox.Text.ToUpper();
                if (Uart.Send(serial, text)) Terminal.Items.Add(text);
                termTextBox.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Terminal.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            COMcombo.Items.Clear();
            Uart.PrintPortNames(COMcombo);
            if (serial.IsOpen)
            {
                
            }
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen)
            {         
                if(Uart.Init(serial, COMcombo, baudCombo)) connectButton.Text = "Disconnect " + "(" + serial.PortName + ")";
            }
            else
            {
                serial.Close();
                connectButton.Text = "Connect";
                MessageBox.Show("Disconnected with " + serial.PortName + "!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadLine();
            if (Terminal.InvokeRequired)
            {
                Terminal.Invoke(new Action(delegate () {
                    Uart.receivedData = data;
                    Terminal.Items.Add("Rx: " + data);
                }));
            }
            else
            {
                Terminal.Items.Add(data);
            }
        }

        private void setSpdButton_Click(object sender, EventArgs e)
        {
            if(speedCombo.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.spd] + AT.inoutArr[(byte)AT.Inout.param] + speedCombo.Text + AT.endl;
                if (Uart.Send(serial, cmd)) Terminal.Items.Add(cmd);
            }
        }

        private void setAngleButton_Click(object sender, EventArgs e)
        {
            if(angleCombo.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.dur] + AT.inoutArr[(byte)AT.Inout.param] + angleCombo.Text + AT.endl;
                if (Uart.Send(serial, cmd)) Terminal.Items.Add(cmd);
            }
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            if(timeText.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.tim] + AT.inoutArr[(byte)AT.Inout.param] + timeText.Text + AT.endl;
                if (Uart.Send(serial, cmd)) Terminal.Items.Add(cmd);
                
            }
        }
    }
}
