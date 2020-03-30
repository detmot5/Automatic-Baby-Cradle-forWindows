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
            range=2,
            spd=3,
            stop=4,
            fac=5,
            rst=6,
            tim=7,
            slptim=8
        }

        public enum Inout
        {
            ask = 0,
            param = 1,
            noParam = 2
        }
        public static readonly string[] inoutArr = new string[] { "?", "=", "" };
        public static readonly string[] commandsArr = new string[] { "AT", "ATI", "AT+RANGE", "AT+SPD", "AT+STOP", "AT+FAC", "AT+RST", "AT+TIM","AT+SLPTIM" };
        public static readonly string endl = "\r\n";

        public static readonly byte minValueOfparam = 1;
        public static readonly byte maxValueOfparam = 9;

        public static void PrintSpeed(ComboBox combo)
        {
            for(int i = minValueOfparam; i <= maxValueOfparam; i++)
            {
                combo.Items.Add(i);
            }
        }

        public static void PrintDuration(ComboBox combo)
        {
            for(int i = minValueOfparam; i <= maxValueOfparam; i++)
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
