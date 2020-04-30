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
using System.IO;


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
                if (App.Serial.Send(text + AT.endl)) Terminal.Items.Add("Tx: " + text);
                termTextBox.Text = "";
            }
            else if(e.KeyCode == Keys.Up)
            {
                string nextVal = (string)Terminal.Items[Terminal.Items.Count - 1];
                nextVal = nextVal.Remove(0, 4); //remove the 
                termTextBox.Text = nextVal;

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
            if (!App.Serial.isOpen())
            {
                connectButton.Text = "Connect";         
            }

        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!App.Serial.isOpen())
            {
                if (App.Serial.Init(COMcombo.Text, int.Parse(baudCombo.Text),ua))
                {
                    connectButton.Text = "Disconnect " + "(" + COMcombo.Text + ")";
                    App.Serial.Send(AT.commandsArr[(byte)AT.Cmd.ati] + AT.endl);
                }


            }
            else
            {         
                connectButton.Text = "Connect";
                MessageBox.Show("Disconnected with " + serial.PortName + "!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ua(string data)
        {
            Terminal.Invoke(new Action(delegate () {

                AT.ParseReceivedData(data, speedValueLabel, rangeValueLabel, stopFlagStateLabel);
                Terminal.Items.Add("Rx: " + data);
            }));
        }



        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
              
                string data = serial.ReadLine();

                if (data.Length == 0 || data == null) return;
               
                

                if (Terminal.InvokeRequired)
                {
                    Terminal.Invoke(new Action(delegate () {
                        
                        AT.ParseReceivedData(data, speedValueLabel, rangeValueLabel, stopFlagStateLabel);
                        Terminal.Items.Add("Rx: " + data);
                    }));
                }
                else
                {
                    Terminal.Items.Add(data);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading from device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void setSpdButton_Click(object sender, EventArgs e)
        {
            if(speedCombo.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.spd] + AT.inoutArr[(byte)AT.Inout.param] + speedCombo.Text + AT.endl;
                if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx: " + cmd);
            }
        }

        private void setAngleButton_Click(object sender, EventArgs e)
        {
            if(angleCombo.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.range] + AT.inoutArr[(byte)AT.Inout.param] + angleCombo.Text + AT.endl;
                if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx:" + cmd);
            }
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            if(timeText.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.tim] + AT.inoutArr[(byte)AT.Inout.param] + timeText.Text + AT.endl;
                if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx: " + cmd);        
            }
        }
        private void slpTimeButton_Click(object sender, EventArgs e)
        {
            if (slpTimeText.Text != "")
            {
                string cmd = AT.commandsArr[(byte)AT.Cmd.slptim] + AT.inoutArr[(byte)AT.Inout.param] + slpTimeText.Text + AT.endl;
                if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx: " + cmd);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            string cmd = AT.commandsArr[(byte)AT.Cmd.rst] + AT.inoutArr[(byte)AT.Inout.noParam] + AT.endl;
            if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx:" + cmd);
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            string cmd = AT.commandsArr[(byte)AT.Cmd.stop] + AT.inoutArr[(byte)AT.Inout.noParam] + AT.endl;
            if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx:" + cmd);
        }

        private void facRstButton_Click(object sender, EventArgs e)
        {
            string cmd = AT.commandsArr[(byte)AT.Cmd.fac] + AT.inoutArr[(byte)AT.Inout.noParam] + AT.endl;
            if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx:" + cmd);
            
        }

        private void offTimButton_Click(object sender, EventArgs e)
        {
            string cmd = AT.commandsArr[(byte)AT.Cmd.tim] + AT.inoutArr[(byte)AT.Inout.param] + "-1" + AT.endl;
            if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx:" + cmd);
        }

        private void timPauseButton_Click(object sender, EventArgs e)
        {
            string cmd = AT.commandsArr[(byte)AT.Cmd.tim] + AT.inoutArr[(byte)AT.Inout.noParam] + AT.endl;
            if (App.Serial.Send(cmd)) Terminal.Items.Add("Tx:" + cmd);        
        }

    }
}
