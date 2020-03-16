using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Cradle_Control
{
    static class AT
    {
        //------ATcommands------
        public enum Cmd
        {
            at=0,
            ati=1,
            dur=2,
            spd=3,
            stop=4,
            fac=5,
            rst=6,
            tim=7
        }

        public enum Inout
        {
            ask = 0,
            param = 1,
            noParam = 2
        }
        public static readonly string[] inoutArr = new string[] { "?", "=", "" };
        public static readonly string[] commandsArr = new string[] { "AT", "ATI", "AT+DUR", "AT+SPD", "AT+STOP", "AT+FAC", "AT+RST", "AT+TIM" };
        public static readonly string endl = "\r\n";

        public static readonly byte minDelaySpeed = 1;
        public static readonly byte maxDelaySpeed = 7;

        public static readonly short minDuration = 500;
        public static readonly short maxDuration = 2500;

        public static void PrintSpeed(ComboBox combo)
        {
            for(int i = minDelaySpeed; i <= maxDelaySpeed; i++)
            {
                combo.Items.Add(i);
            }
        }

        public static void PrintDuration(ComboBox combo)
        {
            for(int i = minDuration; i <= maxDuration; i += 100)
            {
                combo.Items.Add(i);
            }
        }

        //---------------------

    }

    static class ATparam
    {
        public static readonly string fac_rst = "-a";
    }

}
